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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.semBudjetDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "semBudjetDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.semBudjetDataSet.users);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //удаление текущей записи из БД
            DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите удалить?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataBaseProcedure procedure = new DataBaseProcedure();
                procedure.spDel_User((int)usersDataGridView.Rows[usersDataGridView.CurrentCell.RowIndex].Cells[0].Value);
                this.usersTableAdapter.Fill(this.semBudjetDataSet.users);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditUser form = new EditUser(usersDataGridView.Rows[usersDataGridView.CurrentCell.RowIndex]);
            form.ShowDialog();
            this.usersTableAdapter.Fill(this.semBudjetDataSet.users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditUser form = new EditUser(null);
            form.ShowDialog();
            this.usersTableAdapter.Fill(this.semBudjetDataSet.users);
        }
    }
}
