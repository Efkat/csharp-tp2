using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Cons
{
    class Windmill : IOperation
    {
        public bool isOn { get; set; }

        public string GetState()
        {
            if (isOn)
            {
                return "Allumé !";
            }
            else
            {
                return "Eteinte !";
            }
        }

        public void TurnOff()
        {
            if (isOn)
            {
                isOn = false;
            }
            else
            {
                return;
            }
        }

        public void TurnOn()
        {
            if (!isOn)
            {
                isOn = true;
            }
            else
            {
                return;
            }
        }
    }
}
