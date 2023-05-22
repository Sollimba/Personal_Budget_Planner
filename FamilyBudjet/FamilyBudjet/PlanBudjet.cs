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
    public partial class PlanBudjet : Form
    {
        public PlanBudjet()
        {
            InitializeComponent();
        }

        private void plan_budjetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plan_budjetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void PlanBudjet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.articles". При необходимости она может быть перемещена или удалена.
            this.articlesTableAdapter.Fill(this.semBudjetDataSet.articles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.plan_budjet". При необходимости она может быть перемещена или удалена.
            this.plan_budjetTableAdapter.Fill(this.semBudjetDataSet.plan_budjet);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_plan_budjet((int)plan_budjetDataGridView.Rows[plan_budjetDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.plan_budjetTableAdapter.Fill(this.semBudjetDataSet.plan_budjet);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlanBudjetEdit form = new PlanBudjetEdit(plan_budjetDataGridView.Rows[plan_budjetDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();
            this.plan_budjetTableAdapter.Fill(this.semBudjetDataSet.plan_budjet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlanBudjetEdit form = new PlanBudjetEdit(null);
            form.ShowDialog();
            this.plan_budjetTableAdapter.Fill(this.semBudjetDataSet.plan_budjet);
        }
    }
}
