using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class StackClass
    {
        private List<object> _stackList = new List<object>();
        public List<object> StackList { get => _stackList; set {_stackList = value;} }
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("list is null");
                
            }   
                StackList.Insert(0, obj);          
        }
        public object Pop()
        {
            if (StackList.Count== 0 )
            {
                throw  new InvalidOperationException("stacklist is empty!"); 
            }

            var first = StackList[0];

            StackList.RemoveAt(0);

            return first;

        }
        public void Clear()
        {
            if (StackList.Count == 0)
            {
                throw new InvalidOperationException("stack is empty!");
                
            }

            StackList.Clear();
        }
    }
}
