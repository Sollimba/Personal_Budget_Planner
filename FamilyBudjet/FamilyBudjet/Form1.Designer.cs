namespace FamilyBudjet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииЗатратToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статьиБюджетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыЧленовСемьиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.служебныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.semBudjetDataSet1 = new FamilyBudjet.SemBudjetDataSet();
            this.articlesTableAdapter1 = new FamilyBudjet.SemBudjetDataSetTableAdapters.articlesTableAdapter();
            this.categoryTableAdapter1 = new FamilyBudjet.SemBudjetDataSetTableAdapters.categoryTableAdapter();
            this.family_memberTableAdapter1 = new FamilyBudjet.SemBudjetDataSetTableAdapters.family_memberTableAdapter();
            this.paymentsTableAdapter1 = new FamilyBudjet.SemBudjetDataSetTableAdapters.paymentsTableAdapter();
            this.articlesTableAdapter2 = new FamilyBudjet.SemBudjetDataSetTableAdapters.articlesTableAdapter();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.служебныеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииЗатратToolStripMenuItem,
            this.статьиБюджетаToolStripMenuItem,
            this.типыЧленовСемьиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // категорииЗатратToolStripMenuItem
            // 
            this.категорииЗатратToolStripMenuItem.Name = "категорииЗатратToolStripMenuItem";
            this.категорииЗатратToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.категорииЗатратToolStripMenuItem.Text = "Категории затрат";
            this.категорииЗатратToolStripMenuItem.Click += new System.EventHandler(this.категорииЗатратToolStripMenuItem_Click);
            // 
            // статьиБюджетаToolStripMenuItem
            // 
            this.статьиБюджетаToolStripMenuItem.Name = "статьиБюджетаToolStripMenuItem";
            this.статьиБюджетаToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.статьиБюджетаToolStripMenuItem.Text = "Статьи бюджета";
            this.статьиБюджетаToolStripMenuItem.Click += new System.EventHandler(this.статьиБюджетаToolStripMenuItem_Click);
            // 
            // типыЧленовСемьиToolStripMenuItem
            // 
            this.типыЧленовСемьиToolStripMenuItem.Name = "типыЧленовСемьиToolStripMenuItem";
            this.типыЧленовСемьиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.типыЧленовСемьиToolStripMenuItem.Text = "Пользователи настройки";
            this.типыЧленовСемьиToolStripMenuItem.Click += new System.EventHandler(this.типыЧленовСемьиToolStripMenuItem_Click);
            // 
            // служебныеToolStripMenuItem
            // 
            this.служебныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.журналToolStripMenuItem});
            this.служебныеToolStripMenuItem.Name = "служебныеToolStripMenuItem";
            this.служебныеToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.служебныеToolStripMenuItem.Text = "Служебные";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.пользователиToolStripMenuItem.Text = "Пользователипроф";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.журналToolStripMenuItem.Text = "Журнал";
            this.журналToolStripMenuItem.Click += new System.EventHandler(this.журналToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(52, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пользователи";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(52, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Плановый бюджет";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCyan;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(52, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Операции";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(52, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(287, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Кредиты";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(405, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчет по дате";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "по";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(56, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 29);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "с";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 29);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // semBudjetDataSet1
            // 
            this.semBudjetDataSet1.DataSetName = "SemBudjetDataSet";
            this.semBudjetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articlesTableAdapter1
            // 
            this.articlesTableAdapter1.ClearBeforeFill = true;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // family_memberTableAdapter1
            // 
            this.family_memberTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentsTableAdapter1
            // 
            this.paymentsTableAdapter1.ClearBeforeFill = true;
            // 
            // articlesTableAdapter2
            // 
            this.articlesTableAdapter2.ClearBeforeFill = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightCyan;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(633, 243);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 52);
            this.button8.TabIndex = 2;
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseHover += new System.EventHandler(this.Button8_MouseHover);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCyan;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(519, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 52);
            this.button7.TabIndex = 1;
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseHover += new System.EventHandler(this.Button7_MouseHover);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCyan;
            this.button6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Image = global::FamilyBudjet.Properties.Resources.excel;
            this.button6.Location = new System.Drawing.Point(405, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 52);
            this.button6.TabIndex = 0;
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseHover += new System.EventHandler(this.Button6_MouseHover);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Персональный Планировщик бюджета";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semBudjetDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииЗатратToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статьиБюджетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыЧленовСемьиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem служебныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private SemBudjetDataSet semBudjetDataSet1;
        private SemBudjetDataSetTableAdapters.articlesTableAdapter articlesTableAdapter1;
        private SemBudjetDataSetTableAdapters.categoryTableAdapter categoryTableAdapter1;
        private SemBudjetDataSetTableAdapters.family_memberTableAdapter family_memberTableAdapter1;
        private SemBudjetDataSetTableAdapters.paymentsTableAdapter paymentsTableAdapter1;
        private SemBudjetDataSetTableAdapters.articlesTableAdapter articlesTableAdapter2;
        private System.Windows.Forms.Button button5;
    }
}

