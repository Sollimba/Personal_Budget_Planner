namespace FamilyBudjet
{
    partial class Operations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operations));
            this.semBudjetDataSet = new FamilyBudjet.SemBudjetDataSet();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.operationsTableAdapter();
            this.tableAdapterManager = new FamilyBudjet.SemBudjetDataSetTableAdapters.TableAdapterManager();
            this.articlesTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.articlesTableAdapter();
            this.family_memberTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.family_memberTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button5 = new System.Windows.Forms.Button();
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.familymemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familymemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // semBudjetDataSet
            // 
            this.semBudjetDataSet.DataSetName = "SemBudjetDataSet";
            this.semBudjetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "operations";
            this.operationsBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articlesTableAdapter = this.articlesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.deposits_on_targetTableAdapter = null;
            this.tableAdapterManager.family_memberTableAdapter = this.family_memberTableAdapter;
            this.tableAdapterManager.kreditsTableAdapter = null;
            this.tableAdapterManager.operationsTableAdapter = this.operationsTableAdapter;
            this.tableAdapterManager.paymentsTableAdapter = null;
            this.tableAdapterManager.plan_budjetTableAdapter = null;
            this.tableAdapterManager.targetsTableAdapter = null;
            this.tableAdapterManager.type_memberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FamilyBudjet.SemBudjetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.ZhurnalTableAdapter = null;
            // 
            // articlesTableAdapter
            // 
            this.articlesTableAdapter.ClearBeforeFill = true;
            // 
            // family_memberTableAdapter
            // 
            this.family_memberTableAdapter.ClearBeforeFill = true;
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(706, 33);
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
            this.splitter1.Size = new System.Drawing.Size(347, 23);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(599, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Назад";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // operationsDataGridView
            // 
            this.operationsDataGridView.AllowUserToAddRows = false;
            this.operationsDataGridView.AllowUserToDeleteRows = false;
            this.operationsDataGridView.AutoGenerateColumns = false;
            this.operationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.operationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.operationsDataGridView.DataSource = this.operationsBindingSource;
            this.operationsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationsDataGridView.Location = new System.Drawing.Point(0, 33);
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.Size = new System.Drawing.Size(706, 460);
            this.operationsDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_operation";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_operation";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_article";
            this.dataGridViewTextBoxColumn2.DataSource = this.articlesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Статья";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id_article";
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataMember = "articles";
            this.articlesBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_family_member";
            this.dataGridViewTextBoxColumn3.DataSource = this.familymemberBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "name_member";
            this.dataGridViewTextBoxColumn3.HeaderText = "Член семьи";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_family_member";
            // 
            // familymemberBindingSource
            // 
            this.familymemberBindingSource.DataMember = "family_member";
            this.familymemberBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date_operation";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 493);
            this.Controls.Add(this.operationsDataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Operations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операции";
            this.Load += new System.EventHandler(this.Operations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familymemberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SemBudjetDataSet semBudjetDataSet;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private SemBudjetDataSetTableAdapters.operationsTableAdapter operationsTableAdapter;
        private SemBudjetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView operationsDataGridView;
        private SemBudjetDataSetTableAdapters.articlesTableAdapter articlesTableAdapter;
        private System.Windows.Forms.BindingSource articlesBindingSource;
        private SemBudjetDataSetTableAdapters.family_memberTableAdapter family_memberTableAdapter;
        private System.Windows.Forms.BindingSource familymemberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}