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
    public partial class Auto : Form
    {
        public Auto()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            //MessageBox.Show(Shifr.Encrypt(tbPassword.Text));
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.users WHERE login = '" + tbLogin.Text + "' and password = '" +tbPassword.Text + "'", sqlConnection);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Form1.role = dt.Rows[0]["role"].ToString();
                Form1.ID_user = int.Parse(dt.Rows[0]["id_user"].ToString());
                Form1.name_user = dt.Rows[0]["name_user"].ToString();

                DataBaseProcedure dbproc = new DataBaseProcedure();
                dbproc.spAdd_Zhurnal(Form1.ID_user, "Вход в систему");
                Close();
            }
            else
            {
                MessageBox.Show("Указали неверные данные!");
            }
        }
    }
}
