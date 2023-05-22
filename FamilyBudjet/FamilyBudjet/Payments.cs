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
    public partial class Payments : Form
    {
        DataGridViewRow ID;
        public Payments(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

            
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.family_member". При необходимости она может быть перемещена или удалена.
            this.family_memberTableAdapter.Fill(this.semBudjetDataSet.family_member);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.kredits". При необходимости она может быть перемещена или удалена.
            this.kreditsTableAdapter.Fill(this.semBudjetDataSet.kredits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.payments". При необходимости она может быть перемещена или удалена.
            this.paymentsTableAdapter.Fill(this.semBudjetDataSet.payments);

            paymentsBindingSource.Filter = "id_kredit = " + ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_payments((int)paymentsDataGridView.Rows[paymentsDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.paymentsTableAdapter.Fill(this.semBudjetDataSet.payments);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PaymentEdit form = new PaymentEdit(paymentsDataGridView.Rows[paymentsDataGridView.CurrentCell.RowIndex], ID);
            form.ShowDialog();
            this.paymentsTableAdapter.Fill(this.semBudjetDataSet.payments);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentEdit form = new PaymentEdit(null, ID);
            form.ShowDialog();
            this.paymentsTableAdapter.Fill(this.semBudjetDataSet.payments);

        }
    }
}
