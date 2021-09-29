using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer1
    {
        public int _Id;
        public string _Name;
        public List<Order> Orders = new List<Order>(); //INITIALIZE LIST IMMEDIATELY WITHOUT CTOR

        public Customer1(int id)
        {
            this._Id = id;
        }
        public Customer1(int id, string name)
            : this(id)
        {
            this._Name = name;

        }
    }
}
