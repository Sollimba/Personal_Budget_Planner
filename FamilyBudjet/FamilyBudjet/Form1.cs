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

using Excel = Microsoft.Office.Interop.Excel;

namespace FamilyBudjet
{
    public partial class Form1 : Form
    {
        public static string role;
        public static int ID_user;
        public static string name_user;

        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Auto f = new Auto();
            f.ShowDialog();

            if (role != "admin")
            {
                справочникиToolStripMenuItem.Visible = false;
                служебныеToolStripMenuItem.Visible = false;
                //groupBox1.Visible = false;
                //Width = 762;
            }
        }
        
        private void статьиБюджетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие справочника Статьи");
            Articles f = new Articles();
            f.ShowDialog();
        }

        private void категорииЗатратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие справочника Категории");
            category f = new category();
            f.ShowDialog();
        }

        private void типыЧленовСемьиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие справочника Пользователипроф");
            TypeFamilyMember f = new TypeFamilyMember();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие формы Пользователи");
            Family_member f = new Family_member();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие Планового бюджета");
            PlanBudjet f = new PlanBudjet();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие Операций");
            Operations f = new Operations();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие кредитов");
            Kredits f = new Kredits();
            f.ShowDialog();
        }

       /* private void button5_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Открытие целей");
            Targets f = new Targets();
            f.ShowDialog();
        }*/

            private void button6_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Формирование финансового отчета");

            string sql = 

                 " SELECT  a.title as Статья, SUM(o.amount) as [Факт сумма], "
                + " (SELECT SUM(pb.amount) * -1"
                + " FROM articles a1 INNER JOIN plan_budjet pb ON pb.id_article = a1.id_article"
                + " WHERE a1.plus = 1 and  a.id_article = a1.id_article"
                + " GROUP BY a1.id_article, a1.title) as [План сумма]"
                + "  , (SUM(o.amount) - ((SELECT SUM(pb.amount)"
                + " FROM articles a1 INNER JOIN plan_budjet pb ON pb.id_article = a1.id_article"
                + " WHERE a1.plus = 1 and  a.id_article = a1.id_article"
                + " GROUP BY a1.id_article, a1.title ))) as Разница"
                + " FROM articles a INNER JOIN operations o ON o.id_article = a.id_article"
                + " WHERE a.plus = 1"
                + " GROUP BY a.id_article, a.title "

                + " UNION ALL"
                + ""
                + " SELECT  a.title, SUM(o.amount) * -1 as oper_sum, "
                +" (SELECT SUM(pb.amount) * -1"
                +" FROM articles a1 INNER JOIN plan_budjet pb ON pb.id_article = a1.id_article"
                +" WHERE a1.plus = 0 and  a.id_article = a1.id_article"
                +" GROUP BY a1.id_article, a1.title) as plan_sum"
                +"  , (((SELECT SUM(pb.amount)"
                +" FROM articles a1 INNER JOIN plan_budjet pb ON pb.id_article = a1.id_article"
                +" WHERE a1.plus = 0 and  a.id_article = a1.id_article"
                +" GROUP BY a1.id_article, a1.title )) -SUM(o.amount)) as Разница"
                +" FROM articles a INNER JOIN operations o ON o.id_article = a.id_article"
                +" WHERE a.plus = 0"
                +" GROUP BY a.id_article, a.title "
                + ""
                + " UNION ALL"
                + " SELECT  'Кредиты', SUM(oper_sum), SUM(plan_sum), SUM(Разница)"
                + " FROM("
                + " SELECT SUM(p.amount) * -1 as oper_sum, (k.amount / cnt_month) * -1 as plan_sum"
                + " , ((k.amount / cnt_month) - SUM(p.amount)) as Разница"
                + " FROM kredits k"
                + " LEFT JOIN payments p ON p.id_kredit = k.id_kredit"
                + " GROUP BY k.amount, cnt_month) t"
                + " "
                + "  UNION ALL"
                + "  SELECT  'Вклады', SUM(oper_sum), SUM(plan_sum), SUM(Разница)"
                + " FROM("
                + " SELECT SUM(d.amount) * -1 as oper_sum, 0 as plan_sum"
                + " , (SUM(d.amount) * -1) as Разница"
                + " FROM targets t"
                + " LEFT JOIN deposits_on_target d ON d.id_target = t.id_target"
                + ") t";

            //MessageBox.Show(sql);

            // создаем пустую книгу и объявляем переменные
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //заполнение таблицы данными
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(sql, sqlConnection);
            adapter.SelectCommand = command;
            adapter.Fill(dt);

            foreach (DataColumn col in dt.Columns)
            {
                xlWorkSheet.Cells[1, dt.Columns.IndexOf(col) + 1] = col.ColumnName.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    xlWorkSheet.Cells[dt.Rows.IndexOf(row) + 2, dt.Columns.IndexOf(col) + 1] = row[dt.Columns.IndexOf(col)];
                }
            }

            xlWorkSheet.Columns["A:A"].Hidden = true;

            //автовыравнивание колонок
            xlWorkSheet.Columns["A:D"].AutoFit();

            //границы таблицы
            Excel.Range xlWorkSheet_rng = xlWorkSheet.get_Range("A1", "D" + (dt.Rows.Count + 1).ToString());
            xlWorkSheet_rng.Borders.ColorIndex = 0;
            xlWorkSheet_rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet_rng.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //сделать первую строку жирной
            xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
        }
      
            private void button8_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Формирование статистики затрат");

            StatisticZatrat f = new StatisticZatrat(this);
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Формирование сравнительного отчета");

            // создаем пустую книгу и объявляем переменные
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //заполнение таблицы данными
            SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings["FamilyBudjet.Properties.Settings.SemBudjetConnectionString"].ConnectionString);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "SELECT title as  Статья,"
                +" case when plus = 1 then oper_sum else oper_sum * -1 end as [Сумма операций],"
                +" case when plus = 1 then plan_sum else plan_sum * -1 end as [Плановая сумма],"
                +" Разница"
                +" FROM("
                +"" +
                " SELECT  a.title, a.plus, SUM(o.amount) as oper_sum,"
                +" (SELECT SUM(pb.amount)"
                +" FROM articles a1 INNER JOIN plan_budjet pb ON pb.id_article = a1.id_article"
                +" WHERE  a.id_article = a1.id_article"
                +" and CAST(CAST(coalesce(num_year, 2000) as VARCHAR) + '-' + CAST(coalesce(num_month, 1) as VARCHAR) + '-' + CAST(1 as VARCHAR) AS DATE)"
                + " between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'"
                + " GROUP BY a1.id_article, a1.title) as plan_sum"
                +"  , (((SELECT SUM(pb.amount)"
                +" FROM articles a1 INNER JOIN plan_budjet pb ON pb.id_article = a1.id_article"
                +" WHERE a.id_article = a1.id_article"
                +" and CAST(CAST(coalesce(num_year,2000) as VARCHAR) +'-' + CAST(coalesce(num_month, 1) as VARCHAR) + '-' + CAST(1 as VARCHAR) AS DATE) "
                + " between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'"
                + " GROUP BY a1.id_article, a1.title )) -SUM(o.amount)) as Разница"
                +" FROM articles a INNER JOIN operations o ON o.id_article = a.id_article"
                + " WHERE o.date_operation between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'"
                + " GROUP BY a.id_article, a.title, a.plus )t";

            //MessageBox.Show(sql);

            SqlCommand command = new SqlCommand(sql, sqlConnection);

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            foreach (DataColumn col in dt.Columns)
            {
                xlWorkSheet.Cells[1, dt.Columns.IndexOf(col) + 1] = col.ColumnName.ToString();
            }

            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    xlWorkSheet.Cells[dt.Rows.IndexOf(row) + 2, dt.Columns.IndexOf(col) + 1] = row[dt.Columns.IndexOf(col)];
                }
            }

            xlWorkSheet.Columns["A:A"].Hidden = true;

            //автовыравнивание колонок
            xlWorkSheet.Columns["A:D"].AutoFit();

            //границы таблицы
            Excel.Range xlWorkSheet_rng = xlWorkSheet.get_Range("A1", "D" + (dt.Rows.Count + 1).ToString());
            xlWorkSheet_rng.Borders.ColorIndex = 0;
            xlWorkSheet_rng.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            xlWorkSheet_rng.Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin;

            //сделать первую строку жирной
            xlWorkSheet.Cells[1, 1].EntireRow.Font.Bold = true;
        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zhurnal f = new Zhurnal();
            f.ShowDialog();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users f = new Users();
            f.ShowDialog();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button6_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button6, "Формирование финансового отчета");
        }

        private void Button7_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button7, "Формирование сравнительного отчета");
        }

        private void Button8_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(button8, "Формирование статистики затрат");
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
