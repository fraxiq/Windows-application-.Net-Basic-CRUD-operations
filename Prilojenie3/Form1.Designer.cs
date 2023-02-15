
namespace Prilojenie3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.градDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.населениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пощенскиКодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кметDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.бюджетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database4DataSet = new Prilojenie3.Database4DataSet();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaselenie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKmet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.database4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradoveTableAdapter = new Prilojenie3.Database4DataSetTableAdapters.GradoveTableAdapter();
            this.database4DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.градDataGridViewTextBoxColumn,
            this.населениеDataGridViewTextBoxColumn,
            this.пощенскиКодDataGridViewTextBoxColumn,
            this.кметDataGridViewTextBoxColumn,
            this.бюджетDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradoveBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(97, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 156);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // градDataGridViewTextBoxColumn
            // 
            this.градDataGridViewTextBoxColumn.DataPropertyName = "Град";
            this.градDataGridViewTextBoxColumn.HeaderText = "Град";
            this.градDataGridViewTextBoxColumn.Name = "градDataGridViewTextBoxColumn";
            // 
            // населениеDataGridViewTextBoxColumn
            // 
            this.населениеDataGridViewTextBoxColumn.DataPropertyName = "Население";
            this.населениеDataGridViewTextBoxColumn.HeaderText = "Население";
            this.населениеDataGridViewTextBoxColumn.Name = "населениеDataGridViewTextBoxColumn";
            // 
            // пощенскиКодDataGridViewTextBoxColumn
            // 
            this.пощенскиКодDataGridViewTextBoxColumn.DataPropertyName = "Пощенски код";
            this.пощенскиКодDataGridViewTextBoxColumn.HeaderText = "Пощенски код";
            this.пощенскиКодDataGridViewTextBoxColumn.Name = "пощенскиКодDataGridViewTextBoxColumn";
            // 
            // кметDataGridViewTextBoxColumn
            // 
            this.кметDataGridViewTextBoxColumn.DataPropertyName = "Кмет";
            this.кметDataGridViewTextBoxColumn.HeaderText = "Кмет";
            this.кметDataGridViewTextBoxColumn.Name = "кметDataGridViewTextBoxColumn";
            // 
            // бюджетDataGridViewTextBoxColumn
            // 
            this.бюджетDataGridViewTextBoxColumn.DataPropertyName = "Бюджет";
            this.бюджетDataGridViewTextBoxColumn.HeaderText = "Бюджет";
            this.бюджетDataGridViewTextBoxColumn.Name = "бюджетDataGridViewTextBoxColumn";
            // 
            // gradoveBindingSource
            // 
            this.gradoveBindingSource.DataMember = "Gradove";
            this.gradoveBindingSource.DataSource = this.database4DataSet;
            // 
            // database4DataSet
            // 
            this.database4DataSet.DataSetName = "Database4DataSet";
            this.database4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(259, 234);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(634, 36);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(107, 23);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read (Search)";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(381, 234);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(498, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(97, 231);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(100, 20);
            this.txtGrad.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Град";
            // 
            // txtNaselenie
            // 
            this.txtNaselenie.Location = new System.Drawing.Point(97, 257);
            this.txtNaselenie.Name = "txtNaselenie";
            this.txtNaselenie.Size = new System.Drawing.Size(100, 20);
            this.txtNaselenie.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Население";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(97, 283);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(100, 20);
            this.txtKod.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пощенски код";
            // 
            // txtKmet
            // 
            this.txtKmet.Location = new System.Drawing.Point(97, 309);
            this.txtKmet.Name = "txtKmet";
            this.txtKmet.Size = new System.Drawing.Size(100, 20);
            this.txtKmet.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Кмет";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(97, 335);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 20);
            this.txtBudget.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Бюджет";
            // 
            // database4DataSetBindingSource
            // 
            this.database4DataSetBindingSource.DataSource = this.database4DataSet;
            this.database4DataSetBindingSource.Position = 0;
            // 
            // gradoveTableAdapter
            // 
            this.gradoveTableAdapter.ClearBeforeFill = true;
            // 
            // database4DataSetBindingSource1
            // 
            this.database4DataSetBindingSource1.DataSource = this.database4DataSet;
            this.database4DataSetBindingSource1.Position = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(214, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(414, 20);
            this.txtSearch.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKmet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaselenie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradoveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database4DataSetBindingSource;
        private Database4DataSet database4DataSet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaselenie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKmet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource gradoveBindingSource;
        private Database4DataSetTableAdapters.GradoveTableAdapter gradoveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn градDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn населениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пощенскиКодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кметDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn бюджетDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource database4DataSetBindingSource1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}

