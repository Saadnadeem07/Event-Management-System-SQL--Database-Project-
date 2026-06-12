using System;
using System.Windows.Forms;

namespace project2
{
    partial class view_events
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eVENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTTIMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOCATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eVENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new project2.DataSet1();
            this.eVENTTableAdapter = new project2.DataSet1TableAdapters.EVENTTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eVENTIDDataGridViewTextBoxColumn,
            this.eVENTNAMEDataGridViewTextBoxColumn,
            this.eVENTDATEDataGridViewTextBoxColumn,
            this.eVENTTIMEDataGridViewTextBoxColumn,
            this.lOCATIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eVENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(91, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eVENTIDDataGridViewTextBoxColumn
            // 
            this.eVENTIDDataGridViewTextBoxColumn.DataPropertyName = "EVENT_ID";
            this.eVENTIDDataGridViewTextBoxColumn.HeaderText = "EVENT_ID";
            this.eVENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTIDDataGridViewTextBoxColumn.Name = "eVENTIDDataGridViewTextBoxColumn";
            this.eVENTIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // eVENTNAMEDataGridViewTextBoxColumn
            // 
            this.eVENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "EVENTNAME";
            this.eVENTNAMEDataGridViewTextBoxColumn.HeaderText = "EVENTNAME";
            this.eVENTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTNAMEDataGridViewTextBoxColumn.Name = "eVENTNAMEDataGridViewTextBoxColumn";
            this.eVENTNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eVENTDATEDataGridViewTextBoxColumn
            // 
            this.eVENTDATEDataGridViewTextBoxColumn.DataPropertyName = "EVENT_DATE";
            this.eVENTDATEDataGridViewTextBoxColumn.HeaderText = "EVENT_DATE";
            this.eVENTDATEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTDATEDataGridViewTextBoxColumn.Name = "eVENTDATEDataGridViewTextBoxColumn";
            this.eVENTDATEDataGridViewTextBoxColumn.Width = 125;
            // 
            // eVENTTIMEDataGridViewTextBoxColumn
            // 
            this.eVENTTIMEDataGridViewTextBoxColumn.DataPropertyName = "EVENT_TIME";
            this.eVENTTIMEDataGridViewTextBoxColumn.HeaderText = "EVENT_TIME";
            this.eVENTTIMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eVENTTIMEDataGridViewTextBoxColumn.Name = "eVENTTIMEDataGridViewTextBoxColumn";
            this.eVENTTIMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // lOCATIONDataGridViewTextBoxColumn
            // 
            this.lOCATIONDataGridViewTextBoxColumn.DataPropertyName = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.HeaderText = "LOCATION";
            this.lOCATIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOCATIONDataGridViewTextBoxColumn.Name = "lOCATIONDataGridViewTextBoxColumn";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(130, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generate Event Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(216, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 44);
            this.button3.TabIndex = 32;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(581, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "view_events";
            this.Text = "view_events";
            this.Load += new System.EventHandler(this.view_events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource eVENTBindingSource;
        private DataSet1TableAdapters.EVENTTableAdapter eVENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eVENTTIMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOCATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private Button button1;
    }
}