using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.ViewModels.Helpers
{
    public class ValidationHelper
    {
        public static ValidationResult Validate<T, K>(K entity)
            where T : IValidator<K>, new()
            where K : class
        {
            IValidator<K> __Validator = new T();
            return __Validator.Validate(entity);
        }

        public static string GetError(ValidationResult result)
        {
            var __ValidationErrors = new StringBuilder();
            foreach (var validationFailure in result.Errors)
            {
                __ValidationErrors.Append(validationFailure.ErrorMessage);
                __ValidationErrors.Append(Environment.NewLine);
            }
            return __ValidationErrors.ToString();
        }
    }
}
