using System;

namespace Properties
{
    public class PropertySetter
    {
        private DateTime _birthday;
            
        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return _birthday;
        }
    }
}
