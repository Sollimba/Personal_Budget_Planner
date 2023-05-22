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
    public partial class ArticlesEdit : Form
    {
        DataGridViewRow ID;
        public ArticlesEdit(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (textBox1.Text.Length == 0) { MessageBox.Show("Укажите статью!"); textBox1.Focus(); return; }
            if (comboBox1.Text.Length == 0) { MessageBox.Show("Укажите категорию!"); comboBox1.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_articles(int.Parse(comboBox1.SelectedValue.ToString()), textBox1.Text, checkBox1.Checked);
            }
            else
            {
                procedure.spUpd_articles(int.Parse(comboBox1.SelectedValue.ToString()), textBox1.Text, checkBox1.Checked, int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
            }

            Close();
        }

        private void ArticlesEdit_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ada = new SqlDataAdapter();
            DataTable dt = new DataTable();
                SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
                cmd.Connection = sqlConnection;
                cmd.CommandText = "SELECT * FROM category";
                ada.SelectCommand = cmd;
                ada.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "title_category";
                    comboBox1.ValueMember = "id_category";
                    comboBox1.SelectedIndex = 0;
                }



            if (ID != null)
            {
                if (int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) > 0)
                {
                    textBox1.Text = (string)ID.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                    comboBox1.SelectedValue = int.Parse(ID.Cells["dataGridViewTextBoxColumn2"].Value.ToString());
                    checkBox1.Checked = bool.Parse(ID.Cells["dataGridViewCheckBoxColumn1"].Value.ToString());
                }
                else
                {
                    textBox1.Clear();
                    comboBox1.SelectedIndex = -1;
                    checkBox1.Checked = false;
                }
            }            
        }
    }
}
