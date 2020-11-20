using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Task1.Exceptions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task1
{
    public class PasswordAction
    {
        private List<SymbolAction> symbolActions;
        private List<SymbolAction> pressedKeys;
        private int A;

        [NotMapped]
        private SortedDictionary<double, int> function;

        public SortedDictionary<double, int> NormalizedFunction()
        {
            if (TimeDuration < (0 + double.Epsilon)){
                throw new BaseException("Password action don't complete");
            }
            if (function.Count == 0)
            {
                buildFunction();
            }
            SortedDictionary<double, int> normalizedFunction = new SortedDictionary<double, int>();
            double duration = TimeDuration;
            foreach (var keyValue in function) {
                normalizedFunction.Add(keyValue.Key / duration, keyValue.Value);
            }
            return normalizedFunction;
        }

        [Key]
        public int Id { get; set; }
        public string ValidPassword { get; set; }

        [NotMapped]
        public double TimeDuration
        {
            get
            {
                TimeSpan duration = this.EndTime - this.StartTime;
                return duration.TotalMilliseconds;
            }
        }
        [Required]
        public DateTime StartTime { get; set; }

        public List<SymbolAction> SymbolActions { get => symbolActions; set => symbolActions = value; }

        [NotMapped]
        public List<SymbolAction> PressedKeys { get => pressedKeys; set => pressedKeys = value; }

        public int OverlaysCount { get; set; }

        [Required]
        public DateTime EndTime { get; set; }


        public PasswordAction()
        {
            this.symbolActions = new List<SymbolAction>();
            this.pressedKeys = new List<SymbolAction>();
            function = new SortedDictionary<double, int>();
            this.OverlaysCount = 0;
            A = 1;

        }
        //public PasswordAction(string validPassword, DateTime startTime)
        //{
        //    if (string.IsNullOrEmpty(validPassword))
        //    {
        //        throw new ArgumentException("message", nameof(validPassword));
        //    }
        //    this.symbolActions = new List<SymbolAction>();
        //    this.pressedKeys = new List<SymbolAction>();
        //    this.ValidPassword = validPassword;
        //    this.StartTime = startTime;
        //    this.EndTime = this.StartTime;
        //    //this.time = 0;
        //    this.OverlaysCount = 0;
        //}



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
            TimeSpan time= dateTime - this.StartTime;
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
        public void SetPasswordFunction(PasswordFunctionStates state,double time)
        {
            if (state == PasswordFunctionStates.Start)
            {
                function[time] = (int)state;
                return;
            }
            if(state==PasswordFunctionStates.KeyDown && function.Last().Value >= 2 * A)
            {
                return;
            }
            if (state == PasswordFunctionStates.KeyUp && function.Last().Value <= 0)
            {
                return;
            }
            function[time] = function.Last().Value + (int)state;
        }

        private void buildFunction()
        {
            SetPasswordFunction(PasswordFunctionStates.Start, 0);
            foreach(var symbolAction in symbolActions)
            {
                SetPasswordFunction(PasswordFunctionStates.KeyDown, symbolAction.KeyDownTime);
                SetPasswordFunction(PasswordFunctionStates.KeyUp, symbolAction.KeyUpTime);

            }
        }
    }

    public enum PasswordFunctionStates
    {
        KeyDown=1,
        KeyUp=-1,
        Start=0
    }
}