namespace TP2.Cons
{
    public class Lamp : IOperation
    {
        private byte conso { get; set; }
        public bool isOn { get; set; }

        public void TurnOn()
        {
            if (!isOn)
            {
                isOn = true;
                conso = 80;
            }
            else
            {
                return;
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
    }
}