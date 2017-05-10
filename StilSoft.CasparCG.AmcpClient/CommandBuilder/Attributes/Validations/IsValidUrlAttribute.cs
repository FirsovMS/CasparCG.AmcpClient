﻿//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////


using System;
using System.ComponentModel.DataAnnotations;

namespace StilSoft.CasparCG.AmcpClient.CommandBuilder.Attributes.Validations
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class IsValidUrlAttribute : ValidationAttribute
    {
        private readonly bool _isNullOrEmptyValid;


        public IsValidUrlAttribute(bool isNullOrEmptyValid = true)
        {
            _isNullOrEmptyValid = isNullOrEmptyValid;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var errorMessage = $"Property \'{validationContext.MemberName}\' value is not valid url.";

            if (string.IsNullOrEmpty(value.ToString()))
                return _isNullOrEmptyValid ? ValidationResult.Success : new ValidationResult(errorMessage);

            if (!(value is string))
                throw new InvalidOperationException($"\'{nameof(IsValidPathAttribute)}\' attribute can be used only on 'string' value type properties.");

            Uri url;

            return Uri.TryCreate(value.ToString(), UriKind.Absolute, out url) ? ValidationResult.Success : new ValidationResult(errorMessage);
        }
    }
}