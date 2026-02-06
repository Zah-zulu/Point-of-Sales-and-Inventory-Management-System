
namespace Major_project_M2
{
    partial class FormPRODUCTS
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
            this.SearchProducttextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prodBarcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodChargeVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuantityAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodReorderThresholdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g10wst2024DataSet = new Major_project_M2.G10wst2024DataSet();
            this.productTableAdapter = new Major_project_M2.G10wst2024DataSetTableAdapters.ProductTableAdapter();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSManager = new Major_project_M2.DSManager();
            this.productTableAdapter1 = new Major_project_M2.DSManagerTableAdapters.ProductTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addnewproduct = new System.Windows.Forms.Button();
            this.labelSupplierId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g10wst2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSManager)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Product Name";
            // 
            // SearchProducttextBox
            // 
            this.SearchProducttextBox.Location = new System.Drawing.Point(188, 24);
            this.SearchProducttextBox.Name = "SearchProducttextBox";
            this.SearchProducttextBox.Size = new System.Drawing.Size(329, 22);
            this.SearchProducttextBox.TabIndex = 1;
            this.SearchProducttextBox.TextChanged += new System.EventHandler(this.SearchProducttextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodBarcodeDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.prodDescriptionDataGridViewTextBoxColumn,
            this.prodPriceDataGridViewTextBoxColumn,
            this.prodChargeVATDataGridViewTextBoxColumn,
            this.prodQuantityAvailableDataGridViewTextBoxColumn,
            this.prodReorderThresholdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1093, 306);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // prodBarcodeDataGridViewTextBoxColumn
            // 
            this.prodBarcodeDataGridViewTextBoxColumn.DataPropertyName = "Prod_Barcode";
            this.prodBarcodeDataGridViewTextBoxColumn.HeaderText = "Prod_Barcode";
            this.prodBarcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodBarcodeDataGridViewTextBoxColumn.Name = "prodBarcodeDataGridViewTextBoxColumn";
            this.prodBarcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodBarcodeDataGridViewTextBoxColumn.Width = 128;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 110;
            // 
            // prodDescriptionDataGridViewTextBoxColumn
            // 
            this.prodDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Prod_Description";
            this.prodDescriptionDataGridViewTextBoxColumn.HeaderText = "Prod_Description";
            this.prodDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodDescriptionDataGridViewTextBoxColumn.Name = "prodDescriptionDataGridViewTextBoxColumn";
            this.prodDescriptionDataGridViewTextBoxColumn.Width = 146;
            // 
            // prodPriceDataGridViewTextBoxColumn
            // 
            this.prodPriceDataGridViewTextBoxColumn.DataPropertyName = "Prod_Price";
            this.prodPriceDataGridViewTextBoxColumn.HeaderText = "Prod_Price";
            this.prodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodPriceDataGridViewTextBoxColumn.Name = "prodPriceDataGridViewTextBoxColumn";
            this.prodPriceDataGridViewTextBoxColumn.Width = 107;
            // 
            // prodChargeVATDataGridViewTextBoxColumn
            // 
            this.prodChargeVATDataGridViewTextBoxColumn.DataPropertyName = "Prod_Charge_VAT";
            this.prodChargeVATDataGridViewTextBoxColumn.HeaderText = "Prod_Charge_VAT";
            this.prodChargeVATDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodChargeVATDataGridViewTextBoxColumn.Name = "prodChargeVATDataGridViewTextBoxColumn";
            this.prodChargeVATDataGridViewTextBoxColumn.Width = 156;
            // 
            // prodQuantityAvailableDataGridViewTextBoxColumn
            // 
            this.prodQuantityAvailableDataGridViewTextBoxColumn.DataPropertyName = "Prod_Quantity_Available";
            this.prodQuantityAvailableDataGridViewTextBoxColumn.HeaderText = "Prod_Quantity_Available";
            this.prodQuantityAvailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodQuantityAvailableDataGridViewTextBoxColumn.Name = "prodQuantityAvailableDataGridViewTextBoxColumn";
            this.prodQuantityAvailableDataGridViewTextBoxColumn.Width = 193;
            // 
            // prodReorderThresholdDataGridViewTextBoxColumn
            // 
            this.prodReorderThresholdDataGridViewTextBoxColumn.DataPropertyName = "Prod_Reorder_Threshold";
            this.prodReorderThresholdDataGridViewTextBoxColumn.HeaderText = "Prod_Reorder_Threshold";
            this.prodReorderThresholdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodReorderThresholdDataGridViewTextBoxColumn.Name = "prodReorderThresholdDataGridViewTextBoxColumn";
            this.prodReorderThresholdDataGridViewTextBoxColumn.Width = 199;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.g10wst2024DataSet;
            // 
            // g10wst2024DataSet
            // 
            this.g10wst2024DataSet.DataSetName = "G10wst2024DataSet";
            this.g10wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.dSManager;
            // 
            // dSManager
            // 
            this.dSManager.DataSetName = "DSManager";
            this.dSManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(609, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(137, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product charged VAT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product QTY Avail:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(609, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(136, 22);
            this.textBox5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Product Reorder threshold:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.addnewproduct);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Location = new System.Drawing.Point(60, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 280);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Products";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(381, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 56);
            this.button2.TabIndex = 17;
            this.button2.Text = "update product";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addnewproduct
            // 
            this.addnewproduct.BackColor = System.Drawing.Color.Cyan;
            this.addnewproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewproduct.Location = new System.Drawing.Point(203, 218);
            this.addnewproduct.Name = "addnewproduct";
            this.addnewproduct.Size = new System.Drawing.Size(181, 56);
            this.addnewproduct.TabIndex = 15;
            this.addnewproduct.Text = "Add new product";
            this.addnewproduct.UseVisualStyleBackColor = false;
            this.addnewproduct.Click += new System.EventHandler(this.addnewproduct_Click);
            // 
            // labelSupplierId
            // 
            this.labelSupplierId.AutoSize = true;
            this.labelSupplierId.Location = new System.Drawing.Point(1050, 39);
            this.labelSupplierId.Name = "labelSupplierId";
            this.labelSupplierId.Size = new System.Drawing.Size(46, 17);
            this.labelSupplierId.TabIndex = 14;
            this.labelSupplierId.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(904, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Selected Supplier ID:";
            // 
            // FormPRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1204, 717);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelSupplierId);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchProducttextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormPRODUCTS";
            this.Text = "FormPRODUCTS";
            this.Load += new System.EventHandler(this.FormPRODUCTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g10wst2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSManager)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchProducttextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private G10wst2024DataSet g10wst2024DataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private G10wst2024DataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private DSManager dSManager;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private DSManagerTableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSupplierId;
        private System.Windows.Forms.Button addnewproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodBarcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodChargeVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuantityAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodReorderThresholdDataGridViewTextBoxColumn;
    }
}