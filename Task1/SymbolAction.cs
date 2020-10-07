using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public class SymbolAction
    {
        private Keys keyValue;
        private double keyDownTime;
        private double keyUpTime;
        private double overlayEndingTime;
        public SymbolAction(Keys keyValue, double keyDownTime)
        {
            this.keyValue = keyValue;
            this.keyDownTime = keyDownTime;
            this.keyUpTime = 0;
            this.overlayEndingTime = keyDownTime;
        }

        public Keys KeyValue { get => keyValue; set => keyValue = value; }
        public double KeyDownTime { get => keyDownTime; set => keyDownTime = value; }
        public double KeyUpTime { get => keyUpTime; set => keyUpTime = value; }
        public double KeyPressDuration
        {
            get
            {
                if (Math.Abs(keyUpTime )> Double.Epsilon)
                {
                    return keyUpTime - keyDownTime;
                }
                else { return 0; }
            }
        }
        public double OverlayEndingTime { get => overlayEndingTime; set { if ( value > overlayEndingTime) { overlayEndingTime = value; }; } }
        public double OverlayDuration { get => overlayEndingTime - keyDownTime; }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            SymbolAction symbolAction = (SymbolAction)obj;
            return this.keyValue.Equals(symbolAction.keyValue);
        }

        //private static void DoubleCompare(double val1,double val2)
        //{
        //    if(Math.Abs(val1-val2)>Double.Epsilon)
        //}
    }
}
