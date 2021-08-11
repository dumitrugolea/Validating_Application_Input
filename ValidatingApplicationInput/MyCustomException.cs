using System;
using System.Collections.Generic;
using System.Text;

namespace ValidatingApplicationInput
{
    class MyCustomException:Exception
    {
        public MyCustomException(string message) : base(message)
        {
        }
    }
}
