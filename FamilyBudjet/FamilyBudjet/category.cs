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
    public partial class category : Form
    {
        public category()
        {
            InitializeComponent();
        }

        private void categoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void category_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.semBudjetDataSet.category);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Изменение категории");

            categoryEdit  form = new categoryEdit(categoryDataGridView.Rows[categoryDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();

            this.categoryTableAdapter.Fill(this.semBudjetDataSet.category);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Добавление категории");

            categoryEdit form = new categoryEdit(null);
            form.ShowDialog();

            this.categoryTableAdapter.Fill(this.semBudjetDataSet.category);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_category((int)categoryDataGridView.Rows[categoryDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.categoryTableAdapter.Fill(this.semBudjetDataSet.category);

                DataBaseProcedure dbproc = new DataBaseProcedure();
                dbproc.spAdd_Zhurnal(Form1.ID_user, "Удаление категории");
            }
        }
    }
}
