using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>(); //Inııtalizes the dictionary or a list immediately.
        public string this[string key]
        {
            get {return _dictionary[key]; }
            set {_dictionary[key] = value; }
        }

    }


}

