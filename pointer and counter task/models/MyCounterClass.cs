using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer_and_counter_task.models
{
    class MyCounterClass
    {
        int _min;
        int _max;
        int _counter;
        
        public int Min { get { return _min; } set { _min = value; } }
        public int Max { get { return _max; } set { _max = value; } }
        public int Counter { get { return _counter; } set { _counter = value; } }

        public MyCounterClass(int min, int max,int counter)
        { 
            _counter = counter;
            _min = min;
            _max = max;
        }
        public void Increment()
        {
            if (_counter < _max)
            {
                _counter++;
            }
            else
            {
                _counter = _max;
            }
        }
        public void Decrement() 
        {
            if (_counter > _min)
            {
                _counter--;
            }
            else
            {
                _counter = _min;
            }
        }
        
    }
}
