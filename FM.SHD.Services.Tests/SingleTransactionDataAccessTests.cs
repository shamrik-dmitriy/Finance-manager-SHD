using FM.SHD.Infrastructure.Impl.Repositories.Specific.SingleTransaction;
using FM.SHD.Services.CommonServices;
using FM.SHDML.Core.Models.TransactionModels.SignleTransaction;
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
            _connectionString = @"DataSource=C:\Repositories\Finance-manager-SHD\db\default-db.db;";
            _singleTransactionServices = new SingleTransactionServices.SingleTransactionServices(new SingleTransactionRepository(_connectionString), new ModelValidator());
        }

        #endregion

        #region Tests

        [Fact]
        public void ShouldSuccesAddTest()
        {
            var singleTransaction = new SingleTransactionModel()
            {
                Account = "���������� �����",
                Category = "��������",
                Contragent = "�� ������",
                Date = DateTime.Now.ToString(),
                Description = "������� �������",
                Name = "������ ��������� 2.5%",
                Id = 1,
                FamilyMember = "����",
                Sum = "10.00",
                Type = "������"
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
                Account = "���������� �����",
                Category = "��������",
                Contragent = "�� ������",
                Date = DateTime.Now.ToString(),
                Description = "������� �������",
                Name = "������ ��������� 2.5%",
                Id = 1,
                FamilyMember = "����",
                Sum = "10.00",
                Type = "������"
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
                Account = "���������� �����",
                Category = "��������",
                Contragent = "�� ������",
                Date = DateTime.Now.ToString(),
                Description = "������� �������",
                Name = "������ ��������� 2.5%",
                Id = 4,
                FamilyMember = "����",
                Sum = "10.00",
                Type = "������"
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
                _testOutputHelper.WriteLine("****** �������� ���� ��� ��������� ������: ******");
                _testOutputHelper.WriteLine(exception.Message);
            }
            /* var sBuilder = new StringBuilder();
             JObject jObject = JObject.FromObject(_singleTransactionServicesFixutre.SingleTransactionModel);
             sBuilder.AppendLine("****** ��� ������ ******");
             foreach (var jProp in jObject.Properties())
             {
                 sBuilder.Append(jProp.Name).Append(" ---> ").Append(jProp.Value).AppendLine();
             }
             _testOutputHelper.WriteLine(sBuilder.ToString());*/
        }

        #endregion
    }
}
