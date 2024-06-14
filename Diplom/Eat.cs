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
    public partial class Eat : Form
    {
        ClientQ client;
        int countEat = 0;
        int countWater = 0;
        int countAlcho = 0;
        public Eat()
        {
            InitializeComponent();
        }

        private void eatButton_Click(object sender, EventArgs e)
        {
            if (countEat != 10)
            {
                countEat++;
                eatLabel.Text = countEat.ToString();
            }
            else
            {
                MessageBox.Show("Товар закончился");
            }
        }

        private void waterButton_Click(object sender, EventArgs e)
        {
            if (countWater != 10)
            {
                countWater++;
                waterLabel.Text = countWater.ToString();
            }
            else
            {
                MessageBox.Show("Товар закончился");
            }
        }

        private void Alcho_Click(object sender, EventArgs e)
        {
            if (countAlcho != 10)
            {
                countAlcho++;
                alchoLabel.Text = countAlcho.ToString();
            }
            else
            {
                MessageBox.Show("Товар закончился");
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы заказали в номер - {countEat} порции еды, {countWater} напитка и {countAlcho} коктеля");
            this.Close();
            client = new ClientQ();
            client.Visible = true;
        }
    }
}
