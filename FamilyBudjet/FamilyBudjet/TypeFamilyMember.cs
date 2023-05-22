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
    public partial class TypeFamilyMember : Form
    {
        public TypeFamilyMember()
        {
            InitializeComponent();
        }

        private void type_memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.type_memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void TypeFamilyMember_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.type_member". При необходимости она может быть перемещена или удалена.
            this.type_memberTableAdapter.Fill(this.semBudjetDataSet.type_member);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeFamilyMemberEdit form = new TypeFamilyMemberEdit(type_memberDataGridView.Rows[type_memberDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();

            this.type_memberTableAdapter.Fill(this.semBudjetDataSet.type_member);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_type_member((int)type_memberDataGridView.Rows[type_memberDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.type_memberTableAdapter.Fill(this.semBudjetDataSet.type_member);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TypeFamilyMemberEdit form = new TypeFamilyMemberEdit(null);
            form.ShowDialog();

            this.type_memberTableAdapter.Fill(this.semBudjetDataSet.type_member);
        }
    }
}
