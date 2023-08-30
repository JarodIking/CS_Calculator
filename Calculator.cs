using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Controls;

namespace CS_Calculator
{
    public class Calculator
    {
        private string Input { get; set; }
        private TextBox _textBox;
        private DataTable _table;

        public Calculator(TextBox textBox, DataTable table, string input = "")
        {
            _textBox = textBox;
            _table = table;
            this.Input = input;
        }

        private void UpdateTextBox()
        {
            _textBox.Text = this.Input;
        }

        public void FillInput(string str)
        {
            this.Input += str;
            this.UpdateTextBox();
        }

        public void calculate()
        {
            this.Input = _table.Compute(this.Input, "").ToString();
            this.UpdateTextBox();
        }
    }
}
