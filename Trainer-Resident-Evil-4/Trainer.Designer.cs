
using System;
using System.ComponentModel;

namespace Trainer_Resident_Evil_4
{
    partial class Resident_evil_4_Trainer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.unlimitedAmmoBox = new System.Windows.Forms.CheckBox();
            this.infiniteLife_checkBox = new System.Windows.Forms.CheckBox();
            this.InfiniteHeatlhAshley_checkBox = new System.Windows.Forms.CheckBox();
            this.oneShotKill_checkBox = new System.Windows.Forms.CheckBox();
            this.maxLeonHeatlh_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leonSpeed_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noClip_checkBox = new System.Windows.Forms.CheckBox();
            this.InvencibleLeon_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.leonSpeed_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerReportsProgress = true;
            this.BgWorker.WorkerSupportsCancellation = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // unlimitedAmmoBox
            // 
            this.unlimitedAmmoBox.AutoSize = true;
            this.unlimitedAmmoBox.Location = new System.Drawing.Point(12, 29);
            this.unlimitedAmmoBox.Name = "unlimitedAmmoBox";
            this.unlimitedAmmoBox.Size = new System.Drawing.Size(138, 24);
            this.unlimitedAmmoBox.TabIndex = 1;
            this.unlimitedAmmoBox.Text = "Munição Infinita";
            this.unlimitedAmmoBox.UseVisualStyleBackColor = true;
            this.unlimitedAmmoBox.CheckStateChanged += new System.EventHandler(this.unlimitedAmmoBox_CheckStateChanged);
            // 
            // infiniteLife_checkBox
            // 
            this.infiniteLife_checkBox.AutoSize = true;
            this.infiniteLife_checkBox.Location = new System.Drawing.Point(12, 59);
            this.infiniteLife_checkBox.Name = "infiniteLife_checkBox";
            this.infiniteLife_checkBox.Size = new System.Drawing.Size(147, 24);
            this.infiniteLife_checkBox.TabIndex = 5;
            this.infiniteLife_checkBox.Text = "Vida Infinita Leon";
            this.infiniteLife_checkBox.UseVisualStyleBackColor = true;
            this.infiniteLife_checkBox.CheckedChanged += new System.EventHandler(this.infiniteLife_checkBox_CheckedChanged);
            // 
            // InfiniteHeatlhAshley_checkBox
            // 
            this.InfiniteHeatlhAshley_checkBox.AutoSize = true;
            this.InfiniteHeatlhAshley_checkBox.Location = new System.Drawing.Point(12, 121);
            this.InfiniteHeatlhAshley_checkBox.Name = "InfiniteHeatlhAshley_checkBox";
            this.InfiniteHeatlhAshley_checkBox.Size = new System.Drawing.Size(158, 24);
            this.InfiniteHeatlhAshley_checkBox.TabIndex = 6;
            this.InfiniteHeatlhAshley_checkBox.Text = "Vida Infinita Ashley";
            this.InfiniteHeatlhAshley_checkBox.UseVisualStyleBackColor = true;
            this.InfiniteHeatlhAshley_checkBox.CheckedChanged += new System.EventHandler(this.InfiniteHeatlhAshley_checkBox_CheckedChanged);
            // 
            // oneShotKill_checkBox
            // 
            this.oneShotKill_checkBox.AutoSize = true;
            this.oneShotKill_checkBox.Location = new System.Drawing.Point(12, 151);
            this.oneShotKill_checkBox.Name = "oneShotKill_checkBox";
            this.oneShotKill_checkBox.Size = new System.Drawing.Size(117, 24);
            this.oneShotKill_checkBox.TabIndex = 7;
            this.oneShotKill_checkBox.Text = "One Shot Kill";
            this.oneShotKill_checkBox.UseVisualStyleBackColor = true;
            this.oneShotKill_checkBox.CheckedChanged += new System.EventHandler(this.oneShotKill_checkBox_CheckedChanged);
            // 
            // maxLeonHeatlh_checkBox
            // 
            this.maxLeonHeatlh_checkBox.AutoSize = true;
            this.maxLeonHeatlh_checkBox.Location = new System.Drawing.Point(12, 91);
            this.maxLeonHeatlh_checkBox.Name = "maxLeonHeatlh_checkBox";
            this.maxLeonHeatlh_checkBox.Size = new System.Drawing.Size(154, 24);
            this.maxLeonHeatlh_checkBox.TabIndex = 8;
            this.maxLeonHeatlh_checkBox.Text = "Vida máxima Leon";
            this.maxLeonHeatlh_checkBox.UseVisualStyleBackColor = true;
            this.maxLeonHeatlh_checkBox.CheckedChanged += new System.EventHandler(this.maxLeonHeatlh_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aumentar a Velocidade do Leon";
            // 
            // leonSpeed_numericUpDown
            // 
            this.leonSpeed_numericUpDown.Location = new System.Drawing.Point(240, 181);
            this.leonSpeed_numericUpDown.Name = "leonSpeed_numericUpDown";
            this.leonSpeed_numericUpDown.Size = new System.Drawing.Size(74, 27);
            this.leonSpeed_numericUpDown.TabIndex = 12;
            this.leonSpeed_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leonSpeed_numericUpDown.ValueChanged += new System.EventHandler(this.leonSpeed_numericUpDown_ValueChanged_1);
            // 
            // noClip_checkBox
            // 
            this.noClip_checkBox.AutoSize = true;
            this.noClip_checkBox.Location = new System.Drawing.Point(240, 29);
            this.noClip_checkBox.Name = "noClip_checkBox";
            this.noClip_checkBox.Size = new System.Drawing.Size(146, 24);
            this.noClip_checkBox.TabIndex = 13;
            this.noClip_checkBox.Text = "Desativar Colisão";
            this.noClip_checkBox.UseVisualStyleBackColor = true;
            this.noClip_checkBox.CheckedChanged += new System.EventHandler(this.noClip_checkBox_CheckedChanged);
            // 
            // InvencibleLeon_checkBox
            // 
            this.InvencibleLeon_checkBox.AutoSize = true;
            this.InvencibleLeon_checkBox.Location = new System.Drawing.Point(240, 59);
            this.InvencibleLeon_checkBox.Name = "InvencibleLeon_checkBox";
            this.InvencibleLeon_checkBox.Size = new System.Drawing.Size(132, 24);
            this.InvencibleLeon_checkBox.TabIndex = 14;
            this.InvencibleLeon_checkBox.Text = "Leon Invencível";
            this.InvencibleLeon_checkBox.UseVisualStyleBackColor = true;
            this.InvencibleLeon_checkBox.CheckedChanged += new System.EventHandler(this.InvencibleLeon_checkBox_CheckedChanged);
            // 
            // Resident_evil_4_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 440);
            this.Controls.Add(this.InvencibleLeon_checkBox);
            this.Controls.Add(this.noClip_checkBox);
            this.Controls.Add(this.leonSpeed_numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxLeonHeatlh_checkBox);
            this.Controls.Add(this.oneShotKill_checkBox);
            this.Controls.Add(this.InfiniteHeatlhAshley_checkBox);
            this.Controls.Add(this.infiniteLife_checkBox);
            this.Controls.Add(this.unlimitedAmmoBox);
            this.Name = "Resident_evil_4_Trainer";
            this.Text = "Resident Evil 4 Trainer";
            this.Load += new System.EventHandler(this.Resident_evil_4_Trainer_Load);
            this.Shown += new System.EventHandler(this.Resident_evil_4_Trainer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.leonSpeed_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.ComponentModel.BackgroundWorker BgWorker;
        private System.Windows.Forms.CheckBox unlimitedAmmoBox;
        private System.Windows.Forms.CheckBox infiniteLife_checkBox;
        private System.Windows.Forms.CheckBox InfiniteHeatlhAshley_checkBox;
        private System.Windows.Forms.CheckBox oneShotKill_checkBox;
        private System.Windows.Forms.CheckBox maxLeonHeatlh_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown leonSpeed_numericUpDown;
        private System.Windows.Forms.CheckBox maxWallet_checkBox;
        private System.Windows.Forms.CheckBox noClip_checkBox;
        private System.Windows.Forms.CheckBox InvencibleLeon_checkBox;
    }
}

