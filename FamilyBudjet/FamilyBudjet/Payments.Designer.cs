﻿namespace FamilyBudjet
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.button6 = new System.Windows.Forms.Button();
            this.semBudjetDataSet = new FamilyBudjet.SemBudjetDataSet();
            this.paymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.paymentsTableAdapter();
            this.tableAdapterManager = new FamilyBudjet.SemBudjetDataSetTableAdapters.TableAdapterManager();
            this.family_memberTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.family_memberTableAdapter();
            this.kreditsTableAdapter = new FamilyBudjet.SemBudjetDataSetTableAdapters.kreditsTableAdapter();
            this.paymentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.kreditsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.familymemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.familymemberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.splitter2);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(712, 33);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(165, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(246, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(347, 23);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(599, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Назад";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // semBudjetDataSet
            // 
            this.semBudjetDataSet.DataSetName = "SemBudjetDataSet";
            this.semBudjetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentsBindingSource
            // 
            this.paymentsBindingSource.DataMember = "payments";
            this.paymentsBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // paymentsTableAdapter
            // 
            this.paymentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.articlesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoryTableAdapter = null;
            this.tableAdapterManager.deposits_on_targetTableAdapter = null;
            this.tableAdapterManager.family_memberTableAdapter = this.family_memberTableAdapter;
            this.tableAdapterManager.kreditsTableAdapter = this.kreditsTableAdapter;
            this.tableAdapterManager.operationsTableAdapter = null;
            this.tableAdapterManager.paymentsTableAdapter = this.paymentsTableAdapter;
            this.tableAdapterManager.plan_budjetTableAdapter = null;
            this.tableAdapterManager.targetsTableAdapter = null;
            this.tableAdapterManager.type_memberTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FamilyBudjet.SemBudjetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.ZhurnalTableAdapter = null;
            // 
            // family_memberTableAdapter
            // 
            this.family_memberTableAdapter.ClearBeforeFill = true;
            // 
            // kreditsTableAdapter
            // 
            this.kreditsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentsDataGridView
            // 
            this.paymentsDataGridView.AllowUserToAddRows = false;
            this.paymentsDataGridView.AllowUserToDeleteRows = false;
            this.paymentsDataGridView.AutoGenerateColumns = false;
            this.paymentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.paymentsDataGridView.DataSource = this.paymentsBindingSource;
            this.paymentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paymentsDataGridView.Location = new System.Drawing.Point(0, 33);
            this.paymentsDataGridView.Name = "paymentsDataGridView";
            this.paymentsDataGridView.Size = new System.Drawing.Size(712, 417);
            this.paymentsDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_payment";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_payment";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_kredit";
            this.dataGridViewTextBoxColumn2.DataSource = this.kreditsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "title_kredit";
            this.dataGridViewTextBoxColumn2.HeaderText = "Кредит";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id_kredit";
            // 
            // kreditsBindingSource
            // 
            this.kreditsBindingSource.DataMember = "kredits";
            this.kreditsBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сумма";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date_payment";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_family_member";
            this.dataGridViewTextBoxColumn5.DataSource = this.familymemberBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "name_member";
            this.dataGridViewTextBoxColumn5.HeaderText = "Член семьи";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "id_family_member";
            // 
            // familymemberBindingSource
            // 
            this.familymemberBindingSource.DataMember = "family_member";
            this.familymemberBindingSource.DataSource = this.semBudjetDataSet;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.paymentsDataGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Платежи";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kreditsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.familymemberBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button button6;
        private SemBudjetDataSet semBudjetDataSet;
        private System.Windows.Forms.BindingSource paymentsBindingSource;
        private SemBudjetDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter;
        private SemBudjetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView paymentsDataGridView;
        private SemBudjetDataSetTableAdapters.kreditsTableAdapter kreditsTableAdapter;
        private System.Windows.Forms.BindingSource kreditsBindingSource;
        private SemBudjetDataSetTableAdapters.family_memberTableAdapter family_memberTableAdapter;
        private System.Windows.Forms.BindingSource familymemberBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}