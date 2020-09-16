using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Data_Layer.Patcher;
using Domain;
using Team_Comtress_Updater;
using Team_Comtress_Updater.Patch;

namespace WinFormsApp1
{
    public partial class TFCUpdater : Form
    {
        private IConfigManager _configManager;
        private PatchManager _patchManager;
        private Dictionary<Control, bool> validation = new Dictionary<Control, bool>();

        public TFCUpdater()
        {
            InitializeComponent();
            _configManager = new ConfigManager();
            Config config = _configManager.Config;
            _patchManager = new PatchManager();

            TF2_Dir_Label.Text = config.TF2Path;
            TCDir_Label.Text = config.TCPath;
            if (!Validator.IsGameDir(config.TF2Path))
            {
                SetError(TF2_Dir_Label,config.TF2Path);
            }
            else
            {
                SetSuccess(TF2_Dir_Label,config.TF2Path);
            }
            if (!Validator.IsValidPath(config.TCPath))
            {
                SetError(TCDir_Label,config.TCPath);
            }
            else
            {
                SetSuccess(TCDir_Label,config.TCPath);
            }
        }


        private void TF2Dir_Button_Click(object sender, EventArgs e)
        {
            if (TF2Path_Dialog.ShowDialog() == DialogResult.OK)
            {
                string path = TF2Path_Dialog.SelectedPath;

                if (!Validator.IsGameDir(path))
                {
                    SetError(TF2_Dir_Label,path);
                }
                else
                {
                    SetSuccess(TF2_Dir_Label,path);
                    _configManager.Config.TF2Path = path;  
                }
            }
        }

        private void TCDir_Button_Click(object sender, EventArgs e)
        {
            if (TCPath_Dialog.ShowDialog() == DialogResult.OK)
            {
                string path = TCPath_Dialog.SelectedPath;
                if (!Validator.IsValidPath(path))
                {
                    SetError(TCDir_Label,path);
                }
                else
                {
                    SetSuccess(TCDir_Label,path);
                    _configManager.Config.TCPath = path;
                    //Enable the overwrite option if the directory already contains game files
                    OverwriteCheckbox.Enabled = Validator.IsGameDir(path);
                    OverwriteCheckbox.Checked = false;
                }
            }
        }

        private void PatchButton_Click(object sender, EventArgs e)
        {
            bool clean = CleanPatchBox.Checked;
            bool overwrite = OverwriteCheckbox.Checked;
            _patchManager.onStateUpdate = () => UpdateStatus(_patchManager.State);
            _patchManager.Init(_configManager.Config.TF2Path,_configManager.Config.TCPath,clean,overwrite);
        }

        private void UpdateStatus(PatchState state)
        {
            if (state == PatchState.DONE)
            {
                PatchButton.Enabled = true;
                OverwriteCheckbox.Enabled = true;
                CleanPatchBox.Enabled = true;
                TF2Dir_Button.Enabled = true;
                TCDir_Button.Enabled = true;
            }
            else
            {
                PatchButton.Enabled = false;
                OverwriteCheckbox.Enabled = false;
                CleanPatchBox.Enabled = false;
                TF2Dir_Button.Enabled = false;
                TCDir_Button.Enabled = false;
            }
            PatchStatusLabel.Text = state.ToString();
        }


        private void SetError(Label label, string message)
        {
            validation[label] = false;
            label.ForeColor = Color.Red;
            label.Text = message;
            UpdatePatchButton();
        }

        private void SetSuccess(Label label, string message)
        {
            validation[label] = true;
            label.ForeColor = Color.Green;
            label.Text = message;
            UpdatePatchButton();
        }

        private void UpdatePatchButton()
        {
            bool valid = validation.All(kvp => kvp.Value == true);
            PatchButton.Enabled = valid;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _configManager.SaveConfig();
        }


        private void CleanPatchBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CleanPatchBox.Checked)
            {
                OverwriteCheckbox.Checked = true;
                OverwriteCheckbox.Enabled = false;
            }
            else
            {
                OverwriteCheckbox.Checked = false;
                OverwriteCheckbox.Enabled = true;
            }
            
        }
        
    }
}