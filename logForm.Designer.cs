using Microsoft.Identity.Client;

namespace GW_Utility_V3
{
    partial class logForm
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
            this.logdirectory_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.LogType_tbx = new System.Windows.Forms.TextBox();
            this.LogLevel_tbx = new System.Windows.Forms.TextBox();
            this.LogMessage_tbx = new System.Windows.Forms.TextBox();
            this.LogTimestamp_tbx = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logdirectory_lbl
            // 
            this.logdirectory_lbl.AutoSize = true;
            this.logdirectory_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logdirectory_lbl.Location = new System.Drawing.Point(15, 78);
            this.logdirectory_lbl.Name = "logdirectory_lbl";
            this.logdirectory_lbl.Size = new System.Drawing.Size(107, 20);
            this.logdirectory_lbl.TabIndex = 2;
            this.logdirectory_lbl.Text = "Log Directory:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose log file:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Filter by:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(403, 459);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 32);
            this.button4.TabIndex = 13;
            this.button4.Text = "Filter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LogType_tbx
            // 
            this.LogType_tbx.Location = new System.Drawing.Point(138, 177);
            this.LogType_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.LogType_tbx.Name = "LogType_tbx";
            this.LogType_tbx.Size = new System.Drawing.Size(189, 20);
            this.LogType_tbx.TabIndex = 14;
            // 
            // LogLevel_tbx
            // 
            this.LogLevel_tbx.Location = new System.Drawing.Point(138, 237);
            this.LogLevel_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.LogLevel_tbx.Name = "LogLevel_tbx";
            this.LogLevel_tbx.Size = new System.Drawing.Size(189, 20);
            this.LogLevel_tbx.TabIndex = 15;
            // 
            // LogMessage_tbx
            // 
            this.LogMessage_tbx.Location = new System.Drawing.Point(356, 177);
            this.LogMessage_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.LogMessage_tbx.Name = "LogMessage_tbx";
            this.LogMessage_tbx.Size = new System.Drawing.Size(189, 20);
            this.LogMessage_tbx.TabIndex = 16;
            // 
            // LogTimestamp_tbx
            // 
            this.LogTimestamp_tbx.Location = new System.Drawing.Point(356, 237);
            this.LogTimestamp_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.LogTimestamp_tbx.Name = "LogTimestamp_tbx";
            this.LogTimestamp_tbx.Size = new System.Drawing.Size(189, 20);
            this.LogTimestamp_tbx.TabIndex = 17;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(526, 163);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Filter by log level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Filter by log date/time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Filter by log message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Filter by log type";
            // 
            // logForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 505);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LogTimestamp_tbx);
            this.Controls.Add(this.LogMessage_tbx);
            this.Controls.Add(this.LogLevel_tbx);
            this.Controls.Add(this.LogType_tbx);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logdirectory_lbl);
            this.Name = "logForm";
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.logForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logdirectory_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox LogType_tbx;
        private System.Windows.Forms.TextBox LogLevel_tbx;
        private System.Windows.Forms.TextBox LogMessage_tbx;
        private System.Windows.Forms.TextBox LogTimestamp_tbx;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}