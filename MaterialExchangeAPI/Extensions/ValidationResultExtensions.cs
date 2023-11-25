using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MaterialExchangeAPI.Extensions
{
    public static class ValidationResultExtensions
    {
        public static ModelStateDictionary ToModelStateDictionary(this ValidationResult result) 
        {
            ModelStateDictionary dict = new ModelStateDictionary();

            foreach (ValidationFailure failure in result.Errors)
            {
                dict.AddModelError(
                    failure.PropertyName,
                    failure.ErrorMessage
                );
            }

            return dict;
        }
    }
}
