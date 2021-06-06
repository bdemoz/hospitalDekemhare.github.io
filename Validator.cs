using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDC
{
    public static class Validator
    {
        public static bool isPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

        //to check if it is Decimal
        public static bool isDecimal(TextBox textBox, string name)
        {
            decimal num = 0m;
            if(!decimal.TryParse(textBox.Text,out num))
            {
                MessageBox.Show(name + " has to be deciam.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

        //to check if it is date
        public static bool isDate(TextBox textBox, string name)
        {
            DateTime dateType = new DateTime();
            if (!DateTime.TryParse(textBox.Text, out dateType))
            {
                MessageBox.Show(name + " has to be date.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

        //to check if it is time
        public static bool isTime(TextBox textBox, string name)
        {
            TimeSpan dateType = new TimeSpan();
            if (!TimeSpan.TryParse(textBox.Text, out dateType))
            {
                MessageBox.Show(name + " has to be date.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }


        //to check if it is Decimal
        public static bool isInt(TextBox textBox, string name)
        {
            int num = 0;
            if (!Int32.TryParse(textBox.Text, out num))
            {
                MessageBox.Show(name + " has to be Integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

        //to validate email
        public static bool isValidEmail(TextBox textBox, string name)
        {
            string value = textBox.Text;
            if (value.IndexOf("@") == -1 | value.IndexOf(".") == -1)
            {
                MessageBox.Show(name + " is not valid Email. Please enter valid email.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
                return true;
        }

    }
}
