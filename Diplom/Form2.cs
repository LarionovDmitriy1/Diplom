using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        List<string> list = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = full_name.Text;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (form1.CheckRegister(full_name.Text))
            {
                string num = RandomNumber();
                if (num == "0")
                {
                    MessageBox.Show("Места в гостиннице закончились");
                    this.Visible = false;
                    full_name.Clear();
                    number.Clear();
                    return;
                }
                form1.DataBase(full_name.Text, number.Text, num);
                MessageBox.Show($"Ваш номер в гостиннице - {num}");
                this.Visible = false;
                full_name.Clear();
                number.Clear();
            }
            else
            {
                MessageBox.Show("Такой человек уже зарегистрирован в гостиннице");
                this.Visible = false;
                full_name.Clear();
                number.Clear();
                return;
            }
            
        }
        private string RandomNumber()
        {
            string num = "asd";
            Random randomNumber = new Random();
            int num1 = randomNumber.Next(1,101);
            num = num1.ToString();
            if (!list.Contains(num))
            {
                list.Add(num);
                return num;
            }
            else if(list.Count == 100)
            {
                return "0";
            }
            else
            {
                RandomNumber();
            }
            return num;
        }
    }
}
