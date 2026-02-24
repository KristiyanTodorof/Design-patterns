using Bridge.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Controllers
{
    public class Remote
    {
        private ICoffeeCommand _command;
        public void SetCommand(ICoffeeCommand command)
        {
            this._command = command;
        }
        public string PressButton()
        {
            return $"Remote control button pressed: {this._command.Execute()}";
        }
    }
}
