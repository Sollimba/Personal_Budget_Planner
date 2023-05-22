using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudjet
{
    public partial class StatisticZatrat : Form
    {
        Form1 F;
        public StatisticZatrat(Form1 f)
        {
            InitializeComponent();
            F = f;
        }

        private static DataTable GetData(string query)
        {
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString; ;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        private void StatisticZatrat_Load(object sender, EventArgs e)
        {
            string query = "SELECT c.title_category, cast(SUM(amount) as int) as summa" +
                " FROM category c INNER JOIN articles a ON c.id_category = a.id_category" +
                " INNER JOIN operations o ON o.id_article = a.id_article" +
                " WHERE a.plus = 0" +
                " and date_operation between '" + F.dateTimePicker1.Value.ToString() + "' and '" + F.dateTimePicker2.Value.ToString() + "'" +
                " GROUP BY c.title_category";
            DataTable dt = GetData(query);

            string[] x = (from p in dt.AsEnumerable()
                          orderby p.Field<string>("title_category") ascending
                          select p.Field<string>("title_category")).ToArray();

            int[] y = (from p in dt.AsEnumerable()
                       orderby p.Field<string>("title_category") ascending
                       select p.Field<int>("summa")).ToArray();

            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }
    }
}
