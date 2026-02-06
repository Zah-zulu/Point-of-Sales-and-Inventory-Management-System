
namespace Major_project_M2
{
    partial class FormSUPPLIER
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
            this.SearchSuppliertextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewsupplier = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierPhoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAccountBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSManager = new Major_project_M2.DSManager();
            this.AddSupplierbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SupplierNametextBox = new System.Windows.Forms.TextBox();
            this.SupplierAddresstextBox = new System.Windows.Forms.TextBox();
            this.SupplierPhoneNumbertextBox = new System.Windows.Forms.TextBox();
            this.SupplierEmailtextBox = new System.Windows.Forms.TextBox();
            this.SupplierAccountBalancetextBox = new System.Windows.Forms.TextBox();
            this.supplierTableAdapter = new Major_project_M2.DSManagerTableAdapters.SupplierTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Supplier Name";
            // 
            // SearchSuppliertextBox
            // 
            this.SearchSuppliertextBox.Location = new System.Drawing.Point(235, 29);
            this.SearchSuppliertextBox.Name = "SearchSuppliertextBox";
            this.SearchSuppliertextBox.Size = new System.Drawing.Size(339, 22);
            this.SearchSuppliertextBox.TabIndex = 1;
            this.SearchSuppliertextBox.TextChanged += new System.EventHandler(this.SearchSuppliertextBox_TextChanged);
            // 
            // dataGridViewsupplier
            // 
            this.dataGridViewsupplier.AutoGenerateColumns = false;
            this.dataGridViewsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierAddressDataGridViewTextBoxColumn,
            this.supplierPhoneNoDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn,
            this.supplierAccountBalanceDataGridViewTextBoxColumn});
            this.dataGridViewsupplier.DataSource = this.supplierBindingSource;
            this.dataGridViewsupplier.Location = new System.Drawing.Point(40, 79);
            this.dataGridViewsupplier.Name = "dataGridViewsupplier";
            this.dataGridViewsupplier.RowHeadersWidth = 51;
            this.dataGridViewsupplier.RowTemplate.Height = 24;
            this.dataGridViewsupplier.Size = new System.Drawing.Size(1048, 213);
            this.dataGridViewsupplier.TabIndex = 2;
            this.dataGridViewsupplier.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewsupplier_RowHeaderMouseClick);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier_Name";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Address";
            this.supplierAddressDataGridViewTextBoxColumn.HeaderText = "Supplier_Address";
            this.supplierAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            this.supplierAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierPhoneNoDataGridViewTextBoxColumn
            // 
            this.supplierPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Phone_No";
            this.supplierPhoneNoDataGridViewTextBoxColumn.HeaderText = "Supplier_Phone_No";
            this.supplierPhoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierPhoneNoDataGridViewTextBoxColumn.Name = "supplierPhoneNoDataGridViewTextBoxColumn";
            this.supplierPhoneNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Email";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "Supplier_Email";
            this.supplierEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            this.supplierEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierAccountBalanceDataGridViewTextBoxColumn
            // 
            this.supplierAccountBalanceDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Account_Balance";
            this.supplierAccountBalanceDataGridViewTextBoxColumn.HeaderText = "Supplier_Account_Balance";
            this.supplierAccountBalanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierAccountBalanceDataGridViewTextBoxColumn.Name = "supplierAccountBalanceDataGridViewTextBoxColumn";
            this.supplierAccountBalanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.dSManager;
            // 
            // dSManager
            // 
            this.dSManager.DataSetName = "DSManager";
            this.dSManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddSupplierbutton
            // 
            this.AddSupplierbutton.BackColor = System.Drawing.Color.Cyan;
            this.AddSupplierbutton.Location = new System.Drawing.Point(962, 357);
            this.AddSupplierbutton.Name = "AddSupplierbutton";
            this.AddSupplierbutton.Size = new System.Drawing.Size(126, 51);
            this.AddSupplierbutton.TabIndex = 3;
            this.AddSupplierbutton.Text = "Add New Supplier";
            this.AddSupplierbutton.UseVisualStyleBackColor = false;
            this.AddSupplierbutton.Click += new System.EventHandler(this.AddSupplierbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Supplier Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supplier Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Supplier Account Balance";
            // 
            // SupplierNametextBox
            // 
            this.SupplierNametextBox.Location = new System.Drawing.Point(235, 342);
            this.SupplierNametextBox.Name = "SupplierNametextBox";
            this.SupplierNametextBox.Size = new System.Drawing.Size(355, 22);
            this.SupplierNametextBox.TabIndex = 9;
            // 
            // SupplierAddresstextBox
            // 
            this.SupplierAddresstextBox.Location = new System.Drawing.Point(235, 391);
            this.SupplierAddresstextBox.Name = "SupplierAddresstextBox";
            this.SupplierAddresstextBox.Size = new System.Drawing.Size(355, 22);
            this.SupplierAddresstextBox.TabIndex = 10;
            // 
            // SupplierPhoneNumbertextBox
            // 
            this.SupplierPhoneNumbertextBox.Location = new System.Drawing.Point(235, 432);
            this.SupplierPhoneNumbertextBox.Name = "SupplierPhoneNumbertextBox";
            this.SupplierPhoneNumbertextBox.Size = new System.Drawing.Size(355, 22);
            this.SupplierPhoneNumbertextBox.TabIndex = 11;
            // 
            // SupplierEmailtextBox
            // 
            this.SupplierEmailtextBox.Location = new System.Drawing.Point(235, 480);
            this.SupplierEmailtextBox.Name = "SupplierEmailtextBox";
            this.SupplierEmailtextBox.Size = new System.Drawing.Size(355, 22);
            this.SupplierEmailtextBox.TabIndex = 12;
            // 
            // SupplierAccountBalancetextBox
            // 
            this.SupplierAccountBalancetextBox.Location = new System.Drawing.Point(235, 520);
            this.SupplierAccountBalancetextBox.Name = "SupplierAccountBalancetextBox";
            this.SupplierAccountBalancetextBox.Size = new System.Drawing.Size(355, 22);
            this.SupplierAccountBalancetextBox.TabIndex = 13;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(962, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add New Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1116, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(970, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Selected Supplier ID:";
            // 
            // FormSUPPLIER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1234, 590);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SupplierAccountBalancetextBox);
            this.Controls.Add(this.SupplierEmailtextBox);
            this.Controls.Add(this.SupplierPhoneNumbertextBox);
            this.Controls.Add(this.SupplierAddresstextBox);
            this.Controls.Add(this.SupplierNametextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddSupplierbutton);
            this.Controls.Add(this.dataGridViewsupplier);
            this.Controls.Add(this.SearchSuppliertextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormSUPPLIER";
            this.Text = "FormSUPPLIER";
            this.Load += new System.EventHandler(this.FormSUPPLIER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchSuppliertextBox;
        private System.Windows.Forms.DataGridView dataGridViewsupplier;
        private System.Windows.Forms.Button AddSupplierbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SupplierNametextBox;
        private System.Windows.Forms.TextBox SupplierAddresstextBox;
        private System.Windows.Forms.TextBox SupplierPhoneNumbertextBox;
        private System.Windows.Forms.TextBox SupplierEmailtextBox;
        private System.Windows.Forms.TextBox SupplierAccountBalancetextBox;
        private DSManager dSManager;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private DSManagerTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierPhoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAccountBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}