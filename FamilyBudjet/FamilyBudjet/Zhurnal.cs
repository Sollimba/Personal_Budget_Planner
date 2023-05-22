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
    public partial class Zhurnal : Form
    {
        public Zhurnal()
        {
            InitializeComponent();
        }

        private void Zhurnal_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT u.name_user, z.action, cast(z.datetime as datetime) "
                +" FROM Zhurnal z INNER JOIN users u ON z.id_user = u.id_user"
                +" ORDER BY z.datetime DESC", sqlConnection);

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "Пользователь";
            dataGridView1.Columns[1].HeaderText = "Событие";
            dataGridView1.Columns[2].HeaderText = "Время";
        }

        private void zhurnalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }
    }
}
