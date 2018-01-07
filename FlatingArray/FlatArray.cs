using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatingArray
{
    public class FlatArray
    {
        public FlatArray(object input)
        {
            _FlatArray = new LinkedList<int>();
            _input = input;
        }

        object _input = null;
        LinkedList<int> _FlatArray = null;

        public int[] makeFlating(){
            Process(_input);
            return _FlatArray.ToArray();
        }
        private void Process(object input)
        {
            if (validate(input))
            {
                if (input.GetType().IsArray)
                {
                    foreach (var item in (Array)input)
                    {
                        Process(item);
                    }
                }
                else
                {
                    _FlatArray.AddLast((int)input);
                }
            }
            else
            {
                throw new Exception("Not an expected object type");
            }
        }

        private bool validate(object input){
            var k = input.GetType();
            if (input.GetType().IsArray || input.GetType() == typeof(int))
            {
                return true;
            }
            else
                return false;
        }
    }
}
