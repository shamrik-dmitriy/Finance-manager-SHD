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
        private IAccountServices _accountServices;

        public DomainTransactionUpdateTests()
        {
            _accountServices = new MockRepository(MockBehavior.Default).Of<IAccountServices>()
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
                })   .Where(services => services.GetById(It.Is<long>(id => id == 4)) == new AccountDto()
                {
                    Id = 4,
                    CurrentSum = (decimal)305.65
                })
                .First();
        }

        #region Тестирование изменения сумм

        #region Без изменения типа транзакции

        /// <summary>
        ///     Расход.
        /// </summary>
        [Fact]
        public void DomainTransaction_OnUpdate_TransactionTypeHasNotChanged_Expense_CheckSum()
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
                }).Where(x => x.GetById(It.Is<long>(id => id == 2)) == new TransactionDto()
                {
                    Id = 2,
                    Name = "Молоко Лужайкино ультр. 2.5%",
                    Description = "Молоко ультрапастеризованное, 2.5%",
                    Date = DateTime.Now,
                    Sum = (decimal)69.99,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = null,
                    DebitAccountId = 2,
                    TypeTransactionId = 1
                }).Where(x => x.GetById(It.Is<long>(id => id == 3)) == new TransactionDto()
                {
                    Id = 2,
                    Name = "Молоко Лужайкино ультр. 2.5%",
                    Description = "Молоко ультрапастеризованное, 2.5%",
                    Date = DateTime.Now,
                    Sum = (decimal)69.99,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = null,
                    DebitAccountId = 3,
                    TypeTransactionId = 1
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

            var transactionDomain = new TransactionsDomain(mockTransactionServices, _accountServices);

            var updatedTransaction = transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(updatedTransaction.Sum == 30);
            Assert.True(_accountServices.GetById(1).CurrentSum == (decimal)29.99);

            newTransaction = new TransactionDto()
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
                DebitAccountId = 2,
                TypeTransactionId = 1
            };

            transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(_accountServices.GetById(2).CurrentSum == (decimal)49.99);

            newTransaction = new TransactionDto()
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
                DebitAccountId = 3,
                TypeTransactionId = 1
            };

            transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(_accountServices.GetById(3).CurrentSum == (decimal)39.99);
        }

        /// <summary>
        ///     Доход
        /// </summary>
        [Fact]
        public void DomainTransaction_OnUpdate_TransactionTypeHasNotChanged_Income_CheckSum()
        {
            var mockTransactionServices = new MockRepository(MockBehavior.Default).Of<ITransactionServices>()
                .Where(x => x.GetById(It.Is<long>(id => id == 1)) == new TransactionDto()
                {
                    Id = 1,
                    Name = "Сушилка для овощей и фруктов Supra",
                    Description = "Продал на Авито",
                    Date = DateTime.Now,
                    Sum = (decimal)500,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = 1,
                    DebitAccountId = null,
                    TypeTransactionId = 2
                }).Where(x => x.GetById(It.Is<long>(id => id == 2)) == new TransactionDto()
                {
                    Id = 2,
                    Name = "Гладильная доска Nika",
                    Description = "Продал на Авито",
                    Date = DateTime.Now,
                    Sum = (decimal)240,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = 2,
                    DebitAccountId = null,
                    TypeTransactionId = 2
                }).Where(x => x.GetById(It.Is<long>(id => id == 3)) == new TransactionDto()
                {
                    Id = 3,
                    Name = "Масло автомобильное 5W-30",
                    Description = "Сдал в магазин остатки",
                    Date = DateTime.Now,
                    Sum = (decimal)320.65,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = 3,
                    DebitAccountId = null,
                    TypeTransactionId = 2
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
                CreditAccountId = 1,
                DebitAccountId = null,
                TypeTransactionId = 2
            };

            var transactionDomain = new TransactionsDomain(mockTransactionServices, _accountServices);

            var updatedTransaction = transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(updatedTransaction.Sum == 30);
            Assert.True(_accountServices.GetById(1).CurrentSum == (decimal)-480);

            newTransaction = new TransactionDto()
            {
                Id = 1,
                Name = "Молоко Лужайкино ультр. 2.5%",
                Description = "Молоко ультрапастеризованное, 2.5%",
                Date = DateTime.Now,
                Sum = 30,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = 2,
                DebitAccountId = null,
                TypeTransactionId = 2
            };

            transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(_accountServices.GetById(2).CurrentSum == (decimal)-460);

            newTransaction = new TransactionDto()
            {
                Id = 1,
                Name = "Молоко Лужайкино ультр. 2.5%",
                Description = "Молоко ультрапастеризованное, 2.5%",
                Date = DateTime.Now,
                Sum = 650,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = 3,
                DebitAccountId = null,
                TypeTransactionId = 2
            };

            transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(_accountServices.GetById(3).CurrentSum == (decimal)150);
        }


        /// <summary>
        ///     Перевод
        /// </summary>
        [Fact]
        public void DomainTransaction_OnUpdate_TransactionTypeHasNotChanged_Transfer_CheckSum()
        {
            var mockTransactionServices = new MockRepository(MockBehavior.Default).Of<ITransactionServices>()
                .Where(x => x.GetById(It.Is<long>(id => id == 1)) == new TransactionDto()
                {
                    Id = 1,
                    Name = "Перевод на ипотеку",
                    Description = "Перевод на погашение ипотеки в банке",
                    Date = DateTime.Now,
                    Sum = (decimal)12500,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = 1,
                    DebitAccountId = 2,
                    TypeTransactionId = 3
                }).Where(x => x.GetById(It.Is<long>(id => id == 2)) == new TransactionDto()
                {
                    Id = 2,
                    Name = "Перевод на продукты",
                    Description = "Продукты",
                    Date = DateTime.Now,
                    Sum = (decimal)2500,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = 2,
                    DebitAccountId = 3,
                    TypeTransactionId = 3
                }).Where(x => x.GetById(It.Is<long>(id => id == 3)) == new TransactionDto()
                {
                    Id = 3,
                    Name = "Перевод на ЖКХ",
                    Description = "ЖКХ",
                    Date = DateTime.Now,
                    Sum = (decimal)320.65,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = 3,
                    DebitAccountId = 2,
                    TypeTransactionId = 3
                }).Where(x => x.GetById(It.Is<long>(id => id == 4)) == new TransactionDto()
                {
                    Id = 4,
                    Name = "Перевод на ЖКХ",
                    Description = "ЖКХ",
                    Date = DateTime.Now,
                    Sum = (decimal)320.65,
                    CategoryId = 1,
                    ContragentId = 1,
                    IdentityId = 1,
                    CreditAccountId = 1,
                    DebitAccountId = 4,
                    TypeTransactionId = 3
                })
                .First();

            var newTransaction = new TransactionDto()
            {
                Id = 1,
                Name = "Перевод на ипотеку",
                Description = "Перевод на погашение ипотеки в банке",
                Date = DateTime.Now,
                Sum = (decimal)3500,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = 1,
                DebitAccountId = 2,
                TypeTransactionId = 3
            };

            var transactionDomain = new TransactionsDomain(mockTransactionServices, _accountServices);

            transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(_accountServices.GetById(1).CurrentSum == (decimal)-9010);
            Assert.True(_accountServices.GetById(2).CurrentSum == (decimal)9010);

            newTransaction = new TransactionDto()
            {
                Id = 2,
                Name = "Перевод на продукты",
                Description = "Продукты",
                Date = DateTime.Now,
                Sum = (decimal)30,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = 2,
                DebitAccountId = 3,
                TypeTransactionId = 3
            };

            transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(_accountServices.GetById(2).CurrentSum == (decimal)6540);
            Assert.True(_accountServices.GetById(3).CurrentSum == (decimal)2470);
            
            newTransaction = new TransactionDto()
            {
                Id = 3,
                Name = "Перевод на ЖКХ",
                Description = "ЖКХ",
                Date = DateTime.Now,
                Sum = (decimal)0.6,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = 2,
                DebitAccountId = 1,
                TypeTransactionId = 3
            };

            transactionDomain.OnUpdateTransaction(newTransaction);

            Assert.True(_accountServices.GetById(1).CurrentSum == (decimal)-9010.6);
            Assert.True(_accountServices.GetById(2).CurrentSum == (decimal)6861.25);
            Assert.True(_accountServices.GetById(3).CurrentSum == (decimal)2149.35);
            
            newTransaction = new TransactionDto()
            {
                Id = 3,
                Name = "Перевод на ЖКХ",
                Description = "ЖКХ",
                Date = DateTime.Now,
                Sum = (decimal)0.6,
                CategoryId = 1,
                ContragentId = 1,
                IdentityId = 1,
                CreditAccountId = 2,
                DebitAccountId = 3,
                TypeTransactionId = 3
            };

            transactionDomain.OnUpdateTransaction(newTransaction);
            
            Assert.True(_accountServices.GetById(1).CurrentSum == (decimal)-9010.6);
            Assert.True(_accountServices.GetById(2).CurrentSum == (decimal)7182.50);
            Assert.True(_accountServices.GetById(3).CurrentSum == (decimal)1828.10);
            Assert.True(_accountServices.GetById(4).CurrentSum == (decimal)305.65);
        }

        #endregion

        #region С Изменением типа транзакции

        #endregion

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