using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime BirthDate;

        public DateTime GetBirthDate()
        {
            return this.BirthDate;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            if (!String.IsNullOrEmpty(birthDate.ToString()))
            {
                this.BirthDate = birthDate;
            }
        }
    }
}
