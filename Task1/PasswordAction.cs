using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Task1
{
    public class PasswordAction
    {
        private readonly string validPassword;
        private readonly DateTime startTime;
        private DateTime endTime;
        //private int time;
        private int overlaysCount;
        private List<SymbolAction> symbolActions;
        private List<SymbolAction> pressedKeys;

        public PasswordAction(string validPassword, DateTime startTime)
        {
            if (string.IsNullOrEmpty(validPassword))
            {
                throw new ArgumentException("message", nameof(validPassword));
            }
            this.symbolActions = new List<SymbolAction>();
            this.pressedKeys = new List<SymbolAction>();
            this.validPassword = validPassword;
            this.startTime = startTime;
            this.endTime = this.startTime;
            //this.time = 0;
            this.overlaysCount = 0;
        }

        public string ValidPassword => validPassword;


        public double TimeDuration {
            get {
                TimeSpan duration = this.endTime - this.startTime;
                return duration.TotalMilliseconds;
            } }

        public DateTime StartTime => startTime;

        internal List<SymbolAction> SymbolActions { get => symbolActions; set => symbolActions = value; }
        internal List<SymbolAction> PressedKeys { get => pressedKeys; set => pressedKeys = value; }
        public int OverlaysCount { get => overlaysCount; set => overlaysCount = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }

        public int GetPreseedKeyIndex(Keys keyCode,bool isShiftPressed)
        {
            int symbolActionIndex = -1;
            for (int i = 0; i < PressedKeys.Count(); i++)
            {
                if (PressedKeys[i].FeelEqualsByParams(keyCode,isShiftPressed))
                {
                    symbolActionIndex = i;

                }

            }
            return symbolActionIndex;

        }

        public void RemovePressedKeyByIndex(int index)
        {
            PressedKeys.RemoveAt(index);
        }

        public double GetRelativeTime(DateTime dateTime)
        {
            TimeSpan time= dateTime - this.startTime;
            return time.TotalMilliseconds;
        }

        public string[] GetTypedSymbols()
        {
            string[] result = new string[SymbolActions.Count()];
            for (int i = 0; i < symbolActions.Count(); i++)
            {
                result[i] = SymbolActions[i].KeyValue.ToString();
            }
            return result;
        }
    }
}