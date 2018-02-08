using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{    
    public class Stack
    {
        //private List<object> _stackList = new List<object>();
        //warto ustawić lista jako Readonly, żeby nigdzie przez przypadek jej po raz kolejny nie zainicjalizować
        private List<object> _stackList = new List<object>(); 
        


        /*
        The Push() method stores the given object on top of the stack.
        We use the “object” type here so we can store any objects inside the stack.
        Remember the “object” class is the base of all classes in the.NET Framework.So any types can be automatically upcast to the object.
        Make sure to take into account the scenario that null is passed to this object. We should not store null references in the stack. 
        So if null is passed to this method, you should throw an InvalidOperationException. */
        public int Push(object obj)
        {
            if (obj != null)
                _stackList.Add(obj);
            else
                throw new InvalidOperationException("Objext cannot be null.");

            return _stackList.IndexOf(obj);
        }


        /*
        The Pop() method removes the object on top of the stack and returns it. 
        Make sure to take into account the scenario that we call the Pop() method on an empty stack. 
        In this case, this method should throw an InvalidOperationException.
        Remember, your classes should always be in a valid state and used properly. When they are misused, they should throw exceptions. */
        public object Pop()
        {
            if (_stackList.Count > 0)
            {
                var popped = _stackList[_stackList.Count - 1];
                _stackList.Remove(popped);

                return popped;
            }
            else
                throw new InvalidOperationException("List is empty!!!!!!!");
        }

        /*The Clear() method removes all objects from the stack*/
        public void Clear()
        {
            /*foreach (var obj in _stackList)
                _stackList.Remove(obj);*/

            //tak jak wyżej albo po prostu
            _stackList.Clear();
        }

    }
}
