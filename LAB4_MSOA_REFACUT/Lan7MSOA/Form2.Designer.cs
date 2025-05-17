namespace Lan7MSOA
{
    partial class Form2
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
            System.Windows.Forms.Label cNPLabel;
            System.Windows.Forms.Label imagineLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label diagnosticLabel;
            System.Windows.Forms.Label comentariiLabel;
            this.dbDataSet = new Lan7MSOA.DbDataSet();
            this.radiografiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radiografiiTableAdapter = new Lan7MSOA.DbDataSetTableAdapters.RadiografiiTableAdapter();
            this.tableAdapterManager = new Lan7MSOA.DbDataSetTableAdapters.TableAdapterManager();
            this.cNPTextBox = new System.Windows.Forms.TextBox();
            this.imagineTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.diagnosticTextBox = new System.Windows.Forms.TextBox();
            this.comentariiTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            cNPLabel = new System.Windows.Forms.Label();
            imagineLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            diagnosticLabel = new System.Windows.Forms.Label();
            comentariiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cNPLabel
            // 
            cNPLabel.AutoSize = true;
            cNPLabel.Location = new System.Drawing.Point(14, 23);
            cNPLabel.Name = "cNPLabel";
            cNPLabel.Size = new System.Drawing.Size(32, 13);
            cNPLabel.TabIndex = 3;
            cNPLabel.Text = "CNP:";
            // 
            // imagineLabel
            // 
            imagineLabel.AutoSize = true;
            imagineLabel.Location = new System.Drawing.Point(14, 49);
            imagineLabel.Name = "imagineLabel";
            imagineLabel.Size = new System.Drawing.Size(47, 13);
            imagineLabel.TabIndex = 5;
            imagineLabel.Text = "Imagine:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(14, 76);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(33, 13);
            dataLabel.TabIndex = 7;
            dataLabel.Text = "Data:";
            // 
            // diagnosticLabel
            // 
            diagnosticLabel.AutoSize = true;
            diagnosticLabel.Location = new System.Drawing.Point(14, 101);
            diagnosticLabel.Name = "diagnosticLabel";
            diagnosticLabel.Size = new System.Drawing.Size(60, 13);
            diagnosticLabel.TabIndex = 9;
            diagnosticLabel.Text = "Diagnostic:";
            // 
            // comentariiLabel
            // 
            comentariiLabel.AutoSize = true;
            comentariiLabel.Location = new System.Drawing.Point(14, 127);
            comentariiLabel.Name = "comentariiLabel";
            comentariiLabel.Size = new System.Drawing.Size(59, 13);
            comentariiLabel.TabIndex = 11;
            comentariiLabel.Text = "Comentarii:";
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "DbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radiografiiBindingSource
            // 
            this.radiografiiBindingSource.DataMember = "Radiografii";
            this.radiografiiBindingSource.DataSource = this.dbDataSet;
            // 
            // radiografiiTableAdapter
            // 
            this.radiografiiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacientTableAdapter = null;
            this.tableAdapterManager.RadiografiiTableAdapter = this.radiografiiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lan7MSOA.DbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cNPTextBox
            // 
            this.cNPTextBox.Location = new System.Drawing.Point(80, 20);
            this.cNPTextBox.Name = "cNPTextBox";
            this.cNPTextBox.Size = new System.Drawing.Size(200, 20);
            this.cNPTextBox.TabIndex = 4;
            // 
            // imagineTextBox
            // 
            this.imagineTextBox.Location = new System.Drawing.Point(80, 46);
            this.imagineTextBox.Name = "imagineTextBox";
            this.imagineTextBox.Size = new System.Drawing.Size(200, 20);
            this.imagineTextBox.TabIndex = 6;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Location = new System.Drawing.Point(80, 72);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 8;
            // 
            // diagnosticTextBox
            // 
            this.diagnosticTextBox.Location = new System.Drawing.Point(80, 98);
            this.diagnosticTextBox.Multiline = true;
            this.diagnosticTextBox.Name = "diagnosticTextBox";
            this.diagnosticTextBox.Size = new System.Drawing.Size(200, 20);
            this.diagnosticTextBox.TabIndex = 10;
            // 
            // comentariiTextBox
            // 
            this.comentariiTextBox.Location = new System.Drawing.Point(80, 124);
            this.comentariiTextBox.Name = "comentariiTextBox";
            this.comentariiTextBox.Size = new System.Drawing.Size(200, 20);
            this.comentariiTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Adaugare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(164, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Revocare";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 202);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(cNPLabel);
            this.Controls.Add(this.cNPTextBox);
            this.Controls.Add(imagineLabel);
            this.Controls.Add(this.imagineTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(diagnosticLabel);
            this.Controls.Add(this.diagnosticTextBox);
            this.Controls.Add(comentariiLabel);
            this.Controls.Add(this.comentariiTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiografiiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource radiografiiBindingSource;
        private DbDataSetTableAdapters.RadiografiiTableAdapter radiografiiTableAdapter;
        private DbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cNPTextBox;
        private System.Windows.Forms.TextBox imagineTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.TextBox diagnosticTextBox;
        private System.Windows.Forms.TextBox comentariiTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}