using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
   public class EmptyFileException : Exception
    {
       string _Message;

        public EmptyFileException()
        {
            _Message = "Exception:file is empty";
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
