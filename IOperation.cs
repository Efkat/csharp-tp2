using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Cons
{
    public interface IOperation
    {
        void TurnOn();

        void TurnOff();

        string GetState();


    }
}
