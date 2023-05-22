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
    public partial class categoryEdit : Form
    {
        DataGridViewRow ID;
        public categoryEdit(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void categoryEdit_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                if (int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) > 0)
                {
                    textBox1.Text = (string)ID.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                }
                else
                {
                    textBox1.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (textBox1.Text.Length == 0) { MessageBox.Show("Укажите категорию!"); textBox1.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_category(textBox1.Text);
            }
            else
            {
                procedure.spUpd_category(textBox1.Text, int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
            }

            Close();
        }
    }
}
