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
    public partial class Operations : Form
    {
        public Operations()
        {
            InitializeComponent();
        }

        private void operationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void Operations_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.family_member". При необходимости она может быть перемещена или удалена.
            this.family_memberTableAdapter.Fill(this.semBudjetDataSet.family_member);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.articles". При необходимости она может быть перемещена или удалена.
            this.articlesTableAdapter.Fill(this.semBudjetDataSet.articles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.semBudjetDataSet.operations);

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
                procedure.spDel_operations((int)operationsDataGridView.Rows[operationsDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.operationsTableAdapter.Fill(this.semBudjetDataSet.operations);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditOperations form = new EditOperations(operationsDataGridView.Rows[operationsDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();
            this.operationsTableAdapter.Fill(this.semBudjetDataSet.operations);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditOperations form = new EditOperations(null);
            form.ShowDialog();
            this.operationsTableAdapter.Fill(this.semBudjetDataSet.operations);
        }
    }
}
