namespace GameFixer
{
    namespace GUI
    {
        partial class MainForm
        {
            /// <summary>
            /// Обязательная переменная конструктора.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Освободить все используемые ресурсы.
            /// </summary>
            /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Код, автоматически созданный конструктором форм Windows

            /// <summary>
            /// Требуемый метод для поддержки конструктора — не изменяйте 
            /// содержимое этого метода с помощью редактора кода.
            /// </summary>
            private void InitializeComponent()
            {
            this.GameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DirectoryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GameComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.ChoosePathButton = new MaterialSkin.Controls.MaterialButton();
            this.GamePathTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.InstallModsProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.ModsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ModsCheckedListBox = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.InstallModsButton = new MaterialSkin.Controls.MaterialButton();
            this.DownLoadModsButton = new MaterialSkin.Controls.MaterialButton();
            this.LogButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.Depth = 0;
            this.GameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GameLabel.Location = new System.Drawing.Point(15, 81);
            this.GameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(43, 19);
            this.GameLabel.TabIndex = 0;
            this.GameLabel.Text = "Game";
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Depth = 0;
            this.DirectoryLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DirectoryLabel.Location = new System.Drawing.Point(15, 169);
            this.DirectoryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(34, 19);
            this.DirectoryLabel.TabIndex = 1;
            this.DirectoryLabel.Text = "Path";
            // 
            // GameComboBox
            // 
            this.GameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameComboBox.AutoResize = false;
            this.GameComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GameComboBox.Depth = 0;
            this.GameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.GameComboBox.DropDownHeight = 174;
            this.GameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameComboBox.DropDownWidth = 121;
            this.GameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.GameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GameComboBox.FormattingEnabled = true;
            this.GameComboBox.IntegralHeight = false;
            this.GameComboBox.ItemHeight = 43;
            this.GameComboBox.Items.AddRange(new object[] {
            "Fallout 3",
            "Fallout New Vegas"});
            this.GameComboBox.Location = new System.Drawing.Point(15, 110);
            this.GameComboBox.MaxDropDownItems = 4;
            this.GameComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.GameComboBox.Name = "GameComboBox";
            this.GameComboBox.Size = new System.Drawing.Size(770, 49);
            this.GameComboBox.StartIndex = 0;
            this.GameComboBox.TabIndex = 2;
            this.GameComboBox.SelectedIndexChanged += new System.EventHandler(this.GameComboBox_SelectedIndexChanged);
            // 
            // ChoosePathButton
            // 
            this.ChoosePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoosePathButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChoosePathButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChoosePathButton.Depth = 0;
            this.ChoosePathButton.HighEmphasis = true;
            this.ChoosePathButton.Icon = null;
            this.ChoosePathButton.Location = new System.Drawing.Point(664, 198);
            this.ChoosePathButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChoosePathButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChoosePathButton.Name = "ChoosePathButton";
            this.ChoosePathButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChoosePathButton.Size = new System.Drawing.Size(121, 36);
            this.ChoosePathButton.TabIndex = 3;
            this.ChoosePathButton.Text = "Choose Path";
            this.ChoosePathButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChoosePathButton.UseAccentColor = false;
            this.ChoosePathButton.UseVisualStyleBackColor = true;
            this.ChoosePathButton.Click += new System.EventHandler(this.ChooseDirectoryButton_Click);
            // 
            // GamePathTextBox
            // 
            this.GamePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GamePathTextBox.AnimateReadOnly = false;
            this.GamePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GamePathTextBox.Depth = 0;
            this.GamePathTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GamePathTextBox.LeadingIcon = null;
            this.GamePathTextBox.Location = new System.Drawing.Point(15, 198);
            this.GamePathTextBox.MaxLength = 50;
            this.GamePathTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.GamePathTextBox.Multiline = false;
            this.GamePathTextBox.Name = "GamePathTextBox";
            this.GamePathTextBox.Size = new System.Drawing.Size(639, 50);
            this.GamePathTextBox.TabIndex = 4;
            this.GamePathTextBox.Text = "";
            this.GamePathTextBox.TrailingIcon = null;
            // 
            // InstallModsProgressBar
            // 
            this.InstallModsProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InstallModsProgressBar.Depth = 0;
            this.InstallModsProgressBar.Location = new System.Drawing.Point(15, 580);
            this.InstallModsProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.InstallModsProgressBar.Name = "InstallModsProgressBar";
            this.InstallModsProgressBar.Size = new System.Drawing.Size(770, 5);
            this.InstallModsProgressBar.TabIndex = 6;
            // 
            // ModsLabel
            // 
            this.ModsLabel.AutoSize = true;
            this.ModsLabel.Depth = 0;
            this.ModsLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ModsLabel.Location = new System.Drawing.Point(15, 304);
            this.ModsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModsLabel.Name = "ModsLabel";
            this.ModsLabel.Size = new System.Drawing.Size(41, 19);
            this.ModsLabel.TabIndex = 7;
            this.ModsLabel.Text = "Mods";
            // 
            // ModsCheckedListBox
            // 
            this.ModsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModsCheckedListBox.AutoScroll = true;
            this.ModsCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.ModsCheckedListBox.Depth = 0;
            this.ModsCheckedListBox.Location = new System.Drawing.Point(15, 333);
            this.ModsCheckedListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModsCheckedListBox.Name = "ModsCheckedListBox";
            this.ModsCheckedListBox.Size = new System.Drawing.Size(770, 237);
            this.ModsCheckedListBox.Striped = false;
            this.ModsCheckedListBox.StripeDarkColor = System.Drawing.Color.Empty;
            this.ModsCheckedListBox.TabIndex = 5;
            // 
            // InstallModsButton
            // 
            this.InstallModsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InstallModsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.InstallModsButton.Depth = 0;
            this.InstallModsButton.HighEmphasis = true;
            this.InstallModsButton.Icon = null;
            this.InstallModsButton.Location = new System.Drawing.Point(15, 258);
            this.InstallModsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.InstallModsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.InstallModsButton.Name = "InstallModsButton";
            this.InstallModsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.InstallModsButton.Size = new System.Drawing.Size(125, 36);
            this.InstallModsButton.TabIndex = 8;
            this.InstallModsButton.Text = "Install mods";
            this.InstallModsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.InstallModsButton.UseAccentColor = false;
            this.InstallModsButton.UseVisualStyleBackColor = true;
            this.InstallModsButton.Click += new System.EventHandler(this.InstallModsButton_Click);
            // 
            // DownLoadModsButton
            // 
            this.DownLoadModsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DownLoadModsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DownLoadModsButton.Depth = 0;
            this.DownLoadModsButton.HighEmphasis = true;
            this.DownLoadModsButton.Icon = null;
            this.DownLoadModsButton.Location = new System.Drawing.Point(150, 258);
            this.DownLoadModsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DownLoadModsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DownLoadModsButton.Name = "DownLoadModsButton";
            this.DownLoadModsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DownLoadModsButton.Size = new System.Drawing.Size(148, 36);
            this.DownLoadModsButton.TabIndex = 9;
            this.DownLoadModsButton.Text = "Download mods";
            this.DownLoadModsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DownLoadModsButton.UseAccentColor = false;
            this.DownLoadModsButton.UseVisualStyleBackColor = true;
            this.DownLoadModsButton.Click += new System.EventHandler(this.DownLoadModsButton_Click);
            // 
            // LogButton
            // 
            this.LogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LogButton.Depth = 0;
            this.LogButton.HighEmphasis = true;
            this.LogButton.Icon = null;
            this.LogButton.Location = new System.Drawing.Point(308, 258);
            this.LogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogButton.Name = "LogButton";
            this.LogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LogButton.Size = new System.Drawing.Size(64, 36);
            this.LogButton.TabIndex = 10;
            this.LogButton.Text = "Log";
            this.LogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LogButton.UseAccentColor = false;
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.DownLoadModsButton);
            this.Controls.Add(this.InstallModsButton);
            this.Controls.Add(this.ModsLabel);
            this.Controls.Add(this.InstallModsProgressBar);
            this.Controls.Add(this.ModsCheckedListBox);
            this.Controls.Add(this.GamePathTextBox);
            this.Controls.Add(this.ChoosePathButton);
            this.Controls.Add(this.GameComboBox);
            this.Controls.Add(this.DirectoryLabel);
            this.Controls.Add(this.GameLabel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Fixer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private MaterialSkin.Controls.MaterialLabel GameLabel;
            private MaterialSkin.Controls.MaterialLabel DirectoryLabel;
            private MaterialSkin.Controls.MaterialComboBox GameComboBox;
            private MaterialSkin.Controls.MaterialButton ChoosePathButton;
            private MaterialSkin.Controls.MaterialTextBox GamePathTextBox;
            private MaterialSkin.Controls.MaterialLabel ModsLabel;
            private MaterialSkin.Controls.MaterialCheckedListBox ModsCheckedListBox;
            private MaterialSkin.Controls.MaterialButton InstallModsButton;
            private MaterialSkin.Controls.MaterialButton DownLoadModsButton;
            private MaterialSkin.Controls.MaterialButton LogButton;
            private MaterialSkin.Controls.MaterialProgressBar InstallModsProgressBar;
        }
    }
}