namespace project2
{
    partial class participant_view
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
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eVENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new project2.DataSet1();
            this.eVENTTableAdapter = new project2.DataSet1TableAdapters.EVENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(680, 573);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 41);
            this.button5.TabIndex = 29;
            this.button5.Text = "Return Main menu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 41);
            this.label1.TabIndex = 26;
            this.label1.Text = "EVENTS LIST ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eVENTIDDataGridViewTextBoxColumn,
            this.eVENTNAMEDataGridViewTextBoxColumn,
            this.eVENTDATEDataGridViewTextBoxColumn,
            this.eVENTTIMEDataGridViewTextBoxColumn,
            this.lOCATIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eVENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 351);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eVENTIDDataGridViewTextBoxColumn
            // 
            this.eVENTIDDataGridViewTextBoxColumn.DataPropertyName = "EVENT_ID";
            this.eVENTIDDataGridViewTextBoxColumn.HeaderText = "EVENT_ID";
            this.eVENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTIDDataGridViewTextBoxColumn.Name = "eVENTIDDataGridViewTextBoxColumn";
            this.eVENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eVENTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eVENTNAMEDataGridViewTextBoxColumn
            // 
            this.eVENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EVENTNAME";
            this.eVENTNAMEDataGridViewTextBoxColumn.HeaderText = "EVENTNAME";
            this.eVENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTNAMEDataGridViewTextBoxColumn.Name = "eVENTNAMEDataGridViewTextBoxColumn";
            this.eVENTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eVENTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eVENTDATEDataGridViewTextBoxColumn
            // 
            this.eVENTDATEDataGridViewTextBoxColumn.DataPropertyName = "EVENT_DATE";
            this.eVENTDATEDataGridViewTextBoxColumn.HeaderText = "EVENT_DATE";
            this.eVENTDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTDATEDataGridViewTextBoxColumn.Name = "eVENTDATEDataGridViewTextBoxColumn";
            this.eVENTDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eVENTDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eVENTTIMEDataGridViewTextBoxColumn
            // 
            this.eVENTTIMEDataGridViewTextBoxColumn.DataPropertyName = "EVENT_TIME";
            this.eVENTTIMEDataGridViewTextBoxColumn.HeaderText = "EVENT_TIME";
            this.eVENTTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTTIMEDataGridViewTextBoxColumn.Name = "eVENTTIMEDataGridViewTextBoxColumn";
            this.eVENTTIMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eVENTTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOCATIONDataGridViewTextBoxColumn
            // 
            this.lOCATIONDataGridViewTextBoxColumn.DataPropertyName = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.HeaderText = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOCATIONDataGridViewTextBoxColumn.Name = "lOCATIONDataGridViewTextBoxColumn";
            this.lOCATIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOCATIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // eVENTBindingSource
            // 
            this.eVENTBindingSource.DataMember = "EVENT";
            this.eVENTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eVENTTableAdapter
            // 
            this.eVENTTableAdapter.ClearBeforeFill = true;
            // 
            // participant_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Name = "participant_view";
            this.Text = "participant_view";
            this.Load += new System.EventHandler(this.participant_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eVENTBindingSource;
        private DataSet1TableAdapters.EVENTTableAdapter eVENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONDataGridViewTextBoxColumn;
    }
}