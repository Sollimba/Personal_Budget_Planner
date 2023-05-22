using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudjet
{
    public partial class EditUser : Form
    {
        DataGridViewRow ID;
        public EditUser(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                if (int.Parse(ID.Cells["iduserDataGridViewTextBoxColumn"].Value.ToString()) > 0)
                {
                    textBox1.Text = (string)ID.Cells["nameuserDataGridViewTextBoxColumn"].Value.ToString();
                    textBox2.Text = (string)ID.Cells["loginDataGridViewTextBoxColumn"].Value.ToString();
                    textBox3.Text = (string)ID.Cells["passwordDataGridViewTextBoxColumn"].Value.ToString();
                    comboBox1.Text = (string)ID.Cells["roleDataGridViewTextBoxColumn"].Value.ToString();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (comboBox1.Text.Length == 0) { MessageBox.Show("Укажите роль!"); comboBox1.Focus(); return; }
            if (textBox1.Text.Length == 0) { MessageBox.Show("Укажите имя!"); textBox1.Focus(); return; }
            if (textBox2.Text.Length == 0) { MessageBox.Show("Укажите логин!"); textBox2.Focus(); return; }
            if (textBox3.Text.Length == 0) { MessageBox.Show("Укажите пароль!"); textBox3.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_User(textBox1.Text, textBox2.Text, Shifr.Encrypt(textBox3.Text), comboBox1.Text);
            }
            else
            {
                procedure.spUpd_User(textBox1.Text, textBox2.Text, Shifr.Encrypt(textBox3.Text), comboBox1.Text, int.Parse(ID.Cells["iduserDataGridViewTextBoxColumn"].Value.ToString()));
            }

            Close();
        }
    }
}
