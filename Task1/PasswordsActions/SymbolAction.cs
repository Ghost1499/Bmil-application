using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Task1
{
    public class SymbolAction
    {
        private double overlayEndingTime;
        public SymbolAction()
        {
            Init((Keys)0, false, 0);
        }
        public SymbolAction(Keys keyValue,bool isShiftPressed, double keyDownTime)
        {
            Init(keyValue, isShiftPressed, keyDownTime);
        }
        private void Init(Keys keyValue, bool isShiftPressed, double keyDownTime)
        {
            this.KeyValue = keyValue;
            this.IsShiftPressed = isShiftPressed;
            this.KeyDownTime = keyDownTime;
            this.KeyUpTime = 0;
            this.overlayEndingTime = keyDownTime;
        }

        [Key]
        public int Id { get; set; }

        public int PasswordActionId { get; set; }
        [Required]
        public Keys KeyValue { get; set; }
        [Required]
        public double KeyDownTime { get; set; }
        [Required]
        public double KeyUpTime { get; set; }
        [NotMapped]
        public double KeyPressDuration
        {
            get
            {
                if (Math.Abs(KeyUpTime )> Double.Epsilon)
                {
                    return KeyUpTime - KeyDownTime;
                }
                else { return 0; }
            }
        }
        public double OverlayEndingTime { get => overlayEndingTime; set { if (value > overlayEndingTime) overlayEndingTime = value; } }
        [NotMapped]
        public string SymbolValue { get { return KeyValue.ToString(); } }
        [NotMapped]
        public double OverlayDuration { get => overlayEndingTime - KeyDownTime; }
        public bool IsShiftPressed { get; set; }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            SymbolAction symbolAction = (SymbolAction)obj;
            return this.KeyValue.Equals(symbolAction.KeyValue)&&(this.IsShiftPressed==symbolAction.IsShiftPressed);
        }
        public bool FeelEqualsByParams(Keys keyCode,bool isShiftPressed)
        {
            return (KeyValue == keyCode); /*&& (this.isShiftPressed == isShiftPressed);*/
        }
        //private static void DoubleCompare(double val1,double val2)
        //{
        //    if(Math.Abs(val1-val2)>Double.Epsilon)
        //}
    }
}
