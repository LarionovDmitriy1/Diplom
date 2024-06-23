using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Form1 : Form
    {
        int count = 0;
        private static int count3=0;
        static List<string> log = new List<string>();
        static List<string> list = new List<string>();
        private Form2 newForm;
        private static ClientQ clientQ;
        private static Authorization auth;
        static Database database;
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
                count++;
                newForm.Show();
               
            }
            else
            {
                newForm.Show();
            }

        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            
                auth = new Authorization();
                auth.Show();
               
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
        public static void CheckInfo()
        {
            int count2 = 0;
            for (int rows = 0; rows < database.dataGridView1.Rows.Count; rows++)
            {

                string value = database.dataGridView1.Rows[rows].Cells[0].Value.ToString();
                string value1 = database.dataGridView1.Rows[rows].Cells[1].Value.ToString();
                string value2 = database.dataGridView1.Rows[rows].Cells[2].Value.ToString();
                count3++;
                if (auth.login.Text == value)
                {
                    if (auth.pass.Text == value1)
                    {
                        if (auth.room.Text == value2)
                        {
                            log.Add(value);
                            log.Add(value1);
                            log.Add(value2);
                            count2++;
                            break;
                        }

                    }

                }
            }
            if(count2 != 0)
            {
                clientQ = new ClientQ();
                auth.Visible = false;
                clientQ.Show();
            }
            else
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
        }
        public static void Leave()
        {
            database.dataGridView1.Rows.RemoveAt(count3-1);
            list.RemoveAt(count3 - 1);
            clientQ.Close();
            MessageBox.Show("Вы съехали с номера");
            count3 = 0;
            
        }
    }
}
