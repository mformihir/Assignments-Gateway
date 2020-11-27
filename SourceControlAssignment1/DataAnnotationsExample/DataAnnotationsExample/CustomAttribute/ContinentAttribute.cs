using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsExample.CustomAttribute
{
    public class ContinentAttribute : ValidationAttribute
    {
        private string _continent;
        public ContinentAttribute(string continent)
        {
            _continent = continent;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (value is string)
                {
                    string continent = (string)value;
                    if (!(continent.Equals(_continent)))
                    {
                        return new ValidationResult("This application only supports the " + _continent + " continent as of now. Please try again later.");
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}