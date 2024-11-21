using System;
using System.ComponentModel.DataAnnotations;

namespace Lecture21.CustomAttributes
{
    public class EndDateGreaterThanStartDateAttribute : ValidationAttribute
    {
        private readonly string _startDatePropertyName;
        public EndDateGreaterThanStartDateAttribute(string startDatePropertyName)
        {
            _startDatePropertyName = startDatePropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime? endDate = (DateTime)value;
            var startDateProperty = validationContext.ObjectType.GetProperty(_startDatePropertyName);

            if (startDateProperty == null)
            {
                return new ValidationResult($"Unknown property: {_startDatePropertyName}");
            }

            DateTime? startDate = (DateTime?)startDateProperty.GetValue(validationContext.ObjectInstance);

            if (startDate != null && endDate != null && startDate > endDate)
            {
                return new ValidationResult($"The {validationContext.DisplayName} must be greater to start date");
            }

            return ValidationResult.Success;
        }
    }
}
