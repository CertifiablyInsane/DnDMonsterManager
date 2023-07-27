using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDMonsterManager
{
    internal class Output
    {
        private TextBox textBox;
    
        public Output(TextBox tb)
        {
            textBox = tb;
        }
        public bool Print(string message)
        {
            if(textBox != null)
            {
                textBox.Text += "> " + message + Environment.NewLine;
                return true;
            }
            return false;
        }
    }
}
