namespace GW_Utility_V3
{
    partial class databaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(databaseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.databaselocation_lbl = new System.Windows.Forms.Label();
            this.databaseversion_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputquery_rtbx = new System.Windows.Forms.RichTextBox();
            this.submitquery_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.error_lbl = new System.Windows.Forms.Label();
            this.queryResults_DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.queryResults_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database";
            // 
            // databaselocation_lbl
            // 
            this.databaselocation_lbl.AutoSize = true;
            this.databaselocation_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaselocation_lbl.Location = new System.Drawing.Point(15, 48);
            this.databaselocation_lbl.Name = "databaselocation_lbl";
            this.databaselocation_lbl.Size = new System.Drawing.Size(152, 20);
            this.databaselocation_lbl.TabIndex = 3;
            this.databaselocation_lbl.Text = "Database Location: ";
            // 
            // databaseversion_lbl
            // 
            this.databaseversion_lbl.AutoSize = true;
            this.databaseversion_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseversion_lbl.Location = new System.Drawing.Point(15, 73);
            this.databaseversion_lbl.Name = "databaseversion_lbl";
            this.databaseversion_lbl.Size = new System.Drawing.Size(67, 20);
            this.databaseversion_lbl.TabIndex = 4;
            this.databaseversion_lbl.Text = "Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "SQL Query";
            // 
            // inputquery_rtbx
            // 
            this.inputquery_rtbx.Location = new System.Drawing.Point(19, 137);
            this.inputquery_rtbx.Name = "inputquery_rtbx";
            this.inputquery_rtbx.Size = new System.Drawing.Size(526, 59);
            this.inputquery_rtbx.TabIndex = 19;
            this.inputquery_rtbx.Text = "";
            // 
            // submitquery_btn
            // 
            this.submitquery_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitquery_btn.Location = new System.Drawing.Point(460, 202);
            this.submitquery_btn.Name = "submitquery_btn";
            this.submitquery_btn.Size = new System.Drawing.Size(85, 32);
            this.submitquery_btn.TabIndex = 20;
            this.submitquery_btn.Text = "Run";
            this.submitquery_btn.UseVisualStyleBackColor = true;
            this.submitquery_btn.Click += new System.EventHandler(this.submitquery_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(16, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(495, 64);
            this.label7.TabIndex = 24;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.Color.Green;
            this.error_lbl.Location = new System.Drawing.Point(20, 199);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(87, 13);
            this.error_lbl.TabIndex = 25;
            this.error_lbl.Text = "That looks good!";
            // 
            // queryResults_DGV
            // 
            this.queryResults_DGV.AllowUserToAddRows = false;
            this.queryResults_DGV.AllowUserToDeleteRows = false;
            this.queryResults_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResults_DGV.Location = new System.Drawing.Point(19, 257);
            this.queryResults_DGV.Name = "queryResults_DGV";
            this.queryResults_DGV.ReadOnly = true;
            this.queryResults_DGV.Size = new System.Drawing.Size(526, 98);
            this.queryResults_DGV.TabIndex = 26;
            // 
            // databaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 432);
            this.Controls.Add(this.queryResults_DGV);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.submitquery_btn);
            this.Controls.Add(this.inputquery_rtbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.databaseversion_lbl);
            this.Controls.Add(this.databaselocation_lbl);
            this.Controls.Add(this.label1);
            this.Name = "databaseForm";
            this.Text = "Database";
            ((System.ComponentModel.ISupportInitialize)(this.queryResults_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label databaselocation_lbl;
        private System.Windows.Forms.Label databaseversion_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox inputquery_rtbx;
        private System.Windows.Forms.Button submitquery_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.DataGridView queryResults_DGV;
    }
}