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
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }

        private void articlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.articlesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void Articles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.semBudjetDataSet.category);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.articles". При необходимости она может быть перемещена или удалена.
            this.articlesTableAdapter.Fill(this.semBudjetDataSet.articles);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Добавление статьи");

            ArticlesEdit form = new ArticlesEdit(null);
            form.ShowDialog();
            this.articlesTableAdapter.Fill(this.semBudjetDataSet.articles);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Редактирование статьи");

            ArticlesEdit form = new ArticlesEdit(articlesDataGridView.Rows[articlesDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();
            this.articlesTableAdapter.Fill(this.semBudjetDataSet.articles);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_articles((int)articlesDataGridView.Rows[articlesDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.articlesTableAdapter.Fill(this.semBudjetDataSet.articles);

                DataBaseProcedure dbproc = new DataBaseProcedure();
                dbproc.spAdd_Zhurnal(Form1.ID_user, "Удаление статьи");
            }
        }
    }
}
