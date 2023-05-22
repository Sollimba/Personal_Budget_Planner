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
    public partial class PaymentEdit : Form
    {
        DataGridViewRow ID;
        DataGridViewRow ID_kredit;
        public PaymentEdit(DataGridViewRow id, DataGridViewRow id_kredit)
        {
            InitializeComponent();
            ID = id;
            ID_kredit = id_kredit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PaymentEdit_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter ada = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT * FROM family_member";
            ada.SelectCommand = cmd;
            ada.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "name_member";
                comboBox1.ValueMember = "id_family_member";
                comboBox1.SelectedIndex = 0;
            }

            SqlCommand cmd1 = new SqlCommand();
            SqlDataAdapter ada1 = new SqlDataAdapter();
            DataTable dt1 = new DataTable();
            cmd1.Connection = sqlConnection;
            cmd1.CommandText = "SELECT * FROM kredits WHERE id_kredit = " + ID_kredit.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            ada1.SelectCommand = cmd1;
            ada1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                comboBox2.DataSource = dt1;
                comboBox2.DisplayMember = "title_kredit";
                comboBox2.ValueMember = "id_kredit";
                comboBox2.SelectedIndex = 0;
            }

            if (ID != null)
            {
                if (int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()) > 0)
                {
                    comboBox1.SelectedValue = int.Parse(ID.Cells["dataGridViewTextBoxColumn5"].Value.ToString());
                    comboBox2.SelectedValue = int.Parse(ID_kredit.Cells["dataGridViewTextBoxColumn1"].Value.ToString());
                    textBox1.Text = (string)ID.Cells["dataGridViewTextBoxColumn3"].Value.ToString();
                    dateTimePicker1.Value = DateTime.Parse(ID.Cells["dataGridViewTextBoxColumn4"].Value.ToString());
                }
                else
                {
                    textBox1.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox1.SelectedIndex = -1;
                    comboBox2.SelectedIndex = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //проверка заполненности полей
            if (comboBox1.Text.Length == 0) { MessageBox.Show("Укажите члена семьи!"); comboBox1.Focus(); return; }
            if (textBox1.Text.Length == 0) { MessageBox.Show("Укажите сумму!"); textBox1.Focus(); return; }
            if (comboBox2.Text.Length == 0) { MessageBox.Show("Укажите кредит!"); comboBox2.Focus(); return; }

            DataBaseProcedure procedure = new DataBaseProcedure();
            // в зависимости от типа операций выполнять процедуру на обновление или добавления данных в таблицу
            if (ID == null)
            {
                procedure.spAdd_payments(int.Parse(comboBox2.SelectedValue.ToString()), decimal.Parse(textBox1.Text), dateTimePicker1.Value, int.Parse(comboBox1.SelectedValue.ToString()));
            }
            else
            {
                procedure.spUpd_payments(int.Parse(comboBox2.SelectedValue.ToString()), decimal.Parse(textBox1.Text), dateTimePicker1.Value, int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString()));
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
    }
}
