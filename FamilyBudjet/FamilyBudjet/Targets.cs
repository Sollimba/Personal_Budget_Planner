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
    public partial class Targets : Form
    {
        public Targets()
        {
            InitializeComponent();
        }

        private void targetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.targetsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void Targets_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.targets". При необходимости она может быть перемещена или удалена.
            this.targetsTableAdapter.Fill(this.semBudjetDataSet.targets);

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
                procedure.spDel_targets((int)targetsDataGridView.Rows[targetsDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.targetsTableAdapter.Fill(this.semBudjetDataSet.targets);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TargetEdit form = new TargetEdit(null);
            form.ShowDialog();
            this.targetsTableAdapter.Fill(this.semBudjetDataSet.targets);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TargetEdit form = new TargetEdit(targetsDataGridView.Rows[targetsDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();
            this.targetsTableAdapter.Fill(this.semBudjetDataSet.targets);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Deposits f = new Deposits(targetsDataGridView.Rows[targetsDataGridView.CurrentCell.RowIndex]);
            f.ShowDialog();
        }
    }
}
