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

        [Fact]
        public void ShouldThrowExcepptionForRequiredFieldsTestValues()
        {
            _singleTransactionServicesFixutre.SingleTransactionModel.Account = string.Empty;
            _singleTransactionServicesFixutre.SingleTransactionModel.Date = null;
            var exception = Assert.Throws<ArgumentException>(() => _singleTransactionServicesFixutre.SingleTransactionServices.ValidateModel(_singleTransactionServicesFixutre.SingleTransactionModel));

            WriteExceptionTestResult(exception);
        }


        [Fact]
        public void ShouldThrowExcepptionForMaxLengthFieldsTestValues()
        {
            _singleTransactionServicesFixutre.SingleTransactionModel.Name = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec.";
            _singleTransactionServicesFixutre.SingleTransactionModel.Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a, tellus. Phasellus viverra nulla ut metus varius laoreet. Quisque rutrum. Aenean imperdiet. Etiam ultricies nisi vel augue. Curabitur ullamcorper ultricies nisi. Nam eget dui. Etiam rhoncus. Maecenas tempus, tellus eget condimentum rhoncus, sem quam semper libero, sit amet adipiscing sem neque sed ipsum. Nam quam nunc, blandit vel, luctus pulvinar, hendrerit id, lorem. Maecenas nec odio et ante tincidunt tempus. Donec vitae sapien ut libero venenatis faucibus. Nullam quis ante. Etiam sit amet orci eget eros faucibus tincidunt. Duis leo. Sed fringilla mauris sit amet nibh. Donec sodales sagittis magna. Sed consequat, leo eget bibendum sodales, augue velit cursus nunc, quis gravida magna mi a libero. Fusce vulputate eleifend sapien. Vestibulum purus quam, scelerisque ut, mollis sed, nonummy id, metus. Nullam accumsan lorem in dui. Cras ultricies mi eu turpis hendrerit fringilla. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; In ac dui quis mi consectetuer lacinia. Nam pretium turpis et arcu. Duis arcu tortor, suscipit eget, imperdiet nec, imperdiet iaculis, ipsum. Sed aliquam ultrices mauris. Integer ante arcu, accumsan a, consectetuer eget, posuere ut, mauris. Praesent adipiscing. Phasellus ullamcorper ipsum rutrum nunc. Nunc nonummy metus. Vestibulum volutpat pretium libero. Cras id dui. Aenean ut";
            var exception = Assert.Throws<ArgumentException>(() => _singleTransactionServicesFixutre.SingleTransactionServices.ValidateModel(_singleTransactionServicesFixutre.SingleTransactionModel));

            WriteExceptionTestResult(exception);
        }

        #endregion

        #region Helper Methods

        private void SetValidSampleValues()
        {
            _singleTransactionServicesFixutre.SingleTransactionModel.Account = "Банковская карта";
            _singleTransactionServicesFixutre.SingleTransactionModel.Category = "Продукты";
            _singleTransactionServicesFixutre.SingleTransactionModel.Contragent = "АО ТАНДЕР";
            _singleTransactionServicesFixutre.SingleTransactionModel.Date = DateTime.Now.ToString();
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
                _testOutputHelper.WriteLine("****** Возникла одна или несколько ошибок: ******");
                _testOutputHelper.WriteLine(exception.Message);
            }
            var sBuilder = new StringBuilder();
            JObject jObject = JObject.FromObject(_singleTransactionServicesFixutre.SingleTransactionModel);
            sBuilder.AppendLine("****** Нет ошибок ******");
            foreach (var jProp in jObject.Properties())
            {
                sBuilder.Append(jProp.Name).Append(" ---> ").Append(jProp.Value).AppendLine();
            }
            _testOutputHelper.WriteLine(sBuilder.ToString());
        }

        #endregion
    }
}
