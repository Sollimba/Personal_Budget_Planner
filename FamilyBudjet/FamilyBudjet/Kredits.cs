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
    public partial class Kredits : Form
    {
        public Kredits()
        {
            InitializeComponent();
        }

        private void kreditsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kreditsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void Kredits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.kredits". При необходимости она может быть перемещена или удалена.
            this.kreditsTableAdapter.Fill(this.semBudjetDataSet.kredits);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Payments f = new Payments(kreditsDataGridView.Rows[kreditsDataGridView.CurrentCell.RowIndex]);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_kredits((int)kreditsDataGridView.Rows[kreditsDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.kreditsTableAdapter.Fill(this.semBudjetDataSet.kredits);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KreditsEdit form = new KreditsEdit(kreditsDataGridView.Rows[kreditsDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();
            this.kreditsTableAdapter.Fill(this.semBudjetDataSet.kredits);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KreditsEdit form = new KreditsEdit(null);
            form.ShowDialog();
            this.kreditsTableAdapter.Fill(this.semBudjetDataSet.kredits);
        }
    }
}
