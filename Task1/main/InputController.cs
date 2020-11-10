using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Exceptions;

namespace Task1
{
    class InputController
    {
        protected PasswordActionBuilder PasswordActionBuilder { get; set; }
        public PasswordAction PasswordAction { get; private set; }
        //public List<PasswordAction> PasswordActions { get => passwordActions; set => passwordActions = value; }

        public InputController()
        {
            PasswordActionBuilder = new PasswordActionBuilder();
            //passwordActions = new List<PasswordAction>();
        }

        private void UnpressPressedKeys(DateTime endTime)
        {
            for (int i = 0; i < PasswordAction.PressedKeys.Count(); i++)
            {
                KeyUp(new KeyEventArgs(PasswordAction.PressedKeys[i].KeyValue), endTime);
            }

        }
        public void NextPasswordAction(string password,DateTime startTime)
        {
            PasswordAction = PasswordActionBuilder.ConstructPasswordAction(password, startTime);
        }

        public PasswordAction EndPasswordAction(DateTime endTime,string passwordValue)
        {
            if (passwordValue != PasswordAction.ValidPassword)
            {
                throw new InvalidPasswordException("Invalid password exception");
            }
            UnpressPressedKeys(endTime);
            PasswordAction.EndTime = endTime;
            PasswordAction oldPasswordAction = this.PasswordAction;
            this.PasswordAction = null;
            return oldPasswordAction;
        }
        public void KeyDown(KeyEventArgs keyEventArgs, DateTime worldTime)
        {
            if (keyEventArgs.KeyCode == Keys.ShiftKey || keyEventArgs.KeyCode==Keys.Control)
            {
                return;
            }
            SymbolAction symbolAction = new SymbolAction(keyEventArgs.KeyCode,keyEventArgs.Shift, PasswordAction.GetRelativeTime(worldTime));
            PasswordAction.SymbolActions.Add(symbolAction);
            PasswordAction.PressedKeys.Add(symbolAction);
            if (PasswordAction.PressedKeys.Count > 1)
            {
                PasswordAction.OverlaysCount++;
            }

        }

        public void KeyUp(KeyEventArgs keyEventArgs, DateTime worldTime)
        {

            int symbolActionIndex= PasswordAction.GetPreseedKeyIndex(keyEventArgs.KeyCode,keyEventArgs.Shift);
            if (symbolActionIndex!=-1)
            {
                SymbolAction symbolAction = PasswordAction.PressedKeys[symbolActionIndex];
                symbolAction.KeyUpTime = PasswordAction.GetRelativeTime(worldTime);
                for (int i= symbolActionIndex+1; i < PasswordAction.PressedKeys.Count(); i++)
                {
                    PasswordAction.PressedKeys[i].OverlayEndingTime = PasswordAction.GetRelativeTime(worldTime);
                    //можно сохранять значения клавиш, на которые была наложена текущая обрабатываемая (в цикле) клавиша
                }
                if (symbolActionIndex != 0)
                {
                    symbolAction.OverlayEndingTime = symbolAction.KeyUpTime;
                }
                PasswordAction.RemovePressedKeyByIndex(symbolActionIndex);
            }
            else
            {

                //throw new Exception("Out of index in PressedKeys error");
            }

        }



    }
}
