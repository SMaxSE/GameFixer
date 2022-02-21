using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace GameFixer
{
    namespace Fixes
    {
        public sealed class Fallout3 : Game
        {
            private readonly Mod _anniversaryPatcher;
            private readonly Mod _antiCrash;
            private readonly Mod _archiveInvalidation;
            private readonly Mod _combatLagFix;
            private readonly Mod _commandExtender;
            private readonly Mod _disableProcessWindowsGhosting;
            private readonly Mod _lootMenu;
            private readonly Mod _oggVorbisLibraries;
            private readonly Mod _oneTweak;
            private readonly Mod _russianSound;
            private readonly Mod _russianText;
            private readonly Mod _scriptExtender;
            private readonly Mod _stewieTweaks;
            private readonly Mod _unofficialPatch;
            private readonly Mod _vanillaUserInterfacePlus;

            public Fallout3() : base()
            {
                ModsDirectory += @"Fallout 3\";
                _anniversaryPatcher = new Mod();
                _antiCrash = new Mod();
                _archiveInvalidation = new Mod();
                _combatLagFix = new Mod();
                _commandExtender = new Mod();
                _disableProcessWindowsGhosting = new Mod();
                _lootMenu = new Mod();
                _oggVorbisLibraries = new Mod();
                _oneTweak = new Mod();
                _russianSound = new Mod();
                _russianText = new Mod();
                _scriptExtender = new Mod();
                _stewieTweaks = new Mod();
                _unofficialPatch = new Mod();
                _vanillaUserInterfacePlus = new Mod();

                _anniversaryPatcher.Name = "Anniversary Patcher";
                _antiCrash.Name = "Anti-Crash";
                _archiveInvalidation.Name = "Archive Invalidation";
                _combatLagFix.Name = "Combat Lag Fix";
                _commandExtender.Name = "Command Extender";
                _disableProcessWindowsGhosting.Name = "Disable Process Windows Ghosting";
                _lootMenu.Name = "Loot Menu";
                _oggVorbisLibraries.Name = "Ogg Vorbis Libraries";
                _oneTweak.Name = "One Tweak";
                _russianSound.Name = "Russian Text";
                _russianText.Name = "Russian Sound";
                _scriptExtender.Name = "Script Extender";
                _stewieTweaks.Name = "Stewie Tweaks";
                _unofficialPatch.Name = "Unofficial Patch";
                _vanillaUserInterfacePlus.Name = "Vanilla User Interface Plus";

                _anniversaryPatcher.Version = "1.1";
                _antiCrash.Version = "7.5.1.0";
                _archiveInvalidation.Version = "1.0";
                _combatLagFix.Version = "1.0";
                _commandExtender.Version = "22.0";
                _disableProcessWindowsGhosting.Version = "2.0";
                _lootMenu.Version = "1.5";
                _oggVorbisLibraries.Version = "6.0";
                _oneTweak.Version = "2.1.0.2";
                _russianSound.Version = "1.0";
                _russianText.Version = "1.0";
                _scriptExtender.Version = "1.3b2";
                _stewieTweaks.Version = "3.10";
                _unofficialPatch.Version = "3.1.9.1";
                _vanillaUserInterfacePlus.Version = "8.59";

                _anniversaryPatcher.SourcePath = ModsDirectory + _anniversaryPatcher.Name;
                _antiCrash.SourcePath = ModsDirectory + _antiCrash.Name;
                _archiveInvalidation.SourcePath = ModsDirectory + _archiveInvalidation.Name;
                _combatLagFix.SourcePath = ModsDirectory + _combatLagFix.Name;
                _commandExtender.SourcePath = ModsDirectory + _commandExtender.Name;
                _disableProcessWindowsGhosting.SourcePath = ModsDirectory + _disableProcessWindowsGhosting.Name;
                _lootMenu.SourcePath = ModsDirectory + _lootMenu.Name;
                _oggVorbisLibraries.SourcePath = ModsDirectory + _oggVorbisLibraries.Name;
                _oneTweak.SourcePath = ModsDirectory + _oneTweak.Name;
                _russianSound.SourcePath = ModsDirectory + _russianSound.Name;
                _russianText.SourcePath = ModsDirectory + _russianText.Name;
                _scriptExtender.SourcePath = ModsDirectory + _scriptExtender.Name;
                _stewieTweaks.SourcePath = ModsDirectory + _stewieTweaks.Name;
                _unofficialPatch.SourcePath = ModsDirectory + _unofficialPatch.Name;
                _vanillaUserInterfacePlus.SourcePath = ModsDirectory + _vanillaUserInterfacePlus.Name;

                _anniversaryPatcher.CheckedChanged = AnniversaryPatcher_CheckedChanged;
                _antiCrash.CheckedChanged = AntiCrash_CheckedChanged;
                _archiveInvalidation.CheckedChanged = ArchiveInvalidation_CheckedChanged;
                _combatLagFix.CheckedChanged = CombatLagFix_CheckedChanged;
                _commandExtender.CheckedChanged = CommandExtender_CheckedChanged;
                _disableProcessWindowsGhosting.CheckedChanged = DisableProcessWindowsGhosting_CheckedChanged;
                _lootMenu.CheckedChanged = LootMenu_CheckedChanged;
                _oggVorbisLibraries.CheckedChanged = OggVorbisLibraries_CheckedChanged;
                _oneTweak.CheckedChanged = OneTweak_CheckedChanged;
                _russianSound.CheckedChanged = RussianSound_CheckedChanged;
                _russianText.CheckedChanged = RussianText_CheckedChanged;
                _scriptExtender.CheckedChanged = ScriptExtender_CheckedChanged;
                _stewieTweaks.CheckedChanged = StewieTweaks_CheckedChanged;
                _unofficialPatch.CheckedChanged = UnofficialPatch_CheckedChanged;
                _vanillaUserInterfacePlus.CheckedChanged = VanillaUserInterfacePlus_CheckedChanged;

                Mods.Add(_anniversaryPatcher);
                Mods.Add(_antiCrash);
                Mods.Add(_archiveInvalidation);
                Mods.Add(_combatLagFix);
                Mods.Add(_commandExtender);
                Mods.Add(_disableProcessWindowsGhosting);
                Mods.Add(_lootMenu);
                Mods.Add(_oggVorbisLibraries);      
                Mods.Add(_scriptExtender);
                Mods.Add(_stewieTweaks);
                Mods.Add(_unofficialPatch);
                Mods.Add(_vanillaUserInterfacePlus);
                Mods.Add(_russianSound);
                Mods.Add(_russianText);
            }

            private bool ModIsChecked(object sender)
            {
                if (sender == null)
                    throw new ArgumentNullException();
                if (sender is MaterialCheckbox checkBox)
                    return checkBox.Checked;
                if (sender is Mod mod)
                    return mod.Checked;
                throw new ArgumentException();
            }

            private void UpdateProgressBar()
            {
                ProgressBar.Maximum = 0;
                foreach (Mod mod in Mods.Where(mod => mod.Checked == true)) 
                    ProgressBar.Maximum += mod.FileCount;
            }

            private void ScriptExtender_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == false)
                {
                    _stewieTweaks.Checked = false;
                    _commandExtender.Checked = false;
                    _combatLagFix.Checked = false;
                    _lootMenu.Checked = false;
                    _antiCrash.Checked = false;
                    _disableProcessWindowsGhosting.Checked = false;
                    _unofficialPatch.Checked = false;
                    _oneTweak.Checked = false;
                }
                UpdateProgressBar();
            }

            private void AnniversaryPatcher_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == false)
                    _scriptExtender.Checked = false;                
                UpdateProgressBar();
            }

            private void StewieTweaks_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                }
                UpdateProgressBar();
            }

            private void CommandExtender_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                }
                else
                    _unofficialPatch.Checked = false;
                UpdateProgressBar();
            }

            private void CombatLagFix_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                }
                UpdateProgressBar();
            }

            private void LootMenu_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                }
                UpdateProgressBar();
            }

            private void OggVorbisLibraries_CheckedChanged(object sender, EventArgs e)
            {
                UpdateProgressBar();
            }

            private void AntiCrash_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                }
                UpdateProgressBar();
            }

            private void DisableProcessWindowsGhosting_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                }
                UpdateProgressBar();
            }

            private void UnofficialPatch_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                    _commandExtender.Checked = true;
                    _archiveInvalidation.Checked = true;
                }
                UpdateProgressBar();
            }

            private void OneTweak_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _anniversaryPatcher.Checked = true;
                    _scriptExtender.Checked = true;
                }
                UpdateProgressBar();
            }

            private void VanillaUserInterfacePlus_CheckedChanged(object sender, EventArgs e)
            {
                UpdateProgressBar();
            }

            private void RussianText_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true)
                {
                    _archiveInvalidation.Checked = true;
                    if (_russianSound.Checked == true)
                        _unofficialPatch.SourcePath = ModsDirectory + _unofficialPatch.Name + @"\Russian sound and text";
                    else
                        _unofficialPatch.SourcePath = ModsDirectory + _unofficialPatch.Name + @"\English sound and russian text";
                }
                UpdateProgressBar();
            }

            private void RussianSound_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == true) 
                    _russianText.Checked = true;
                UpdateProgressBar();
            }

            private void ArchiveInvalidation_CheckedChanged(object sender, EventArgs e)
            {
                if (ModIsChecked(sender) == false)
                {
                    _unofficialPatch.Checked = false;
                    _russianText.Checked = false;
                }
                UpdateProgressBar();
            }

            async public override void InstallMods(DirectoryInfo targetPath)
            {
                if (targetPath == null)
                    throw new ArgumentNullException();
                ProgressBar.Value = 0;
                foreach (Mod mod in Mods)
                    await Task.Run(() =>
                    {
                        mod.Install(targetPath);
                        ProgressBar.Invoke(new Action(() => ProgressBar.Value += mod.FileCount));
                    });
            }
        }
    }
}