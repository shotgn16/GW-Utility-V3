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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.isAdmin_ckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.startupArgument_tbx = new MaterialSkin.Controls.MaterialTextBox2();
            this.startApp_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.scheduleTask_btn = new MaterialSkin.Controls.MaterialButton();
            this.schedulerHelp_btn = new MaterialSkin.Controls.MaterialButton();
            this.scheduleInterval_tbx = new MaterialSkin.Controls.MaterialTextBox2();
            this.scheduleIntervalType_tbx = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.scheduleAction_cbox = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(399, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "File Location: C:\\Program Files (x86)\\PaymentGateway\\";
            // 
            // isAdmin_ckbox
            // 
            this.isAdmin_ckbox.AutoSize = true;
            this.isAdmin_ckbox.Depth = 0;
            this.isAdmin_ckbox.Location = new System.Drawing.Point(17, 194);
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
            this.startApp_btn.Location = new System.Drawing.Point(169, 195);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(166, 292);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(229, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Schedule Task (Task Scheduler)";
            // 
            // scheduleTask_btn
            // 
            this.scheduleTask_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scheduleTask_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.scheduleTask_btn.Depth = 0;
            this.scheduleTask_btn.HighEmphasis = true;
            this.scheduleTask_btn.Icon = null;
            this.scheduleTask_btn.Location = new System.Drawing.Point(280, 438);
            this.scheduleTask_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.scheduleTask_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.scheduleTask_btn.Name = "scheduleTask_btn";
            this.scheduleTask_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.scheduleTask_btn.Size = new System.Drawing.Size(95, 36);
            this.scheduleTask_btn.TabIndex = 6;
            this.scheduleTask_btn.Text = "Schedule";
            this.scheduleTask_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.scheduleTask_btn.UseAccentColor = false;
            this.scheduleTask_btn.UseVisualStyleBackColor = true;
            this.scheduleTask_btn.Click += new System.EventHandler(this.scheduleTask_btn_Click);
            // 
            // schedulerHelp_btn
            // 
            this.schedulerHelp_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schedulerHelp_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.schedulerHelp_btn.Depth = 0;
            this.schedulerHelp_btn.HighEmphasis = true;
            this.schedulerHelp_btn.Icon = null;
            this.schedulerHelp_btn.Location = new System.Drawing.Point(453, 438);
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
            // 
            // scheduleInterval_tbx
            // 
            this.scheduleInterval_tbx.AnimateReadOnly = false;
            this.scheduleInterval_tbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.scheduleInterval_tbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.scheduleInterval_tbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scheduleInterval_tbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.scheduleInterval_tbx.Depth = 0;
            this.scheduleInterval_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scheduleInterval_tbx.HideSelection = true;
            this.scheduleInterval_tbx.LeadingIcon = null;
            this.scheduleInterval_tbx.Location = new System.Drawing.Point(302, 343);
            this.scheduleInterval_tbx.MaxLength = 32767;
            this.scheduleInterval_tbx.MouseState = MaterialSkin.MouseState.OUT;
            this.scheduleInterval_tbx.Name = "scheduleInterval_tbx";
            this.scheduleInterval_tbx.PasswordChar = '\0';
            this.scheduleInterval_tbx.PrefixSuffixText = null;
            this.scheduleInterval_tbx.ReadOnly = false;
            this.scheduleInterval_tbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scheduleInterval_tbx.SelectedText = "";
            this.scheduleInterval_tbx.SelectionLength = 0;
            this.scheduleInterval_tbx.SelectionStart = 0;
            this.scheduleInterval_tbx.ShortcutsEnabled = true;
            this.scheduleInterval_tbx.Size = new System.Drawing.Size(250, 48);
            this.scheduleInterval_tbx.TabIndex = 9;
            this.scheduleInterval_tbx.TabStop = false;
            this.scheduleInterval_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.scheduleInterval_tbx.TrailingIcon = null;
            this.scheduleInterval_tbx.UseSystemPasswordChar = false;
            // 
            // scheduleIntervalType_tbx
            // 
            this.scheduleIntervalType_tbx.AnimateReadOnly = false;
            this.scheduleIntervalType_tbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.scheduleIntervalType_tbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.scheduleIntervalType_tbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.scheduleIntervalType_tbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.scheduleIntervalType_tbx.Depth = 0;
            this.scheduleIntervalType_tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.scheduleIntervalType_tbx.HideSelection = true;
            this.scheduleIntervalType_tbx.LeadingIcon = null;
            this.scheduleIntervalType_tbx.Location = new System.Drawing.Point(17, 430);
            this.scheduleIntervalType_tbx.MaxLength = 32767;
            this.scheduleIntervalType_tbx.MouseState = MaterialSkin.MouseState.OUT;
            this.scheduleIntervalType_tbx.Name = "scheduleIntervalType_tbx";
            this.scheduleIntervalType_tbx.PasswordChar = '\0';
            this.scheduleIntervalType_tbx.PrefixSuffixText = null;
            this.scheduleIntervalType_tbx.ReadOnly = false;
            this.scheduleIntervalType_tbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scheduleIntervalType_tbx.SelectedText = "";
            this.scheduleIntervalType_tbx.SelectionLength = 0;
            this.scheduleIntervalType_tbx.SelectionStart = 0;
            this.scheduleIntervalType_tbx.ShortcutsEnabled = true;
            this.scheduleIntervalType_tbx.Size = new System.Drawing.Size(257, 48);
            this.scheduleIntervalType_tbx.TabIndex = 10;
            this.scheduleIntervalType_tbx.TabStop = false;
            this.scheduleIntervalType_tbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.scheduleIntervalType_tbx.TrailingIcon = null;
            this.scheduleIntervalType_tbx.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(21, 321);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(46, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Action";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(299, 321);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(53, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Interval";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(14, 408);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(101, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Internval Type";
            // 
            // scheduleAction_cbox
            // 
            this.scheduleAction_cbox.AutoResize = false;
            this.scheduleAction_cbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.scheduleAction_cbox.Depth = 0;
            this.scheduleAction_cbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.scheduleAction_cbox.DropDownHeight = 174;
            this.scheduleAction_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scheduleAction_cbox.DropDownWidth = 121;
            this.scheduleAction_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.scheduleAction_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scheduleAction_cbox.FormattingEnabled = true;
            this.scheduleAction_cbox.IntegralHeight = false;
            this.scheduleAction_cbox.ItemHeight = 43;
            this.scheduleAction_cbox.Location = new System.Drawing.Point(17, 342);
            this.scheduleAction_cbox.MaxDropDownItems = 4;
            this.scheduleAction_cbox.MouseState = MaterialSkin.MouseState.OUT;
            this.scheduleAction_cbox.Name = "scheduleAction_cbox";
            this.scheduleAction_cbox.Size = new System.Drawing.Size(257, 49);
            this.scheduleAction_cbox.StartIndex = 0;
            this.scheduleAction_cbox.TabIndex = 14;
            // 
            // serviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 495);
            this.Controls.Add(this.scheduleAction_cbox);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.scheduleIntervalType_tbx);
            this.Controls.Add(this.scheduleInterval_tbx);
            this.Controls.Add(this.schedulerHelp_btn);
            this.Controls.Add(this.scheduleTask_btn);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.startApp_btn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.startupArgument_tbx);
            this.Controls.Add(this.isAdmin_ckbox);
            this.Controls.Add(this.materialLabel1);
            this.Name = "serviceForm";
            this.Text = "Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox isAdmin_ckbox;
        private MaterialSkin.Controls.MaterialTextBox2 startupArgument_tbx;
        private MaterialSkin.Controls.MaterialButton startApp_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton scheduleTask_btn;
        private MaterialSkin.Controls.MaterialButton schedulerHelp_btn;
        private MaterialSkin.Controls.MaterialTextBox2 scheduleInterval_tbx;
        private MaterialSkin.Controls.MaterialTextBox2 scheduleIntervalType_tbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialComboBox scheduleAction_cbox;
    }
}