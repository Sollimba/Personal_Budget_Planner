﻿using System;
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
    public partial class FamilyMemberEdit : Form
    {
        DataGridViewRow ID;
        public FamilyMemberEdit(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void FamilyMemberEdit_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ada = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT * FROM type_member";
            ada.SelectCommand = cmd;
            ada.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "title_type_member";
                comboBox1.ValueMember = "id_type_member";
                comboBox1.SelectedIndex = 0;
            }



            if (ID != null)
            {
                if (int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) > 0)
                {
                    textBox1.Text = (string)ID.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                    comboBox1.SelectedValue = int.Parse(ID.Cells["dataGridViewTextBoxColumn3"].Value.ToString());
                    textBox2.Text = (string)ID.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                }
                else
                {
                    textBox1.Clear();
                    comboBox1.SelectedIndex = -1;
                    textBox2.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (textBox1.Text.Length == 0) { MessageBox.Show("Укажите категорию!"); textBox1.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_family_member(textBox1.Text, int.Parse(comboBox1.SelectedValue.ToString()), textBox2.Text);
            }
            else
            {
                procedure.spUpd_family_member(textBox1.Text, int.Parse(comboBox1.SelectedValue.ToString()), textBox2.Text, int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
            }

            Close();

        }

        private void label2_Click(object sender, EventArgs e)
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
