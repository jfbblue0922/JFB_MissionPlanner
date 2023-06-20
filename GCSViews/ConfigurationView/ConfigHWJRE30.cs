using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWJRE30 : MyUserControl, IActivate, IDeactivate
    {
        public ConfigHWJRE30()
        {
            InitializeComponent();

            CMB_GAIN.Items.Add("-120");
            CMB_GAIN.Items.Add("0");
            CMB_GAIN.Items.Add("6");
            CMB_GAIN.Items.Add("14");
            CMB_GAIN.Items.Add("20");
            CMB_GAIN.Items.Add("26");
            CMB_GAIN.Items.Add("34");
            CMB_GAIN.Items.Add("40");
        }

        public void Activate()
        {
            if (!MainV2.comPort.BaseStream.IsOpen && !MainV2.comPort.logreadmode)
            {
                Enabled = false;
                return;
            }

            Enabled = true;
        }

        public void Deactivate()
        {
        }

        private void BUT_datazero_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomMessageBox.Show("Are you sure you want to ZERO DATA SET SETTING??", "ZERO_SET", CustomMessageBox.MessageBoxButtons.YesNo) != CustomMessageBox.DialogResult.Yes) return;
                if (MainV2.comPort.doZeroSet_JRE30_1(true) == false)
                {
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }
        }

        private void BUT_datazeroclear_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomMessageBox.Show("Are you sure you want to ZERO DATA SET CLEAR??", "ZERO_SET", CustomMessageBox.MessageBoxButtons.YesNo) != CustomMessageBox.DialogResult.Yes) return;
                if (MainV2.comPort.doZeroSet_JRE30_2(true) == false)
                {
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }
        }

        private void BUT_gain_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomMessageBox.Show("Are you sure you want to GAIN SET??", "GAIN SET", CustomMessageBox.MessageBoxButtons.YesNo) != CustomMessageBox.DialogResult.Yes) return;
                float val = float.Parse(CMB_GAIN.Text);
                if (MainV2.comPort.doSetGain_JRE30_3(true, val) == false)
                {
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }
        }

        private void CMB_GAIN_SelectIndexChanged(object sender, EventArgs e)
        {
            int val = int.Parse(CMB_GAIN.Text);
        }

    }
}