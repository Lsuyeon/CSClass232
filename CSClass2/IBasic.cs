﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass2
{
    internal interface IBasic
    {
        //인터페이스
        int TestInstanceMethod();
        int TestProperty { get; set; }
    }
}
