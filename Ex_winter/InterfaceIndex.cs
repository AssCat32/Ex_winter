﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_winter
{
    interface InterfaceIndex
    {
        int this[int index]
        {
            get;
            set;
        }
        string Name
        {
            get;
        }
        string ChetSum(int N);
        string ChetSum();
    }
}
