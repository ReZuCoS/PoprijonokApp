
namespace PoprijonokApp.Forms
{
    partial class AddChangeAgentForm
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label saleDateLabel;
            System.Windows.Forms.Label productCountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChangeAgentForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.contextLabel = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.priorityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.productCountTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePickerSale = new System.Windows.Forms.DateTimePicker();
            addressLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            saleDateLabel = new System.Windows.Forms.Label();
            productCountLabel = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(268, 148);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(50, 18);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Адрес:";
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Location = new System.Drawing.Point(268, 116);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(44, 18);
            agentTypeIDLabel.TabIndex = 5;
            agentTypeIDLabel.Text = "Тип*:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Location = new System.Drawing.Point(268, 244);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(107, 18);
            directorNameLabel.TabIndex = 7;
            directorNameLabel.Text = "Имя директора:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(268, 305);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 18);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "E-mail:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(268, 180);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(49, 18);
            iNNLabel.TabIndex = 13;
            iNNLabel.Text = "ИНН*:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Location = new System.Drawing.Point(268, 212);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(44, 18);
            kPPLabel.TabIndex = 15;
            kPPLabel.Text = "КПП:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(268, 273);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(103, 18);
            phoneLabel.TabIndex = 19;
            phoneLabel.Text = "Номер(без 7)*:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(268, 337);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(88, 18);
            priorityLabel.TabIndex = 21;
            priorityLabel.Text = "Приоритет*:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(268, 84);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(78, 18);
            titleLabel.TabIndex = 23;
            titleLabel.Text = "Название*:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(11, 571);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(66, 18);
            productIDLabel.TabIndex = 28;
            productIDLabel.Text = "Продукт:";
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Location = new System.Drawing.Point(270, 572);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(42, 18);
            saleDateLabel.TabIndex = 30;
            saleDateLabel.Text = "Дата:";
            // 
            // productCountLabel
            // 
            productCountLabel.AutoSize = true;
            productCountLabel.Location = new System.Drawing.Point(427, 572);
            productCountLabel.Name = "productCountLabel";
            productCountLabel.Size = new System.Drawing.Size(52, 18);
            productCountLabel.TabIndex = 31;
            productCountLabel.Text = "Кол-во";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.panelTop.Controls.Add(this.contextLabel);
            this.panelTop.Controls.Add(this.pictureBoxIcon);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(678, 75);
            this.panelTop.TabIndex = 2;
            // 
            // contextLabel
            // 
            this.contextLabel.AutoSize = true;
            this.contextLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextLabel.Location = new System.Drawing.Point(79, 26);
            this.contextLabel.Name = "contextLabel";
            this.contextLabel.Size = new System.Drawing.Size(97, 23);
            this.contextLabel.TabIndex = 1;
            this.contextLabel.Text = "ДЕЙСТВИЕ";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::PoprijonokApp.Properties.Resources.Logo;
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(70, 70);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(378, 145);
            this.addressTextBox.MaxLength = 300;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(288, 26);
            this.addressTextBox.TabIndex = 2;
            // 
            // agentTypeIDComboBox
            // 
            this.agentTypeIDComboBox.DataSource = this.agentTypeBindingSource;
            this.agentTypeIDComboBox.DisplayMember = "Title";
            this.agentTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentTypeIDComboBox.FormattingEnabled = true;
            this.agentTypeIDComboBox.Location = new System.Drawing.Point(378, 113);
            this.agentTypeIDComboBox.Name = "agentTypeIDComboBox";
            this.agentTypeIDComboBox.Size = new System.Drawing.Size(288, 26);
            this.agentTypeIDComboBox.TabIndex = 1;
            this.agentTypeIDComboBox.ValueMember = "ID";
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(PoprijonokApp.Models.AgentType);
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.Location = new System.Drawing.Point(378, 241);
            this.directorNameTextBox.MaxLength = 100;
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(288, 26);
            this.directorNameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(378, 302);
            this.emailTextBox.MaxLength = 255;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(288, 26);
            this.emailTextBox.TabIndex = 7;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.Location = new System.Drawing.Point(378, 177);
            this.iNNTextBox.MaxLength = 12;
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(288, 26);
            this.iNNTextBox.TabIndex = 3;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.Location = new System.Drawing.Point(378, 209);
            this.kPPTextBox.MaxLength = 9;
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(288, 26);
            this.kPPTextBox.TabIndex = 4;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(378, 270);
            this.phoneTextBox.MaxLength = 10;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(288, 26);
            this.phoneTextBox.TabIndex = 6;
            // 
            // priorityTextBox
            // 
            this.priorityTextBox.Location = new System.Drawing.Point(378, 334);
            this.priorityTextBox.Name = "priorityTextBox";
            this.priorityTextBox.Size = new System.Drawing.Size(288, 26);
            this.priorityTextBox.TabIndex = 8;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(378, 81);
            this.titleTextBox.MaxLength = 150;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(288, 26);
            this.titleTextBox.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPictureBox.Image = global::PoprijonokApp.Properties.Resources._default;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 84);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(250, 250);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 25;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.ChangeAgentLogo);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Нажмите для изменения";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.cancelButton.Location = new System.Drawing.Point(479, 613);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(187, 36);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CloseForm);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.saveButton.Location = new System.Drawing.Point(12, 613);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(187, 36);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.Save);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agentIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.productCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productSaleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(654, 171);
            this.dataGridView1.TabIndex = 27;
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "Агент";
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            this.agentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.agentIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Width = 87;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Дата реализации";
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleDateDataGridViewTextBoxColumn.Width = 129;
            // 
            // productCountDataGridViewTextBoxColumn
            // 
            this.productCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productCountDataGridViewTextBoxColumn.DataPropertyName = "ProductCount";
            this.productCountDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.productCountDataGridViewTextBoxColumn.Name = "productCountDataGridViewTextBoxColumn";
            this.productCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCountDataGridViewTextBoxColumn.Width = 77;
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataSource = typeof(PoprijonokApp.Models.ProductSale);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "История реализации продукции:";
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.DataSource = this.productBindingSource;
            this.productIDComboBox.DisplayMember = "Title";
            this.productIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(83, 568);
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(181, 26);
            this.productIDComboBox.TabIndex = 29;
            this.productIDComboBox.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PoprijonokApp.Models.Product);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 30;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddSale);
            // 
            // productCountTextBox
            // 
            this.productCountTextBox.Location = new System.Drawing.Point(485, 569);
            this.productCountTextBox.Name = "productCountTextBox";
            this.productCountTextBox.Size = new System.Drawing.Size(100, 26);
            this.productCountTextBox.TabIndex = 32;
            // 
            // dateTimePickerSale
            // 
            this.dateTimePickerSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSale.Location = new System.Drawing.Point(316, 568);
            this.dateTimePickerSale.Name = "dateTimePickerSale";
            this.dateTimePickerSale.Size = new System.Drawing.Size(105, 26);
            this.dateTimePickerSale.TabIndex = 33;
            // 
            // AddChangeAgentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(678, 661);
            this.Controls.Add(this.dateTimePickerSale);
            this.Controls.Add(productCountLabel);
            this.Controls.Add(this.productCountTextBox);
            this.Controls.Add(saleDateLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(agentTypeIDLabel);
            this.Controls.Add(this.agentTypeIDComboBox);
            this.Controls.Add(directorNameLabel);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(694, 700);
            this.MinimumSize = new System.Drawing.Size(694, 700);
            this.Name = "AddChangeAgentForm";
            this.Load += new System.EventHandler(this.FormLoad);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label contextLabel;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox agentTypeIDComboBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox priorityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox productCountTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerSale;
    }
}