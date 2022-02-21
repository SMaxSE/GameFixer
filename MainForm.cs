using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using GameFixer.Fixes;
using MaterialSkin.Controls;

namespace GameFixer
{
    namespace GUI
    {
        public partial class MainForm : MaterialForm
        {
            private Game _game;
            private readonly LogForm _logForm = new LogForm();

            public MainForm()
            {
                InitializeComponent();
            }

            private void ChooseDirectoryButton_Click(object sender, EventArgs e)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    GamePathTextBox.Text = folderBrowserDialog.SelectedPath;
            }

            private void GameComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (GameComboBox.Text == "Fallout 3")
                    _game = new Fallout3();
                else if (GameComboBox.Text == "Fallout New Vegas") 
                    _game = new FalloutNewVegas();
                _game.ShowMods(ModsCheckedListBox);
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
            }

            private void DownLoadModsButton_Click(object sender, EventArgs e)
            {
                if (GameComboBox.Text == "Fallout New Vegas")
                    Process.Start("https://terabox.com/s/1YilJUFXag6dhQzGzb6I4Wg");
            }

            private void LogButton_Click(object sender, EventArgs e)
            {
                _logForm.ShowDialog();
            }

            private void InstallModsButton_Click(object sender, EventArgs e)
            {
                _game.InstallMods(new DirectoryInfo(GamePathTextBox.Text));
            }
        }
    }
}
