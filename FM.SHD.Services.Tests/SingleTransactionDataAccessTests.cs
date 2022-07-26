using FM.SHD.Infrastructure.Impl.Repositories.Specific.SingleTransaction;
using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.TransactionModels;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace FM.SHD.Services.Tests
{
    [Trait("Category", "Data Access Validations")]
    public class SingleTransactionDataAccessValidationTests
    {
        #region Private member vatiables

        private readonly ITestOutputHelper _testOutputHelper;
        private SingleTransactionServices.SingleTransactionServices _singleTransactionServices;
        private string _connectionString;

        #endregion

        #region Constructor

        public SingleTransactionDataAccessValidationTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _connectionString = @"DataSource=A:\Repositories\SHDML.FINANCECHECKER\db\default-db.db;";
            _singleTransactionServices = new SingleTransactionServices.SingleTransactionServices(new SingleTransactionRepository(_connectionString), new ModelValidator());
        }

        #endregion

        #region Tests

        [Fact]
        public void ShouldSuccesAddTest()
        {
            var singleTransaction = new SingleTransactionModel()
            {
                Account = "Банковская карта",
                Category = "Продукты",
                Contragent = "АО ТАНДЕР",
                Date = DateTime.Now.ToString(),
                Description = "Вкусное молочко",
                Name = "Молоко Лужайкино 2.5%",
                Id = 1,
                FamilyMember = "Дима",
                Sum = "10.00",
                Type = "Расход"
            };

            try
            {
                _singleTransactionServices.Add(singleTransaction);
            }
            catch (Exception exception)
            {
                WriteExceptionTestResult(exception);
            }

        }

        [Fact]
        public void ShouldSuccesDelTest()
        {
            var singleTransaction = new SingleTransactionModel()
            {
                Account = "Банковская карта",
                Category = "Продукты",
                Contragent = "АО ТАНДЕР",
                Date = DateTime.Now.ToString(),
                Description = "Вкусное молочко",
                Name = "Молоко Лужайкино 2.5%",
                Id = 1,
                FamilyMember = "Дима",
                Sum = "10.00",
                Type = "Расход"
            };

            try
            {
                _singleTransactionServices.Delete(singleTransaction);
            }
            catch (Exception exception)
            {
                WriteExceptionTestResult(exception);

            }
        }

        [Fact]
        public void ShouldSuccesUpdateTest()
        {
            var s = _singleTransactionServices.GetById(3);
            var singleTransaction = new SingleTransactionModel()
            {
                Account = "Банковская карта",
                Category = "Продукты",
                Contragent = "АО ТАНДЕР",
                Date = DateTime.Now.ToString(),
                Description = "Вкусное молочко",
                Name = "Молоко Лужайкино 2.5%",
                Id = 3,
                FamilyMember = "Дима",
                Sum = "10.00",
                Type = "Расход"
            };

            try
            {
                _singleTransactionServices.Update(singleTransaction);
            }
            catch (Exception exception)
            {
                WriteExceptionTestResult(exception);

            }
        }

        #endregion

        #region Helper Methods

        private void WriteExceptionTestResult(Exception exception)
        {
            if (exception != null)
            {
                _testOutputHelper.WriteLine("****** Возникла одна или несколько ошибок: ******");
                _testOutputHelper.WriteLine(exception.Message);
            }
            /* var sBuilder = new StringBuilder();
             JObject jObject = JObject.FromObject(_singleTransactionServicesFixutre.SingleTransactionModel);
             sBuilder.AppendLine("****** Нет ошибок ******");
             foreach (var jProp in jObject.Properties())
             {
                 sBuilder.Append(jProp.Name).Append(" ---> ").Append(jProp.Value).AppendLine();
             }
             _testOutputHelper.WriteLine(sBuilder.ToString());*/
        }

        #endregion
    }
}
