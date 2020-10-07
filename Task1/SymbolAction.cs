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
        private long keyDownTime;
        private long keyUpTime;
        private long overlayEndingTime;
        public SymbolAction(Keys keyValue, long keyDownTime)
        {
            this.keyValue = keyValue;
            this.keyDownTime = keyDownTime;
            this.keyUpTime = 0;
            this.overlayEndingTime = keyDownTime;
        }

        public Keys KeyValue { get => keyValue; set => keyValue = value; }
        public long KeyDownTime { get => keyDownTime; set => keyDownTime = value; }
        public long KeyUpTime { get => keyUpTime; set => keyUpTime = value; }
        public long KeyPressDuration
        {
            get
            {
                if (keyUpTime > 0)
                {
                    return keyUpTime - keyDownTime;
                }
                else { return 0; }
            }
        }
        public long OverlayEndingTime { get => overlayEndingTime; set { if (value > overlayEndingTime) { overlayEndingTime = value; }; } }
        public long OverlayDuration { get => overlayEndingTime - keyDownTime; }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            SymbolAction symbolAction = (SymbolAction)obj;
            return this.keyValue.Equals(symbolAction.keyValue);
        }
    }
}
