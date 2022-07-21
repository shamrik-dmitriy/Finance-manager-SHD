using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Services.CommonServices
{
    public class ModelValidator : IModelValidator
    {
        public void ValidateModel<T>(T model)
        {
            ICollection<ValidationResult> validationResults = new List<ValidationResult>();

            ValidationContext validationContext = new ValidationContext(model);

            var stringBuilder = new StringBuilder();

            if (!Validator.TryValidateObject(model, validationContext, validationResults, true))
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    stringBuilder.Append(validationResult.ErrorMessage)
                        .AppendLine();
                }
            }

            if (validationResults.Count > 0)
            {
                throw new ArgumentException(stringBuilder.ToString());
            }
        }
    }
}
