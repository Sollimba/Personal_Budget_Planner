namespace FamilyBudjet
{
    partial class Family_member
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Family_member));
            this.semBudjetDataSet = new FamilyBudjet.SemBudjetDataSet();
            this.family_memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.family_memberTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.family_memberTableAdapter();
            this.tableAdapterManager = new FamilyBudjet.SemBudjetDataSetTableAdapters.TableAdapterManager();
            this.type_memberTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.type_memberTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button5 = new System.Windows.Forms.Button();
            this.family_memberDataGridView = new System.Windows.Forms.DataGridView();
            this.typememberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_memberBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.family_memberDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typememberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // semBudjetDataSet
            // 
            this.semBudjetDataSet.DataSetName = "SemBudjetDataSet";
            this.semBudjetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // family_memberBindingSource
            // 
            this.family_memberBindingSource.DataMember = "family_member";
            this.family_memberBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // family_memberTableAdapter
            // 
            this.family_memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articlesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.deposits_on_targetTableAdapter = null;
            this.tableAdapterManager.family_memberTableAdapter = this.family_memberTableAdapter;
            this.tableAdapterManager.kreditsTableAdapter = null;
            this.tableAdapterManager.operationsTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.plan_budjetTableAdapter = null;
            this.tableAdapterManager.targetsTableAdapter = null;
            this.tableAdapterManager.type_memberTableAdapter = this.type_memberTableAdapter;
            this.tableAdapterManager.UpdateOrder = FamilyBudjet.SemBudjetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.ZhurnalTableAdapter = null;
            // 
            // type_memberTableAdapter
            // 
            this.type_memberTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.splitter1);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 33);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(246, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(433, 23);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(685, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // family_memberDataGridView
            // 
            this.family_memberDataGridView.AllowUserToAddRows = false;
            this.family_memberDataGridView.AllowUserToDeleteRows = false;
            this.family_memberDataGridView.AutoGenerateColumns = false;
            this.family_memberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.family_memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.family_memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.telephone});
            this.family_memberDataGridView.DataSource = this.family_memberBindingSource;
            this.family_memberDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.family_memberDataGridView.Location = new System.Drawing.Point(0, 33);
            this.family_memberDataGridView.Name = "family_memberDataGridView";
            this.family_memberDataGridView.Size = new System.Drawing.Size(800, 417);
            this.family_memberDataGridView.TabIndex = 26;
            this.family_memberDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Family_memberDataGridView_CellContentClick);
            // 
            // typememberBindingSource
            // 
            this.typememberBindingSource.DataMember = "type_member";
            this.typememberBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_family_member";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_family_member";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_member";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_type_member";
            this.dataGridViewTextBoxColumn3.DataSource = this.typememberBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "title_type_member";
            this.dataGridViewTextBoxColumn3.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_type_member";
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "telephone";
            this.telephone.HeaderText = "telephone";
            this.telephone.Name = "telephone";
            // 
            // Family_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.family_memberDataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Family_member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.Family_member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.family_memberBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.family_memberDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typememberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SemBudjetDataSet semBudjetDataSet;
        private System.Windows.Forms.BindingSource family_memberBindingSource;
        private SemBudjetDataSetTableAdapters.family_memberTableAdapter family_memberTableAdapter;
        private SemBudjetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SemBudjetDataSetTableAdapters.type_memberTableAdapter type_memberTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView family_memberDataGridView;
        private System.Windows.Forms.BindingSource typememberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
    }
}