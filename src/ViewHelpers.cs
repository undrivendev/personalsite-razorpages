using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ldv.PersonalSite
{
    public static class ViewHelpers
    {
        public static int GetAge(DateTime birthdate)
        {
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - birthdate.Year;
            // Go back to the year the person was born in case of a leap year
            if (birthdate > today.AddYears(-age)) age--;
            return age;
        }
    }
}
