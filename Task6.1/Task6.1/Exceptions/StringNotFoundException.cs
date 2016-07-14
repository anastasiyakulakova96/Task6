using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    public class StringNotFoundException : Exception

    {
        string _Message;

        public StringNotFoundException()
        {
            _Message = "you have empty line";
        }

        public override string Message
        {
            get
            {
                return _Message;
            }
        }


    }
}
