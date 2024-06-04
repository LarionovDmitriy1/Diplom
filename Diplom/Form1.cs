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
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        private Form2 newForm;
        private int count = 0;
        Database database;
        public Form1()
        {
            database = new Database();
            InitializeComponent();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                newForm = new Form2();
                newForm.Show();
                count++;
            }
            else
            {
                newForm.Show();
            }

        }

        private void Authorization_Click(object sender, EventArgs e)
        {

        }
        public void DataBase(string full_name, string number, string num)
        {
            database.dataGridView1.Rows.Add(full_name, number, num);
            database.Show();
        }
        public bool CheckRegister(string full_name)
        {
            if (list.Contains(full_name))
            {
                return false;
            }
            list.Add(full_name);
            return true;
        }
    }
}
