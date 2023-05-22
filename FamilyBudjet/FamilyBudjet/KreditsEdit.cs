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
    public partial class KreditsEdit : Form
    {
        DataGridViewRow ID;
        public KreditsEdit(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void KreditsEdit_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                if (int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) > 0)
                {
                    textBox1.Text = (string)ID.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                    textBox2.Text = (string)ID.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                    textBox3.Text = (string)ID.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                    textBox4.Text = (string)ID.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    textBox5.Text = (string)ID.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (textBox1.Text.Length == 0) { MessageBox.Show("Укажите наименование!"); textBox1.Focus(); return; }
            if (textBox2.Text.Length == 0) { MessageBox.Show("Укажите объект!"); textBox2.Focus(); return; }
            if (textBox3.Text.Length == 0) { MessageBox.Show("Укажите сумму!"); textBox3.Focus(); return; }
            if (textBox4.Text.Length == 0) { MessageBox.Show("Укажите кол-во месяцев!"); textBox4.Focus(); return; }
            if (textBox5.Text.Length == 0) { MessageBox.Show("Укажите процент!"); textBox5.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_kredits(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text),int.Parse(textBox4.Text),float.Parse(textBox5.Text));
            }
            else
            {
                procedure.spUpd_kredits(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text), int.Parse(textBox4.Text), float.Parse(textBox5.Text), int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
            }

            Close();

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
