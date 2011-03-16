namespace WinFormsRailsClientDemo
{
    partial class PatientsForm
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
            this.dgPatients = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smoker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPatients = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSmoker = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPatients
            // 
            this.dgPatients.AllowUserToAddRows = false;
            this.dgPatients.AllowUserToDeleteRows = false;
            this.dgPatients.AllowUserToResizeColumns = false;
            this.dgPatients.AllowUserToResizeRows = false;
            this.dgPatients.AutoGenerateColumns = false;
            this.dgPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.smoker});
            this.dgPatients.DataSource = this.bsPatients;
            this.dgPatients.Location = new System.Drawing.Point(15, 12);
            this.dgPatients.MultiSelect = false;
            this.dgPatients.Name = "dgPatients";
            this.dgPatients.ReadOnly = true;
            this.dgPatients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPatients.Size = new System.Drawing.Size(584, 236);
            this.dgPatients.TabIndex = 0;
            this.dgPatients.SelectionChanged += new System.EventHandler(this.dgPatients_SelectionChanged);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 170;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 170;
            // 
            // smoker
            // 
            this.smoker.DataPropertyName = "smoker";
            this.smoker.HeaderText = "Smoker";
            this.smoker.Name = "smoker";
            this.smoker.ReadOnly = true;
            this.smoker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.smoker.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.smoker.Width = 170;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(107, 409);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 409);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 280);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(145, 20);
            this.tbName.TabIndex = 3;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(12, 328);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(145, 20);
            this.tbAge.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "&Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "&Age";
            // 
            // cbSmoker
            // 
            this.cbSmoker.AutoSize = true;
            this.cbSmoker.Location = new System.Drawing.Point(12, 366);
            this.cbSmoker.Name = "cbSmoker";
            this.cbSmoker.Size = new System.Drawing.Size(62, 17);
            this.cbSmoker.TabIndex = 7;
            this.cbSmoker.Text = "&Smoker";
            this.cbSmoker.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(211, 409);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 444);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.cbSmoker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgPatients);
            this.Name = "PatientsForm";
            this.Text = "RailsClient WinForms Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dgPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPatients;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSmoker;
        private System.Windows.Forms.BindingSource bsPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn smoker;
        private System.Windows.Forms.Button btnCreate;
    }
}

