using Newtonsoft.Json.Linq;
using System;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace FM.SHD.Services.Tests
{
    [Trait("Category", "Model Validations")]
    public class SingleTransactionValidationTests : IClassFixture<SingleTransactionServicesFixutre>
    {
        #region Private member vatiables

        private readonly ITestOutputHelper _testOutputHelper;
        private SingleTransactionServicesFixutre _singleTransactionServicesFixutre;

        #endregion

        #region Constructor

        public SingleTransactionValidationTests(SingleTransactionServicesFixutre singleTransactionServicesFixutre, ITestOutputHelper testOutputHelper)
        {
            _singleTransactionServicesFixutre = singleTransactionServicesFixutre;
            _testOutputHelper = testOutputHelper;

            SetValidSampleValues();
        }

        #endregion

        #region Tests

        [Fact]
        public void ShouldNotThrowExcepptionForDefaultTestValues()
        {
            var exception = Record.Exception(() => _singleTransactionServicesFixutre.SingleTransactionServices.ValidateModel(_singleTransactionServicesFixutre.SingleTransactionModel));

            Assert.Null(exception);

            WriteExceptionTestResult(exception);

        }

        #endregion

        #region Helper Methods

        private void SetValidSampleValues()
        {
            _singleTransactionServicesFixutre.SingleTransactionModel.Account = "Банковская карта";
            _singleTransactionServicesFixutre.SingleTransactionModel.Category = "Продукты";
            _singleTransactionServicesFixutre.SingleTransactionModel.Contragent = "АО ТАНДЕР";
            _singleTransactionServicesFixutre.SingleTransactionModel.Date = DateTime.Now;
            _singleTransactionServicesFixutre.SingleTransactionModel.Description = "Вкусное молочко";
            _singleTransactionServicesFixutre.SingleTransactionModel.Name = "Молоко Лужайкино 2.5%";
            _singleTransactionServicesFixutre.SingleTransactionModel.Id = "1";
            _singleTransactionServicesFixutre.SingleTransactionModel.FamilyMember = "Дима";
            _singleTransactionServicesFixutre.SingleTransactionModel.Sum = "10.00";
            _singleTransactionServicesFixutre.SingleTransactionModel.Type = "Расход";
        }

        private void WriteExceptionTestResult(Exception exception)
        {
            if (exception != null)
            {
                _testOutputHelper.WriteLine(exception.Message);
            }
            var sBuilder = new StringBuilder();
            JObject jObject = JObject.FromObject(_singleTransactionServicesFixutre.SingleTransactionModel);
            sBuilder.Append("****** Нет ошибок ******");
            foreach (var jProp in jObject.Properties())
            {
                sBuilder.Append(jProp.Name).Append(" ---> ").Append(jProp.Value).AppendLine();
            }
            _testOutputHelper.WriteLine(sBuilder.ToString());
        }

        #endregion
    }
}
