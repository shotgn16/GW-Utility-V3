namespace GW_Utility_V3
{
    partial class serviceForm
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
            this.fileLocation_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.isAdmin_ckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.startupArgument_tbx = new MaterialSkin.Controls.MaterialTextBox2();
            this.startApp_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.schedulerHelp_btn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // fileLocation_lbl
            // 
            this.fileLocation_lbl.AutoSize = true;
            this.fileLocation_lbl.Depth = 0;
            this.fileLocation_lbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileLocation_lbl.Location = new System.Drawing.Point(21, 82);
            this.fileLocation_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileLocation_lbl.Name = "fileLocation_lbl";
            this.fileLocation_lbl.Size = new System.Drawing.Size(399, 19);
            this.fileLocation_lbl.TabIndex = 0;
            this.fileLocation_lbl.Text = "File Location: C:\\Program Files (x86)\\PaymentGateway\\";
            // 
            // isAdmin_ckbox
            // 
            this.isAdmin_ckbox.AutoSize = true;
            this.isAdmin_ckbox.Depth = 0;
            this.isAdmin_ckbox.Location = new System.Drawing.Point(289, 146);
            this.isAdmin_ckbox.Margin = new System.Windows.Forms.Padding(0);
            this.isAdmin_ckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.isAdmin_ckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.isAdmin_ckbox.Name = "isAdmin_ckbox";
            this.isAdmin_ckbox.ReadOnly = false;
            this.isAdmin_ckbox.Ripple = true;
            this.isAdmin_ckbox.Size = new System.Drawing.Size(131, 37);
            this.isAdmin_ckbox.TabIndex = 1;
            this.isAdmin_ckbox.Text = "Administrator";
            this.isAdmin_ckbox.UseVisualStyleBackColor = true;
            // 
            // startupArgument_tbx
            // 
            this.startupArgument_tbx.AnimateReadOnly = false;
            this.startupArgument_tbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.startupArgument_tbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.startupArgument_tbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startupArgument_tbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.startupArgument_tbx.Depth = 0;
            this.startupArgument_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.startupArgument_tbx.HideSelection = true;
            this.startupArgument_tbx.LeadingIcon = null;
            this.startupArgument_tbx.Location = new System.Drawing.Point(18, 143);
            this.startupArgument_tbx.MaxLength = 32767;
            this.startupArgument_tbx.MouseState = MaterialSkin.MouseState.OUT;
            this.startupArgument_tbx.Name = "startupArgument_tbx";
            this.startupArgument_tbx.PasswordChar = '\0';
            this.startupArgument_tbx.PrefixSuffixText = null;
            this.startupArgument_tbx.ReadOnly = false;
            this.startupArgument_tbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startupArgument_tbx.SelectedText = "";
            this.startupArgument_tbx.SelectionLength = 0;
            this.startupArgument_tbx.SelectionStart = 0;
            this.startupArgument_tbx.ShortcutsEnabled = true;
            this.startupArgument_tbx.Size = new System.Drawing.Size(250, 48);
            this.startupArgument_tbx.TabIndex = 2;
            this.startupArgument_tbx.TabStop = false;
            this.startupArgument_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.startupArgument_tbx.TrailingIcon = null;
            this.startupArgument_tbx.UseSystemPasswordChar = false;
            // 
            // startApp_btn
            // 
            this.startApp_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startApp_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.startApp_btn.Depth = 0;
            this.startApp_btn.HighEmphasis = true;
            this.startApp_btn.Icon = null;
            this.startApp_btn.Location = new System.Drawing.Point(18, 199);
            this.startApp_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startApp_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.startApp_btn.Name = "startApp_btn";
            this.startApp_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.startApp_btn.Size = new System.Drawing.Size(99, 36);
            this.startApp_btn.TabIndex = 4;
            this.startApp_btn.Text = "Start App";
            this.startApp_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.startApp_btn.UseAccentColor = false;
            this.startApp_btn.UseVisualStyleBackColor = true;
            this.startApp_btn.Click += new System.EventHandler(this.startApp_btn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(21, 121);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(141, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Start with argument";
            // 
            // schedulerHelp_btn
            // 
            this.schedulerHelp_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schedulerHelp_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.schedulerHelp_btn.Depth = 0;
            this.schedulerHelp_btn.HighEmphasis = true;
            this.schedulerHelp_btn.Icon = null;
            this.schedulerHelp_btn.Location = new System.Drawing.Point(484, 199);
            this.schedulerHelp_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.schedulerHelp_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.schedulerHelp_btn.Name = "schedulerHelp_btn";
            this.schedulerHelp_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.schedulerHelp_btn.Size = new System.Drawing.Size(77, 36);
            this.schedulerHelp_btn.TabIndex = 7;
            this.schedulerHelp_btn.Text = "What \r\nis this?";
            this.schedulerHelp_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.schedulerHelp_btn.UseAccentColor = false;
            this.schedulerHelp_btn.UseVisualStyleBackColor = true;
            this.schedulerHelp_btn.Click += new System.EventHandler(this.schedulerHelp_btn_Click);
            // 
            // serviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 244);
            this.Controls.Add(this.schedulerHelp_btn);
            this.Controls.Add(this.startApp_btn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.startupArgument_tbx);
            this.Controls.Add(this.isAdmin_ckbox);
            this.Controls.Add(this.fileLocation_lbl);
            this.Name = "serviceForm";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.serviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel fileLocation_lbl;
        private MaterialSkin.Controls.MaterialCheckbox isAdmin_ckbox;
        private MaterialSkin.Controls.MaterialTextBox2 startupArgument_tbx;
        private MaterialSkin.Controls.MaterialButton startApp_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton schedulerHelp_btn;
    }
}