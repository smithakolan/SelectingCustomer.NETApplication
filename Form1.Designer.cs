namespace CustomerSelection
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.rdbCountry = new System.Windows.Forms.RadioButton();
            this.rdbCity = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.northwindDataSet1 = new CustomerSelection.NorthwindDataSet();
            this.tableAdapterManager1 = new CustomerSelection.NorthwindDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter1 = new CustomerSelection.NorthwindDataSetTableAdapters.CustomersTableAdapter();
            this.grpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Name of The Country Or City";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpBox
            // 
            this.grpBox.Controls.Add(this.rdbCity);
            this.grpBox.Controls.Add(this.rdbCountry);
            this.grpBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBox.Location = new System.Drawing.Point(93, 88);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(200, 100);
            this.grpBox.TabIndex = 1;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "Filter By";
            // 
            // rdbCountry
            // 
            this.rdbCountry.AutoSize = true;
            this.rdbCountry.Location = new System.Drawing.Point(26, 25);
            this.rdbCountry.Name = "rdbCountry";
            this.rdbCountry.Size = new System.Drawing.Size(86, 22);
            this.rdbCountry.TabIndex = 0;
            this.rdbCountry.TabStop = true;
            this.rdbCountry.Text = "Country";
            this.rdbCountry.UseVisualStyleBackColor = true;
            this.rdbCountry.CheckedChanged += new System.EventHandler(this.rdbCountry_CheckedChanged);
            // 
            // rdbCity
            // 
            this.rdbCity.AutoSize = true;
            this.rdbCity.Location = new System.Drawing.Point(26, 62);
            this.rdbCity.Name = "rdbCity";
            this.rdbCity.Size = new System.Drawing.Size(55, 22);
            this.rdbCity.TabIndex = 1;
            this.rdbCity.TabStop = true;
            this.rdbCity.Text = "City";
            this.rdbCity.UseVisualStyleBackColor = true;
            this.rdbCity.CheckedChanged += new System.EventHandler(this.rdbCity_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(407, 126);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(126, 20);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFilter.Location = new System.Drawing.Point(273, 194);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(189, 31);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.HorizontalScrollbar = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(93, 231);
            this.lstResult.MultiColumn = true;
            this.lstResult.Name = "lstResult";
            this.lstResult.ScrollAlwaysVisible = true;
            this.lstResult.Size = new System.Drawing.Size(601, 244);
            this.lstResult.TabIndex = 4;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "NorthwindDataSet";
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomersTableAdapter = this.customersTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = CustomerSelection.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(858, 498);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.grpBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Filter Customers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBox.ResumeLayout(false);
            this.grpBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox;
        private System.Windows.Forms.RadioButton rdbCity;
        private System.Windows.Forms.RadioButton rdbCountry;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lstResult;
        private NorthwindDataSet northwindDataSet1;
        private NorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private NorthwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
    }
}

