using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Exceptions;

namespace Task1
{
    public enum InputMode
    {
        Input,
        Identify,
        Verify
    }
    class InputController
    {
        //protected PasswordActionBuilder PasswordActionBuilder { get; set; }
        private InputMode inputMode;
        public PasswordAction PasswordAction { get; private set; }
        public Settings Settings { get; }
        public InputMode InputMode { get { return inputMode; } set { inputMode = value;  Settings.InputMode = value; } }

        public InputController(Settings settings)
        {
            //PasswordActionBuilder = new PasswordActionBuilder();
            Settings = settings;
        }

        private void unpressPressedKeys(DateTime endTime)
        {
            for (int i = 0; i < PasswordAction.PressedKeys.Count(); i++)
            {
                KeyUp(new KeyEventArgs(PasswordAction.PressedKeys[i].KeyValue), endTime);
            }

        }
        public void NextPasswordAction(string password,DateTime startTime)
        {
            if (InputMode == InputMode.Identify || InputMode== InputMode.Verify)
            {
                password = null;
            }
            PasswordAction =new PasswordAction( startTime,Settings.UserId,password);
            PasswordAction.SetPasswordFunction(PasswordFunctionStates.Start, 0);
        }

        public PasswordAction EndPasswordAction(DateTime endTime,string passwordValue)
        {
            if (InputMode == InputMode.Identify || InputMode == InputMode.Verify)
            {
                PasswordAction.ValidPassword = passwordValue;
            }
            if (passwordValue != PasswordAction.ValidPassword)
            {
                throw new InvalidPasswordException("Invalid password exception");
            }
            unpressPressedKeys(endTime);
            PasswordAction.EndTime = endTime;
            PasswordAction.TypedSymbols = PasswordAction.GetTypedSymbols();
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
            double relativeTime = PasswordAction.GetRelativeTime(worldTime);
            SymbolAction symbolAction = new SymbolAction(keyEventArgs.KeyCode,keyEventArgs.Shift, relativeTime);
            PasswordAction.SymbolActions.Add(symbolAction);
            PasswordAction.PressedKeys.Add(symbolAction);
            PasswordAction.SetPasswordFunction(PasswordFunctionStates.KeyDown, relativeTime);
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
                double relativeTime= PasswordAction.GetRelativeTime(worldTime);
                symbolAction.KeyUpTime = relativeTime;
                PasswordAction.SetPasswordFunction(PasswordFunctionStates.KeyUp, relativeTime);

                for (int i= symbolActionIndex+1; i < PasswordAction.PressedKeys.Count(); i++)
                {
                    PasswordAction.PressedKeys[i].OverlayEndingTime = relativeTime;
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
