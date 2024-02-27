using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pointer_and_counter_task.models
{
    class MyPointerClass
    {
        private int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public void DisplayValue()
        {
            Console.WriteLine($"Value: {Value}");
        }
    }
}
