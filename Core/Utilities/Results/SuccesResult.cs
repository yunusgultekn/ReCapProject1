using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccesResult:Result
    {
        public SuccesResult():base(true)
        {

        }
        public SuccesResult(string message):base(true,message)
        {

        }
    }
}
