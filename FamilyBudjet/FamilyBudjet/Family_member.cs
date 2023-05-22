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
    public partial class Family_member : Form
    {
        public Family_member()
        {
            InitializeComponent();
        }

        private void family_memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.family_memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void Family_member_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.type_member". При необходимости она может быть перемещена или удалена.
            this.type_memberTableAdapter.Fill(this.semBudjetDataSet.type_member);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.family_member". При необходимости она может быть перемещена или удалена.
            this.family_memberTableAdapter.Fill(this.semBudjetDataSet.family_member);

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
                procedure.spDel_family_member((int)family_memberDataGridView.Rows[family_memberDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.family_memberTableAdapter.Fill(this.semBudjetDataSet.family_member);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FamilyMemberEdit form = new FamilyMemberEdit(family_memberDataGridView.Rows[family_memberDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();

            this.family_memberTableAdapter.Fill(this.semBudjetDataSet.family_member);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FamilyMemberEdit form = new FamilyMemberEdit(null);
            form.ShowDialog();

            this.family_memberTableAdapter.Fill(this.semBudjetDataSet.family_member);
        }

        private void Family_memberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
