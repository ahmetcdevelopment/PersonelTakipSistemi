namespace PDSK
{
    partial class FrmShift
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
            this.tbxSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgwShift = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSfiftName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxEndTime = new System.Windows.Forms.TextBox();
            this.tbxStartTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShift)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearchEmployee
            // 
            this.tbxSearchEmployee.Location = new System.Drawing.Point(279, 34);
            this.tbxSearchEmployee.Name = "tbxSearchEmployee";
            this.tbxSearchEmployee.Size = new System.Drawing.Size(513, 23);
            this.tbxSearchEmployee.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(376, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgwShift
            // 
            this.dgwShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShift.Location = new System.Drawing.Point(279, 66);
            this.dgwShift.Name = "dgwShift";
            this.dgwShift.RowTemplate.Height = 25;
            this.dgwShift.Size = new System.Drawing.Size(513, 321);
            this.dgwShift.TabIndex = 25;
            this.dgwShift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwShift_CellContentClick);
            this.dgwShift.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwShift_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vardiya";
            // 
            // tbxSfiftName
            // 
            this.tbxSfiftName.Location = new System.Drawing.Point(101, 74);
            this.tbxSfiftName.Name = "tbxSfiftName";
            this.tbxSfiftName.Size = new System.Drawing.Size(100, 23);
            this.tbxSfiftName.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 23);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxEndTime
            // 
            this.tbxEndTime.Location = new System.Drawing.Point(101, 132);
            this.tbxEndTime.Name = "tbxEndTime";
            this.tbxEndTime.Size = new System.Drawing.Size(100, 23);
            this.tbxEndTime.TabIndex = 29;
            // 
            // tbxStartTime
            // 
            this.tbxStartTime.Location = new System.Drawing.Point(101, 103);
            this.tbxStartTime.Name = "tbxStartTime";
            this.tbxStartTime.Size = new System.Drawing.Size(100, 23);
            this.tbxStartTime.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Bitiş Zamanı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Başlama Zamanı";
            // 
            // FrmShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxStartTime);
            this.Controls.Add(this.tbxEndTime);
            this.Controls.Add(this.tbxSearchEmployee);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgwShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSfiftName);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmShift";
            this.Text = "FrmShift";
            this.Load += new System.EventHandler(this.FrmShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearchEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgwShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSfiftName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxEndTime;
        private System.Windows.Forms.TextBox tbxStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}