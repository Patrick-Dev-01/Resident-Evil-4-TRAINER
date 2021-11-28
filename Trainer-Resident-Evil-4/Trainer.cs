using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Diagnostics;

namespace Trainer_Resident_Evil_4
{
    public partial class Resident_evil_4_Trainer : Form
    {

        public Mem m = new Mem();
        Cheat cheat = new Cheat();
        bool ProcessOpen = false;
        public Resident_evil_4_Trainer()
        {
            InitializeComponent();
        }
        private void Resident_evil_4_Trainer_Load(object sender, EventArgs e)
        {

        }
  
        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                ProcessOpen = m.OpenProcess("bio4.exe");
                // Verificar se o GTA San Andreas esta executando
                if (ProcessOpen)
                {
                    Thread.Sleep(1000);
                    return;
                }
                // impedir o uso excessivo da CPU
                Thread.Sleep(1000);
                BgWorker.ReportProgress(0);
            }
        }

        private void Resident_evil_4_Trainer_Shown(object sender, EventArgs e)
        {
            BgWorker.RunWorkerAsync();
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BgWorker.RunWorkerAsync();
        }

        private void unlimitedAmmoBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (unlimitedAmmoBox.Checked)
            {
               m.WriteMemory("bio4.exe+3091E3", "bytes", "90 90 90 90");
            }

            else {
                m.WriteMemory("bio4.exe+3091E3", "bytes", "66 89 57 08");
            }
        }

        private void infiniteLife_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (infiniteLife_checkBox.Checked)
            {
               m.WriteMemory("bio4.exe+1B5C64", "bytes", "90 90 90 90 90 90 90");
            }

            else
            {
                m.WriteMemory("bio4.exe+1B5C64", "bytes", "66 29 BE B4 4F 00 00");
            }
        }

        private void InfiniteHeatlhAshley_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InfiniteHeatlhAshley_checkBox.Checked)
            {
                m.WriteMemory("bio4.exe+1B5D83", "bytes", "90 90 90 90 90 90 90");
            }

            else
            {
                m.WriteMemory("bio4.exe+1B5D83", "bytes", "66 29 BE B8 4F 00 00");
            }
        }

        private void oneShotKill_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oneShotKill_checkBox.Checked)
            {
                m.WriteMemory("bio4.exe+1B5E9A", "bytes", "90 90");          
            }

            else
            {
                m.WriteMemory("bio4.exe+1B5E9A", "bytes", "7D 02");
            }
        }

        private void maxLeonHeatlh_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (maxLeonHeatlh_checkBox.Checked)
            {   
                m.WriteMemory("bio4.exe+85F714", "bytes", "60 09 60 09");
            }
        }

        private void leonSpeed_numericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            int speed = Convert.ToInt32(leonSpeed_numericUpDown.Value);

            if (speed > 1)
            {
                m.FreezeValue("bio4.exe+007FDB08,298", "float", speed.ToString());
            }

            else { 
                m.UnfreezeValue("bio4.exe+007FDB08,298");
                m.WriteMemory("bio4.exe+007FDB08,298", "float", speed.ToString());
            }
        }

        private void maxWallet_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (maxWallet_checkBox.Checked) {
                m.WriteMemory("bio4.exe+00870FE8,44", "array of bytes", 8323072.ToString("X"));
            }
        }

        private void noClip_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noClip_checkBox.Checked)
            {
                m.WriteMemory("bio4.exe+194C2A", "bytes", "90 90 90");
            }

            else
            {
                m.WriteMemory("bio4.exe+194C2A", "bytes", "D9 1C 24");
            }
        }

        private void InvencibleLeon_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InvencibleLeon_checkBox.Checked) {
                m.WriteMemory("bio4.exe+1BC454", "bytes", "90 90 90 90 90 90 90");
            }

            else
            {
                m.WriteMemory("bio4.exe+1BC454", "bytes", "80 B9 2C 03 00 00 00");
            }
        }
    }
}
