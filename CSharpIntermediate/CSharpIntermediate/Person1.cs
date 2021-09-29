using System;

namespace CSharpIntermediate
{
    public class Person1
    {
        private DateTime _birthday;
        private int _age;
        public DateTime Birthday { get { return _birthday; } set { value = _birthday; } }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;

                return years;

            }

        }
    }
}
