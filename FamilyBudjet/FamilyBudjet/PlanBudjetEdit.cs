using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudjet
{
    public partial class PlanBudjetEdit : Form
    {
        DataGridViewRow ID;
        public PlanBudjetEdit(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanBudjetEdit_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ada = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT * FROM articles";
            ada.SelectCommand = cmd;
            ada.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "title";
                comboBox1.ValueMember = "id_article";
                comboBox1.SelectedIndex = 0;
            }


            if (ID != null)
            {
                if (int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) > 0)
                {
                    comboBox1.SelectedValue = int.Parse(ID.Cells["dataGridViewTextBoxColumn2"].Value.ToString());
                    comboBox2.SelectedIndex = int.Parse(ID.Cells["dataGridViewTextBoxColumn4"].Value.ToString())-1;
                    textBox2.Text = (string)ID.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                    textBox1.Text = (string)ID.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Text = DateTime.Now.Year.ToString();
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = int.Parse(DateTime.Now.Month.ToString()) - 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (comboBox1.Text.Length == 0) { MessageBox.Show("Укажите статью!"); comboBox1.Focus(); return; }
            if (textBox1.Text.Length == 0) { MessageBox.Show("Укажите сумму!"); textBox1.Focus(); return; }
            if (comboBox2.Text.Length == 0) { MessageBox.Show("Укажите месяц!"); comboBox2.Focus(); return; }
            if (textBox2.Text.Length == 0) { MessageBox.Show("Укажите год!"); textBox2.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_plan_budjet(int.Parse(comboBox1.SelectedValue.ToString()), decimal.Parse(textBox1.Text), comboBox2.SelectedIndex+1, int.Parse(textBox2.Text));
            }
            else
            {
                procedure.spUpd_plan_budjet(int.Parse(comboBox1.SelectedValue.ToString()), decimal.Parse(textBox1.Text), comboBox2.SelectedIndex+1, int.Parse(textBox2.Text), int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
            }

            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
