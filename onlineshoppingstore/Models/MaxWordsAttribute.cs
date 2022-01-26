using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace onlineshoppingstore.Models
{
    public class MaxWordsAttribute:ValidationAttribute
    {
        
    public MaxWordsAttribute(int maxWords)
    {
    _maxWords = maxWords;
     }
        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
        if (value != null)
            {
        var valueAsString = value.ToString();
        if (valueAsString.Split(' ').Length > _maxWords)
            {
        return new ValidationResult("Too many words!"); }
            }
        return ValidationResult.Success;
         }
        private readonly int _maxWords; }
    }
