namespace GW_Utility_V3
{
    partial class settingForm
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
            this.updateSettings_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.colourScheme_cbox = new MaterialSkin.Controls.MaterialComboBox();
            this.reset_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 114);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(99, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Color Scheme";
            // 
            // updateSettings_btn
            // 
            this.updateSettings_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateSettings_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.updateSettings_btn.Depth = 0;
            this.updateSettings_btn.HighEmphasis = true;
            this.updateSettings_btn.Icon = null;
            this.updateSettings_btn.Location = new System.Drawing.Point(22, 194);
            this.updateSettings_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.updateSettings_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateSettings_btn.Name = "updateSettings_btn";
            this.updateSettings_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.updateSettings_btn.Size = new System.Drawing.Size(77, 36);
            this.updateSettings_btn.TabIndex = 2;
            this.updateSettings_btn.Text = "Update";
            this.updateSettings_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.updateSettings_btn.UseAccentColor = false;
            this.updateSettings_btn.UseVisualStyleBackColor = true;
            this.updateSettings_btn.Click += new System.EventHandler(this.updateSettings_btn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(19, 391);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(187, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Designed By Jack Barnard";
            // 
            // colourScheme_cbox
            // 
            this.colourScheme_cbox.AutoResize = false;
            this.colourScheme_cbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.colourScheme_cbox.Depth = 0;
            this.colourScheme_cbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colourScheme_cbox.DropDownHeight = 174;
            this.colourScheme_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colourScheme_cbox.DropDownWidth = 121;
            this.colourScheme_cbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.colourScheme_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colourScheme_cbox.FormattingEnabled = true;
            this.colourScheme_cbox.IntegralHeight = false;
            this.colourScheme_cbox.ItemHeight = 43;
            this.colourScheme_cbox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Dark",
            "High Contrast"});
            this.colourScheme_cbox.Location = new System.Drawing.Point(19, 136);
            this.colourScheme_cbox.MaxDropDownItems = 4;
            this.colourScheme_cbox.MouseState = MaterialSkin.MouseState.OUT;
            this.colourScheme_cbox.Name = "colourScheme_cbox";
            this.colourScheme_cbox.Size = new System.Drawing.Size(250, 49);
            this.colourScheme_cbox.StartIndex = 0;
            this.colourScheme_cbox.TabIndex = 8;
            // 
            // reset_btn
            // 
            this.reset_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reset_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.reset_btn.Depth = 0;
            this.reset_btn.HighEmphasis = true;
            this.reset_btn.Icon = null;
            this.reset_btn.Location = new System.Drawing.Point(22, 287);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.reset_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.reset_btn.Size = new System.Drawing.Size(158, 36);
            this.reset_btn.TabIndex = 9;
            this.reset_btn.Text = "Reset";
            this.reset_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.reset_btn.UseAccentColor = false;
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(19, 262);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(172, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Reset Gateway Location";
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(365, 434);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.colourScheme_cbox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.updateSettings_btn);
            this.Controls.Add(this.materialLabel1);
            this.Name = "settingForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton updateSettings_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox colourScheme_cbox;
        private MaterialSkin.Controls.MaterialButton reset_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}