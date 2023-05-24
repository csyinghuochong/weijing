using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.Reflection;
using System.Runtime;

namespace ET
{

    public class SampleClass
    {
        public double dllAdd(double dbA, double dbB)
        {
            double dbResult = dbA + dbB;
            return dbResult;
        }

        public string Admin()
        {
            return "";
        }
    }
}