using System;
using System.ComponentModel;
using System.Windows.Forms;
using Domain;
using Team_Comtress_Updater;
using Team_Comtress_Updater.Patch;

namespace WinFormsApp1
{
    public partial class TFCUpdater : Form
    {
        private IConfigManager _configManager;
        private PatchManager _patchManager;

        public TFCUpdater()
        {
            InitializeComponent();
            _configManager = new ConfigManager();
            Config config = _configManager.Config;
            _patchManager = new PatchManager();

            TF2_Dir_Label.Text = config.TF2Path;
            TCDir_Label.Text = config.TCPath;
        }


        private void TF2Dir_Button_Click(object sender, EventArgs e)
        {
            if (TF2Path_Dialog.ShowDialog() == DialogResult.OK)
            {
                string path = TF2Path_Dialog.SelectedPath;
                TF2_Dir_Label.Text = path;
                _configManager.Config.TF2Path = path;
            }
        }

        private void TCDir_Button_Click(object sender, EventArgs e)
        {
            if (TCPath_Dialog.ShowDialog() == DialogResult.OK)
            {
                string path = TCPath_Dialog.SelectedPath;
                TCDir_Label.Text = path;
                _configManager.Config.TCPath = path;
            }
        }

        private void PatchButton_Click(object sender, EventArgs e)
        {
            bool clean = CleanPatchBox.Checked;
            _patchManager.Init(_configManager.Config.TF2Path,_configManager.Config.TCPath);
            if (clean)
            {
                PatchStatusLabel.Text = "Cleaning installation";
                _patchManager.Clean();
            }
            PatchStatusLabel.Text = "Copying files";
            _patchManager.CopyGame();
            PatchStatusLabel.Text = "Installing Patch";
            _patchManager.InstallPatch();
            PatchStatusLabel.Text = "Done.";
        }
    }
}