using MaterialSkin.Controls;
using System;
using System.IO;
using System.Windows.Forms;

namespace GameFixer
{
    namespace Fixes
    {
        public sealed class Mod
        {
            private string _name;
            private string _version;
            private string _sourcePath;
            private int _fileCount;
            private readonly MaterialCheckbox _checkBox;

            public Mod()
            {
                _name = "No name";
                _version = "1.0";
                _sourcePath = "";
                _fileCount = 0;
                _checkBox = new MaterialCheckbox() { Text = _name };
            }

            public string Name
            {
                get => _name;
                set
                {
                    _name = value ?? throw new ArgumentNullException();
                    _checkBox.Text = $"{_name} {_version}";
                }
            }

            public string Version
            {
                get => _version;
                set
                {
                    _version = value ?? throw new ArgumentNullException();
                    _checkBox.Text = $"{_name} {_version}";
                }
            }

            public string SourcePath
            {
                get => _sourcePath;
                set
                {
                    DisableIfPathNotFound();
                    _sourcePath = value;
                    FileCount = GetFileCount();
                }
            }

            public int FileCount
            {
                get => _fileCount;
                private set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException("number of files cannot be less than zero");
                    _fileCount = value;
                }
            }

            public bool Enabled
            {
                get => _checkBox.Enabled;
                set => _checkBox.Enabled = value;
            }

            public bool Checked
            {
                get => _checkBox.Checked;
                set => _checkBox.Checked = value;
            }

            public EventHandler CheckedChanged
            {
                set => _checkBox.CheckedChanged += value ?? throw new ArgumentNullException();
            }

            public void DisableIfPathNotFound()
            {
                if (Directory.Exists(_sourcePath ?? throw new ArgumentNullException()) == false)
                {
                    _checkBox.Enabled = false;
                    _checkBox.Checked = false;
                }
            }

            private int GetFileCount()
            {
                return Directory.Exists(_sourcePath) == true ? Directory.GetFiles(_sourcePath).Length : 0;
            }

            public void Show(MaterialCheckedListBox checkedListBox)
            {
                if (checkedListBox == null)
                    throw new ArgumentNullException();
                checkedListBox.Items.Add(_checkBox);
            }

            public void Install(DirectoryInfo targetPath)
            {
                if (targetPath == null)
                    throw new ArgumentNullException();
                DisableIfPathNotFound();
                if (_checkBox.Checked == true)
                {
                    DirectoryInfo sourcePath = new DirectoryInfo(_sourcePath);
                    FileInfo[] files = sourcePath.GetFiles();
                    if (targetPath.Exists == false)
                        targetPath.Create();
                    foreach (FileInfo file in files)
                        file.CopyTo(targetPath.FullName, true);
                }
                   
            }
            
        }
    }
}