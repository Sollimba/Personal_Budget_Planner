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
    public partial class Deposits : Form
    { 
        DataGridViewRow ID;
        public Deposits(DataGridViewRow id)
        {
            InitializeComponent();
            ID = id;
        }

        private void deposits_on_targetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deposits_on_targetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void Deposits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.family_member". При необходимости она может быть перемещена или удалена.
            this.family_memberTableAdapter.Fill(this.semBudjetDataSet.family_member);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.deposits_on_target". При необходимости она может быть перемещена или удалена.
            this.deposits_on_targetTableAdapter.Fill(this.semBudjetDataSet.deposits_on_target);

            deposits_on_targetBindingSource.Filter = "id_target = " + ID.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
        }

        private void deposits_on_targetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Добавление вклада");

            DepostEdit form = new DepostEdit(null, ID);
            form.ShowDialog();
            this.deposits_on_targetTableAdapter.Fill(this.semBudjetDataSet.deposits_on_target);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBaseProcedure dbproc = new DataBaseProcedure();
            dbproc.spAdd_Zhurnal(Form1.ID_user, "Редактирование вклада");

            DepostEdit form = new DepostEdit(deposits_on_targetDataGridView.Rows[deposits_on_targetDataGridView.CurrentCell.RowIndex], ID);
            form.ShowDialog();
            this.deposits_on_targetTableAdapter.Fill(this.semBudjetDataSet.deposits_on_target);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_deposits_on_target((int)deposits_on_targetDataGridView.Rows[deposits_on_targetDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.deposits_on_targetTableAdapter.Fill(this.semBudjetDataSet.deposits_on_target);

                DataBaseProcedure dbproc = new DataBaseProcedure();
                dbproc.spAdd_Zhurnal(Form1.ID_user, "Удаление вклада");
            }
        }
    }
}
