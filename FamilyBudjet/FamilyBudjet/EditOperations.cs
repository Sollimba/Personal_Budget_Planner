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
    public partial class EditOperations : Form
    {
        DataGridViewRow ID;
        public EditOperations(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditOperations_Load(object sender, EventArgs e)
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

            SqlCommand cmd1 = new SqlCommand();
            SqlDataAdapter ada1 = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            cmd1.Connection = sqlConnection;
            cmd1.CommandText = "SELECT * FROM family_member";
            ada1.SelectCommand = cmd1;
            ada1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                comboBox3.DataSource = dt1;
                comboBox3.DisplayMember = "name_member";
                comboBox3.ValueMember = "id_family_member";
                comboBox3.SelectedIndex = 0;
            }



            if (ID != null)
            {
                if (int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) > 0)
                {
                    comboBox1.SelectedValue = int.Parse(ID.Cells["dataGridViewTextBoxColumn2"].Value.ToString());
                    comboBox3.SelectedValue = int.Parse(ID.Cells["dataGridViewTextBoxColumn3"].Value.ToString());
                    dateTimePicker1.Value = DateTime.Parse(ID.Cells["dataGridViewTextBoxColumn4"].Value.ToString());
                    textBox2.Text = ID.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                }
                else
                {
                    textBox2.Clear();
                    comboBox1.SelectedIndex = -1;
                    comboBox3.SelectedIndex = -1;
                    dateTimePicker1.Text = DateTime.Now.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (textBox2.Text.Length == 0) { MessageBox.Show("Укажите сумму!"); textBox2.Focus(); return; }
            if (comboBox1.Text.Length == 0) { MessageBox.Show("Укажите статью!"); comboBox1.Focus(); return; }
            if (comboBox3.Text.Length == 0) { MessageBox.Show("Укажите члена семьи!"); comboBox3.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_operations(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox3.SelectedValue.ToString()), dateTimePicker1.Value, decimal.Parse(textBox2.Text));
            }
            else
            {
                procedure.spUpd_operations(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox3.SelectedValue.ToString()), dateTimePicker1.Value, decimal.Parse(textBox2.Text), int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
            }

            Close();
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
