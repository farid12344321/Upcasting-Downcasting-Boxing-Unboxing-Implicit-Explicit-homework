using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interface
{
    public interface ICalculation
    {
        string Calculate(int num1, int num2, string operation);
    }
}
