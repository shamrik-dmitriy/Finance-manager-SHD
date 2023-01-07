using System;
using System.Linq;
using FM.SHD.Services.AccountServices;
using FM.SHD.Services.TransactionServices;
using FM.SHDML.Core.Models.Dtos;
using Moq;
using Xunit;

namespace FM.SHD.Domain.Tests
{
    public class DomainTransactionUpdateTests
    {
        #region Тестирование изменения сумм

        /// <summary>
        ///     Расход - Доход. Тестирование суммы
        /// </summary>
        [Fact]
        public void DomainTransaction_OnUpdate_TransactionTypeHasChanged_ExpenseToIncome_CheckSum()
        {
            var mockTransactionServices = new MockRepository(MockBehavior.Default).Of<ITransactionServices>()
                .Where(x => x.GetById(It.Is<long>(id => id == 1)) == new TransactionDto()
                {
                    Id = 1,
                    Name = "Молоко Лужайкино ультр. 2.5%",
                    Description = "Молоко ультрапастеризованное, 2.5%",
                    Date = DateTime.Now,
                    Sum = (decimal)69.99,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = null,
                    DebitAccountId = 1,
                    TypeTransactionId = 1
                })
                .First();

            var mockAccountServices = new MockRepository(MockBehavior.Default).Of<IAccountServices>()
                .Where(services => services.GetById(It.Is<long>(id => id == 1)) == new AccountDto()
                {
                    Id = 1,
                    CurrentSum = -10
                })
                .Where(services => services.GetById(It.Is<long>(id => id == 2)) == new AccountDto()
                {
                    Id = 2,
                    CurrentSum = 10
                })
                .Where(services => services.GetById(It.Is<long>(id => id == 3)) == new AccountDto()
                {
                    Id = 3,
                    CurrentSum = 0
                })
                .First();

            var newTransaction = new TransactionDto()
            {
                Id = 1,
                Name = "Молоко Лужайкино ультр. 2.5%",
                Description = "Молоко ультрапастеризованное, 2.5%",
                Date = DateTime.Now,
                Sum = 30,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = null,
                DebitAccountId = 1,
                TypeTransactionId = 1
            };

            var transactionDomain = new TransactionsDomain(mockTransactionServices, mockAccountServices);

            var updatedTransaction = transactionDomain.OnUpdateTransaction(newTransaction);
            
            Assert.True(updatedTransaction.Sum == 30);
            Assert.True(mockAccountServices.GetById(1).CurrentSum == (decimal) -49.99);
            //Assert.True(mockAccountServices.GetById(1).CurrentSum == (decimal) -79.99);
        }

        #endregion

        #region Тестирование изменений по счетам

        /// <summary>
        ///     Расход - Доход
        /// </summary>
        [Fact]
        public void DomainTransaction_OnUpdate_TransactionTypeHasChanged_ExpenseToIncome_CheckAccounts_Info()
        {
            var idTransaction = GetHashCode();
            var mockAccountServices = new MockRepository(MockBehavior.Default).Of<IAccountServices>()
                .Where(services => services.GetById(It.Is<long>(id => id == 1)) == new AccountDto()
                {
                    Id = 1,
                    CurrentSum = 10
                })
                .Where(services => services.GetById(It.Is<long>(id => id == 2)) == new AccountDto()
                {
                    Id = 2,
                    CurrentSum = 0
                })
                .First();

            var transactionDomain = new TransactionsDomain(
                Mock.Of<ITransactionServices>(x => x.GetById(It.IsAny<long>()) == new TransactionDto()
                {
                    Id = idTransaction,
                    Name = "Молоко Лужайкино ультр. 2.5%",
                    Description = "Молоко ультрапастеризованное, 2.5%",
                    Date = DateTime.Now,
                    Sum = (decimal)69.99,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = null,
                    DebitAccountId = 1,
                    TypeTransactionId = 1
                }), mockAccountServices);


            var newTransaction = new TransactionDto()
            {
                Id = idTransaction,
                Name = "Молоко Лужайкино ультр. 2.5%",
                Description = "Молоко ультрапастеризованное, 2.5%",
                Date = DateTime.Now,
                Sum = (decimal)69.99,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = 2,
                DebitAccountId = null,
                TypeTransactionId = 2
            };

            var updatedTransaction = transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(updatedTransaction.CreditAccountId == 2);
            Assert.True(updatedTransaction.DebitAccountId == null);
        }

        #endregion
    }
}