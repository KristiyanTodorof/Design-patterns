using Bridge.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Controllers
{
    public class Phone
    {
        private ICoffeeCommand _command;

        public void SetCommand(ICoffeeCommand command)
        {
            this._command = command;
        }
        public string TapButton()
        {
            return $"Phone app button tapped: {this._command.Execute()}";
        }
    }
}
