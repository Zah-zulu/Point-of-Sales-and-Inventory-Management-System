
namespace Major_project_M2
{
    partial class FormSTAFF
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
            this.label1 = new System.Windows.Forms.Label();
            this.SearchStafftextBox = new System.Windows.Forms.TextBox();
            this.EmployeedataGridView = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSStaff = new Major_project_M2.DSStaff();
            this.AddEmployeebutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StaffRoletextBox = new System.Windows.Forms.TextBox();
            this.StaffFirstNametextBox = new System.Windows.Forms.TextBox();
            this.StaffLastNametextBox = new System.Windows.Forms.TextBox();
            this.StaffUsernametextBox = new System.Windows.Forms.TextBox();
            this.StaffPasswordtextBox = new System.Windows.Forms.TextBox();
            this.StaffAgetextBox = new System.Windows.Forms.TextBox();
            this.StaffAddresstextBox = new System.Windows.Forms.TextBox();
            this.staffTableAdapter = new Major_project_M2.DSStaffTableAdapters.StaffTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.UpdateEmployeebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Staff Surname";
            // 
            // SearchStafftextBox
            // 
            this.SearchStafftextBox.Location = new System.Drawing.Point(226, 24);
            this.SearchStafftextBox.Name = "SearchStafftextBox";
            this.SearchStafftextBox.Size = new System.Drawing.Size(306, 22);
            this.SearchStafftextBox.TabIndex = 1;
            this.SearchStafftextBox.TextChanged += new System.EventHandler(this.SearchStafftextBox_TextChanged);
            // 
            // EmployeedataGridView
            // 
            this.EmployeedataGridView.AutoGenerateColumns = false;
            this.EmployeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffRoleDataGridViewTextBoxColumn,
            this.staffFNameDataGridViewTextBoxColumn,
            this.staffLNameDataGridViewTextBoxColumn,
            this.staffUsernameDataGridViewTextBoxColumn,
            this.staffPasswordDataGridViewTextBoxColumn,
            this.staffAgeDataGridViewTextBoxColumn,
            this.staffPhoneNoDataGridViewTextBoxColumn,
            this.staffAddressDataGridViewTextBoxColumn});
            this.EmployeedataGridView.DataSource = this.staffBindingSource;
            this.EmployeedataGridView.Location = new System.Drawing.Point(38, 70);
            this.EmployeedataGridView.Name = "EmployeedataGridView";
            this.EmployeedataGridView.RowHeadersWidth = 51;
            this.EmployeedataGridView.RowTemplate.Height = 24;
            this.EmployeedataGridView.Size = new System.Drawing.Size(1370, 262);
            this.EmployeedataGridView.TabIndex = 2;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffRoleDataGridViewTextBoxColumn
            // 
            this.staffRoleDataGridViewTextBoxColumn.DataPropertyName = "Staff_Role";
            this.staffRoleDataGridViewTextBoxColumn.HeaderText = "Staff_Role";
            this.staffRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffRoleDataGridViewTextBoxColumn.Name = "staffRoleDataGridViewTextBoxColumn";
            this.staffRoleDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffFNameDataGridViewTextBoxColumn
            // 
            this.staffFNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_FName";
            this.staffFNameDataGridViewTextBoxColumn.HeaderText = "Staff_FName";
            this.staffFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffFNameDataGridViewTextBoxColumn.Name = "staffFNameDataGridViewTextBoxColumn";
            this.staffFNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffLNameDataGridViewTextBoxColumn
            // 
            this.staffLNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_LName";
            this.staffLNameDataGridViewTextBoxColumn.HeaderText = "Staff_LName";
            this.staffLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffLNameDataGridViewTextBoxColumn.Name = "staffLNameDataGridViewTextBoxColumn";
            this.staffLNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffUsernameDataGridViewTextBoxColumn
            // 
            this.staffUsernameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Username";
            this.staffUsernameDataGridViewTextBoxColumn.HeaderText = "Staff_Username";
            this.staffUsernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffUsernameDataGridViewTextBoxColumn.Name = "staffUsernameDataGridViewTextBoxColumn";
            this.staffUsernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffPasswordDataGridViewTextBoxColumn
            // 
            this.staffPasswordDataGridViewTextBoxColumn.DataPropertyName = "Staff_Password";
            this.staffPasswordDataGridViewTextBoxColumn.HeaderText = "Staff_Password";
            this.staffPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffPasswordDataGridViewTextBoxColumn.Name = "staffPasswordDataGridViewTextBoxColumn";
            this.staffPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffAgeDataGridViewTextBoxColumn
            // 
            this.staffAgeDataGridViewTextBoxColumn.DataPropertyName = "Staff_Age";
            this.staffAgeDataGridViewTextBoxColumn.HeaderText = "Staff_Age";
            this.staffAgeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffAgeDataGridViewTextBoxColumn.Name = "staffAgeDataGridViewTextBoxColumn";
            this.staffAgeDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffPhoneNoDataGridViewTextBoxColumn
            // 
            this.staffPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Staff_Phone_No";
            this.staffPhoneNoDataGridViewTextBoxColumn.HeaderText = "Staff_Phone_No";
            this.staffPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffPhoneNoDataGridViewTextBoxColumn.Name = "staffPhoneNoDataGridViewTextBoxColumn";
            this.staffPhoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffAddressDataGridViewTextBoxColumn
            // 
            this.staffAddressDataGridViewTextBoxColumn.DataPropertyName = "Staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.HeaderText = "Staff_Address";
            this.staffAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.staffAddressDataGridViewTextBoxColumn.Name = "staffAddressDataGridViewTextBoxColumn";
            this.staffAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.dSStaff;
            // 
            // dSStaff
            // 
            this.dSStaff.DataSetName = "DSStaff";
            this.dSStaff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddEmployeebutton
            // 
            this.AddEmployeebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddEmployeebutton.Location = new System.Drawing.Point(555, 369);
            this.AddEmployeebutton.Name = "AddEmployeebutton";
            this.AddEmployeebutton.Size = new System.Drawing.Size(145, 51);
            this.AddEmployeebutton.TabIndex = 3;
            this.AddEmployeebutton.Text = "ADD";
            this.AddEmployeebutton.UseVisualStyleBackColor = false;
            this.AddEmployeebutton.Click += new System.EventHandler(this.AddEmployeebutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staff Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Staff Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Staff Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Staff Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 545);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Staff Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Staff Address";
            // 
            // StaffRoletextBox
            // 
            this.StaffRoletextBox.Location = new System.Drawing.Point(168, 369);
            this.StaffRoletextBox.Name = "StaffRoletextBox";
            this.StaffRoletextBox.Size = new System.Drawing.Size(214, 22);
            this.StaffRoletextBox.TabIndex = 12;
            // 
            // StaffFirstNametextBox
            // 
            this.StaffFirstNametextBox.Location = new System.Drawing.Point(168, 397);
            this.StaffFirstNametextBox.Name = "StaffFirstNametextBox";
            this.StaffFirstNametextBox.Size = new System.Drawing.Size(214, 22);
            this.StaffFirstNametextBox.TabIndex = 13;
            // 
            // StaffLastNametextBox
            // 
            this.StaffLastNametextBox.Location = new System.Drawing.Point(168, 430);
            this.StaffLastNametextBox.Name = "StaffLastNametextBox";
            this.StaffLastNametextBox.Size = new System.Drawing.Size(214, 22);
            this.StaffLastNametextBox.TabIndex = 14;
            // 
            // StaffUsernametextBox
            // 
            this.StaffUsernametextBox.Location = new System.Drawing.Point(168, 455);
            this.StaffUsernametextBox.Name = "StaffUsernametextBox";
            this.StaffUsernametextBox.Size = new System.Drawing.Size(214, 22);
            this.StaffUsernametextBox.TabIndex = 15;
            // 
            // StaffPasswordtextBox
            // 
            this.StaffPasswordtextBox.Location = new System.Drawing.Point(168, 489);
            this.StaffPasswordtextBox.Name = "StaffPasswordtextBox";
            this.StaffPasswordtextBox.Size = new System.Drawing.Size(214, 22);
            this.StaffPasswordtextBox.TabIndex = 16;
            // 
            // StaffAgetextBox
            // 
            this.StaffAgetextBox.Location = new System.Drawing.Point(168, 517);
            this.StaffAgetextBox.Name = "StaffAgetextBox";
            this.StaffAgetextBox.Size = new System.Drawing.Size(214, 22);
            this.StaffAgetextBox.TabIndex = 17;
            // 
            // StaffAddresstextBox
            // 
            this.StaffAddresstextBox.Location = new System.Drawing.Point(166, 573);
            this.StaffAddresstextBox.Name = "StaffAddresstextBox";
            this.StaffAddresstextBox.Size = new System.Drawing.Size(216, 22);
            this.StaffAddresstextBox.TabIndex = 19;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(168, 545);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(214, 22);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // UpdateEmployeebutton
            // 
            this.UpdateEmployeebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateEmployeebutton.Location = new System.Drawing.Point(555, 544);
            this.UpdateEmployeebutton.Name = "UpdateEmployeebutton";
            this.UpdateEmployeebutton.Size = new System.Drawing.Size(145, 51);
            this.UpdateEmployeebutton.TabIndex = 22;
            this.UpdateEmployeebutton.Text = "UPDATE";
            this.UpdateEmployeebutton.UseVisualStyleBackColor = false;
            this.UpdateEmployeebutton.Click += new System.EventHandler(this.UpdateEmployeebutton_Click_1);
            // 
            // FormSTAFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1622, 668);
            this.Controls.Add(this.UpdateEmployeebutton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.StaffAddresstextBox);
            this.Controls.Add(this.StaffAgetextBox);
            this.Controls.Add(this.StaffPasswordtextBox);
            this.Controls.Add(this.StaffUsernametextBox);
            this.Controls.Add(this.StaffLastNametextBox);
            this.Controls.Add(this.StaffFirstNametextBox);
            this.Controls.Add(this.StaffRoletextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddEmployeebutton);
            this.Controls.Add(this.EmployeedataGridView);
            this.Controls.Add(this.SearchStafftextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormSTAFF";
            this.Text = "FormSTAFF";
            this.Load += new System.EventHandler(this.FormSTAFF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchStafftextBox;
        private System.Windows.Forms.DataGridView EmployeedataGridView;
        private System.Windows.Forms.Button AddEmployeebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StaffRoletextBox;
        private System.Windows.Forms.TextBox StaffFirstNametextBox;
        private System.Windows.Forms.TextBox StaffLastNametextBox;
        private System.Windows.Forms.TextBox StaffUsernametextBox;
        private System.Windows.Forms.TextBox StaffPasswordtextBox;
        private System.Windows.Forms.TextBox StaffAgetextBox;
        private System.Windows.Forms.TextBox StaffAddresstextBox;
        private DSStaff dSStaff;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DSStaffTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button UpdateEmployeebutton;
    }
}