using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class ClientQ : Form
    {
        Eat eater = new Eat();
        
        public ClientQ()
        {
            InitializeComponent();
        }

        private void leave_Click(object sender, EventArgs e)
        {
            Form1.Leave();
        }

        private void eat_Click(object sender, EventArgs e)
        {
            eater.Show();
            this.Visible = false;
        }

        private void cleaning_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы заказали уборку номера, она пройдёт {DateTime.Now.ToLongDateString()} в {DateTime.Now.AddMinutes(10).ToShortTimeString()}");
        }
    }
}
