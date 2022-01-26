using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlineshoppingstore.PersonalisedValidation
{
    public class SimbolFillimi:ValidationAttribute
    {
        private readonly string _str;
        public SimbolFillimi(string s)
        {
            _str = s;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value != null)
            {
                var str = value.ToString();
                if (!str.StartsWith(_str))
                {
                    return new ValidationResult("Titulli should start with I-");
                }
            }

            return ValidationResult.Success;
        }
    }
}