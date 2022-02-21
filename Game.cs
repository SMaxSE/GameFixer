using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GameFixer
{
    namespace Fixes
    {
        public abstract class Game
        {
            private readonly List<Mod> _mods;
            private string _modsDirectory;
            private MaterialProgressBar _progressBar;

            private protected Game()
            {
                _mods = new List<Mod>();
                _modsDirectory = @"Mods\";
            }

            private protected List<Mod> Mods => _mods;

            private protected string ModsDirectory
            {
                get => _modsDirectory;
                set
                {
                    if (Directory.Exists(value) == false)
                        foreach (Mod mod in _mods)
                        {
                            mod.Enabled = false;
                            mod.Checked = false;
                        }
                    _modsDirectory = value ?? throw new ArgumentNullException();
                }
            }

            public MaterialProgressBar ProgressBar
            {
                get => _progressBar;
                set => _progressBar = value ?? throw new ArgumentNullException();
            }

            public void ShowMods(MaterialCheckedListBox checkedListBox)
            {
                checkedListBox.Items.Clear();
                foreach (Mod mod in _mods) 
                    mod.Show(checkedListBox);
            }

            public abstract void InstallMods(DirectoryInfo targetPath);
        }
    }
}
