using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    class InputController
    {
        private List<PasswordAction> passwordActions;

        public PasswordAction PasswordAction { get => passwordActions.Last();}
        public List<PasswordAction> PasswordActions { get => passwordActions; set => passwordActions = value; }

        public InputController()
        {
            passwordActions = new List<PasswordAction>();
        }

        //public List<PasswordAction> InputAction { get => passwordActions; set => passwordActions = value; }

        public void NextPasswordAction(string password,DateTime startTime)
        {
            passwordActions.Add(new PasswordAction(password, startTime));
        }

        public void EndPasswordAction(DateTime endTime)
        {
            for (int i = 0; i < PasswordAction.PressedKeys.Count(); i++)
            {
                KeyUp(new KeyEventArgs(PasswordAction.PressedKeys[i].KeyValue), endTime);
            }
            PasswordAction.EndTime = endTime.ToFileTime();
        }
        public void KeyDown(KeyEventArgs keyEventArgs, DateTime worldTime)
        {
            //if(ke)
            SymbolAction symbolAction = new SymbolAction(keyEventArgs.KeyCode, PasswordAction.GetRelativeTime(worldTime));
            PasswordAction.SymbolActions.Add(symbolAction);
            PasswordAction.PressedKeys.Add(symbolAction);
            if (PasswordAction.PressedKeys.Count > 1)
            {
                PasswordAction.OverlaysCount++;
            }

        }

        public void KeyUp(KeyEventArgs keyEventArgs, DateTime worldTime)
        {

            int symbolActionIndex= PasswordAction.GetPreseedKeyIndex(keyEventArgs.KeyCode);
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
