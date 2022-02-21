namespace GameFixer
{
    namespace GUI
    {
        partial class LogForm
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
                this.LogMultiLineTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
                this.CleanLogButton = new MaterialSkin.Controls.MaterialButton();
                this.SuspendLayout();
                // 
                // LogMultiLineTextBox
                // 
                this.LogMultiLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                this.LogMultiLineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.LogMultiLineTextBox.Depth = 0;
                this.LogMultiLineTextBox.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
                this.LogMultiLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                this.LogMultiLineTextBox.Location = new System.Drawing.Point(15, 81);
                this.LogMultiLineTextBox.MouseState = MaterialSkin.MouseState.HOVER;
                this.LogMultiLineTextBox.Name = "LogMultiLineTextBox";
                this.LogMultiLineTextBox.ReadOnly = true;
                this.LogMultiLineTextBox.Size = new System.Drawing.Size(770, 458);
                this.LogMultiLineTextBox.TabIndex = 0;
                this.LogMultiLineTextBox.Text = "";
                // 
                // CleanLogButton
                // 
                this.CleanLogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                this.CleanLogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
                this.CleanLogButton.Depth = 0;
                this.CleanLogButton.HighEmphasis = true;
                this.CleanLogButton.Icon = null;
                this.CleanLogButton.Location = new System.Drawing.Point(685, 549);
                this.CleanLogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                this.CleanLogButton.MouseState = MaterialSkin.MouseState.HOVER;
                this.CleanLogButton.Name = "CleanLogButton";
                this.CleanLogButton.NoAccentTextColor = System.Drawing.Color.Empty;
                this.CleanLogButton.Size = new System.Drawing.Size(100, 36);
                this.CleanLogButton.TabIndex = 1;
                this.CleanLogButton.Text = "Clean Log";
                this.CleanLogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
                this.CleanLogButton.UseAccentColor = false;
                this.CleanLogButton.UseVisualStyleBackColor = true;
                this.CleanLogButton.Click += new System.EventHandler(this.CleanLogButton_Click);
                // 
                // LogForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(800, 600);
                this.Controls.Add(this.CleanLogButton);
                this.Controls.Add(this.LogMultiLineTextBox);
                this.Name = "LogForm";
                this.Text = "Log";
                this.ResumeLayout(false);
                this.PerformLayout();

            }

            #endregion

            private MaterialSkin.Controls.MaterialMultiLineTextBox LogMultiLineTextBox;
            private MaterialSkin.Controls.MaterialButton CleanLogButton;
        }
    }
}