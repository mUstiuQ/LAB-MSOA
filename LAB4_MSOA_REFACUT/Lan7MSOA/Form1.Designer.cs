namespace Lan7MSOA
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
            this.components = new System.ComponentModel.Container();
            this.dbDataSet = new Lan7MSOA.DbDataSet();
            this.pacientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientTableAdapter = new Lan7MSOA.DbDataSetTableAdapters.PacientTableAdapter();
            this.tableAdapterManager = new Lan7MSOA.DbDataSetTableAdapters.TableAdapterManager();
            this.radiografiiTableAdapter = new Lan7MSOA.DbDataSetTableAdapters.RadiografiiTableAdapter();
            this.pacientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiografiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radiografiiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCautare = new System.Windows.Forms.TextBox();
            this.buttonCautare = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "DbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientBindingSource
            // 
            this.pacientBindingSource.DataMember = "Pacient";
            this.pacientBindingSource.DataSource = this.dbDataSet;
            // 
            // pacientTableAdapter
            // 
            this.pacientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientTableAdapter = this.pacientTableAdapter;
            this.tableAdapterManager.RadiografiiTableAdapter = this.radiografiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lan7MSOA.DbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radiografiiTableAdapter
            // 
            this.radiografiiTableAdapter.ClearBeforeFill = true;
            // 
            // pacientDataGridView
            // 
            this.pacientDataGridView.AutoGenerateColumns = false;
            this.pacientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.pacientDataGridView.DataSource = this.pacientBindingSource;
            this.pacientDataGridView.Location = new System.Drawing.Point(12, 53);
            this.pacientDataGridView.Name = "pacientDataGridView";
            this.pacientDataGridView.Size = new System.Drawing.Size(346, 309);
            this.pacientDataGridView.TabIndex = 1;
            this.pacientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacientDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CNP";
            this.dataGridViewTextBoxColumn1.HeaderText = "CNP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // radiografiiBindingSource
            // 
            this.radiografiiBindingSource.DataMember = "Radiografii";
            this.radiografiiBindingSource.DataSource = this.dbDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvare Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pacientBindingNavigatorSaveItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(383, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 391);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // radiografiiBindingSource1
            // 
            this.radiografiiBindingSource1.DataMember = "FK__Radiografii__CNP__3A81B327";
            this.radiografiiBindingSource1.DataSource = this.pacientBindingSource;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Adauga Diagnoza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cauta dupa nume";
            // 
            // textBoxCautare
            // 
            this.textBoxCautare.Location = new System.Drawing.Point(107, 22);
            this.textBoxCautare.Name = "textBoxCautare";
            this.textBoxCautare.Size = new System.Drawing.Size(202, 20);
            this.textBoxCautare.TabIndex = 6;
            // 
            // buttonCautare
            // 
            this.buttonCautare.Location = new System.Drawing.Point(315, 20);
            this.buttonCautare.Name = "buttonCautare";
            this.buttonCautare.Size = new System.Drawing.Size(42, 23);
            this.buttonCautare.TabIndex = 7;
            this.buttonCautare.Text = "OK";
            this.buttonCautare.UseVisualStyleBackColor = true;
            this.buttonCautare.Click += new System.EventHandler(this.buttonCautare_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(616, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(227, 242);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(616, 269);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 106);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 415);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.buttonCautare);
            this.Controls.Add(this.textBoxCautare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pacientDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource pacientBindingSource;
        private DbDataSetTableAdapters.PacientTableAdapter pacientTableAdapter;
        private DbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView pacientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DbDataSetTableAdapters.RadiografiiTableAdapter radiografiiTableAdapter;
        private System.Windows.Forms.BindingSource radiografiiBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource radiografiiBindingSource1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCautare;
        private System.Windows.Forms.Button buttonCautare;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

