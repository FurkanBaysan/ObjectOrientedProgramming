using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public DateTime Birthdate
        {
            get; private set;
        }

        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - this.Birthdate;
                int years = timeSpan.Days / 365;

                return years;
            }
        }

    }
}
