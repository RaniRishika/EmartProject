using System;
using System.ComponentModel.DataAnnotations;

namespace EmartApplication.Models
{
   class ValidateDomainAttribute :ValidationAttribute
    {
        private String allowdomain;
        public ValidateDomainAttribute(string allowdomain)
        {
            this.allowdomain = allowdomain;

        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == allowdomain)
                return true;
            else
                return false;
        }

    }
}