namespace TP2.Cons
{
    public class Lamp : IOperation
    {
        private byte conso { get; set; }
        private bool isOn { get; set; }
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
        void TurnOff()
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
        string GetState()
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