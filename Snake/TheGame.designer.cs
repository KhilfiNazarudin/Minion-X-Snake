﻿namespace Snake
{
    partial class TheGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftBTN = new System.Windows.Forms.Button();
            this.downBTN = new System.Windows.Forms.Button();
            this.upBTN = new System.Windows.Forms.Button();
            this.rightBTN = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.speedLBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finishBTN = new System.Windows.Forms.Button();
            this.downrightBTN = new System.Windows.Forms.Button();
            this.downleftBTN = new System.Windows.Forms.Button();
            this.uprightBTN = new System.Windows.Forms.Button();
            this.upleftBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.pauseBTN = new System.Windows.Forms.Button();
            this.startBTN = new System.Windows.Forms.Button();
            this.modeLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.boardPanel = new System.Windows.Forms.Panel();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftBTN
            // 
            this.leftBTN.BackColor = System.Drawing.Color.Gold;
            this.leftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBTN.Location = new System.Drawing.Point(284, 64);
            this.leftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftBTN.Name = "leftBTN";
            this.leftBTN.Size = new System.Drawing.Size(43, 41);
            this.leftBTN.TabIndex = 1;
            this.leftBTN.Text = "🢀";
            this.leftBTN.UseVisualStyleBackColor = false;
            this.leftBTN.Click += new System.EventHandler(this.leftBTN_Click);
            // 
            // downBTN
            // 
            this.downBTN.BackColor = System.Drawing.Color.Gold;
            this.downBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBTN.Location = new System.Drawing.Point(355, 111);
            this.downBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downBTN.Name = "downBTN";
            this.downBTN.Size = new System.Drawing.Size(43, 41);
            this.downBTN.TabIndex = 3;
            this.downBTN.Text = "🢃";
            this.downBTN.UseVisualStyleBackColor = false;
            this.downBTN.Click += new System.EventHandler(this.downBTN_Click);
            // 
            // upBTN
            // 
            this.upBTN.BackColor = System.Drawing.Color.Gold;
            this.upBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upBTN.Location = new System.Drawing.Point(355, 14);
            this.upBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upBTN.Name = "upBTN";
            this.upBTN.Size = new System.Drawing.Size(43, 40);
            this.upBTN.TabIndex = 4;
            this.upBTN.Text = "🢁";
            this.upBTN.UseVisualStyleBackColor = false;
            this.upBTN.Click += new System.EventHandler(this.upBTN_Click);
            // 
            // rightBTN
            // 
            this.rightBTN.BackColor = System.Drawing.Color.Gold;
            this.rightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBTN.Location = new System.Drawing.Point(427, 64);
            this.rightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightBTN.Name = "rightBTN";
            this.rightBTN.Size = new System.Drawing.Size(43, 41);
            this.rightBTN.TabIndex = 5;
            this.rightBTN.Text = "🢂";
            this.rightBTN.UseVisualStyleBackColor = false;
            this.rightBTN.Click += new System.EventHandler(this.rightBTN_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.Pink;
            this.controlPanel.Controls.Add(this.speedLBL);
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.label3);
            this.controlPanel.Controls.Add(this.finishBTN);
            this.controlPanel.Controls.Add(this.downrightBTN);
            this.controlPanel.Controls.Add(this.downleftBTN);
            this.controlPanel.Controls.Add(this.uprightBTN);
            this.controlPanel.Controls.Add(this.upleftBTN);
            this.controlPanel.Controls.Add(this.label4);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.levelLBL);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.scoreLBL);
            this.controlPanel.Controls.Add(this.pauseBTN);
            this.controlPanel.Controls.Add(this.startBTN);
            this.controlPanel.Controls.Add(this.modeLBL);
            this.controlPanel.Controls.Add(this.timerLBL);
            this.controlPanel.Controls.Add(this.upBTN);
            this.controlPanel.Controls.Add(this.leftBTN);
            this.controlPanel.Controls.Add(this.downBTN);
            this.controlPanel.Controls.Add(this.rightBTN);
            this.controlPanel.Location = new System.Drawing.Point(248, 391);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(827, 198);
            this.controlPanel.TabIndex = 18;
            // 
            // speedLBL
            // 
            this.speedLBL.AutoSize = true;
            this.speedLBL.BackColor = System.Drawing.Color.FloralWhite;
            this.speedLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.speedLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLBL.Location = new System.Drawing.Point(109, 146);
            this.speedLBL.Name = "speedLBL";
            this.speedLBL.Size = new System.Drawing.Size(41, 22);
            this.speedLBL.TabIndex = 36;
            this.speedLBL.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Timer";
            // 
            // finishBTN
            // 
            this.finishBTN.BackColor = System.Drawing.Color.Gold;
            this.finishBTN.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.finishBTN.Location = new System.Drawing.Point(604, 117);
            this.finishBTN.Margin = new System.Windows.Forms.Padding(4);
            this.finishBTN.Name = "finishBTN";
            this.finishBTN.Size = new System.Drawing.Size(114, 49);
            this.finishBTN.TabIndex = 34;
            this.finishBTN.Text = "Finish";
            this.finishBTN.UseVisualStyleBackColor = false;
            this.finishBTN.Click += new System.EventHandler(this.finishBTN_Click);
            // 
            // downrightBTN
            // 
            this.downrightBTN.BackColor = System.Drawing.Color.Gold;
            this.downrightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downrightBTN.Location = new System.Drawing.Point(427, 111);
            this.downrightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downrightBTN.Name = "downrightBTN";
            this.downrightBTN.Size = new System.Drawing.Size(43, 40);
            this.downrightBTN.TabIndex = 33;
            this.downrightBTN.Text = "🢆";
            this.downrightBTN.UseVisualStyleBackColor = false;
            this.downrightBTN.Click += new System.EventHandler(this.downrightBTN_Click);
            // 
            // downleftBTN
            // 
            this.downleftBTN.BackColor = System.Drawing.Color.Gold;
            this.downleftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downleftBTN.Location = new System.Drawing.Point(284, 112);
            this.downleftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downleftBTN.Name = "downleftBTN";
            this.downleftBTN.Size = new System.Drawing.Size(43, 40);
            this.downleftBTN.TabIndex = 32;
            this.downleftBTN.Text = "🢇";
            this.downleftBTN.UseVisualStyleBackColor = false;
            this.downleftBTN.Click += new System.EventHandler(this.downleftBTN_Click);
            // 
            // uprightBTN
            // 
            this.uprightBTN.BackColor = System.Drawing.Color.Gold;
            this.uprightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uprightBTN.Location = new System.Drawing.Point(427, 14);
            this.uprightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uprightBTN.Name = "uprightBTN";
            this.uprightBTN.Size = new System.Drawing.Size(43, 40);
            this.uprightBTN.TabIndex = 31;
            this.uprightBTN.Text = "🢅";
            this.uprightBTN.UseVisualStyleBackColor = false;
            this.uprightBTN.Click += new System.EventHandler(this.uprightBTN_Click);
            // 
            // upleftBTN
            // 
            this.upleftBTN.BackColor = System.Drawing.Color.Gold;
            this.upleftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upleftBTN.Location = new System.Drawing.Point(284, 14);
            this.upleftBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upleftBTN.Name = "upleftBTN";
            this.upleftBTN.Size = new System.Drawing.Size(43, 40);
            this.upleftBTN.TabIndex = 30;
            this.upleftBTN.Text = "🢄";
            this.upleftBTN.UseVisualStyleBackColor = false;
            this.upleftBTN.Click += new System.EventHandler(this.upleftBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 34);
            this.label2.TabIndex = 27;
            this.label2.Text = "Level";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.BackColor = System.Drawing.Color.FloralWhite;
            this.levelLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levelLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLBL.Location = new System.Drawing.Point(109, 21);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(21, 22);
            this.levelLBL.TabIndex = 26;
            this.levelLBL.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 25;
            this.label1.Text = "Score";
            // 
            // scoreLBL
            // 
            this.scoreLBL.Location = new System.Drawing.Point(93, 47);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(100, 23);
            this.scoreLBL.TabIndex = 28;
            // 
            // pauseBTN
            // 
            this.pauseBTN.BackColor = System.Drawing.Color.Gold;
            this.pauseBTN.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.pauseBTN.Location = new System.Drawing.Point(604, 60);
            this.pauseBTN.Margin = new System.Windows.Forms.Padding(4);
            this.pauseBTN.Name = "pauseBTN";
            this.pauseBTN.Size = new System.Drawing.Size(114, 49);
            this.pauseBTN.TabIndex = 23;
            this.pauseBTN.Text = "Pause";
            this.pauseBTN.UseVisualStyleBackColor = false;
            this.pauseBTN.Click += new System.EventHandler(this.pauseBTN_Click);
            // 
            // startBTN
            // 
            this.startBTN.BackColor = System.Drawing.Color.Gold;
            this.startBTN.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.startBTN.Location = new System.Drawing.Point(604, 4);
            this.startBTN.Margin = new System.Windows.Forms.Padding(4);
            this.startBTN.Name = "startBTN";
            this.startBTN.Size = new System.Drawing.Size(114, 49);
            this.startBTN.TabIndex = 22;
            this.startBTN.Text = "Start";
            this.startBTN.UseVisualStyleBackColor = false;
            this.startBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // modeLBL
            // 
            this.modeLBL.AutoSize = true;
            this.modeLBL.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLBL.Location = new System.Drawing.Point(334, 78);
            this.modeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeLBL.Name = "modeLBL";
            this.modeLBL.Size = new System.Drawing.Size(54, 19);
            this.modeLBL.TabIndex = 6;
            this.modeLBL.Text = "Status";
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BackColor = System.Drawing.Color.FloralWhite;
            this.timerLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.Location = new System.Drawing.Point(109, 103);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(21, 22);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "0";
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.Transparent;
            this.boardPanel.BackgroundImage = global::Snake.Properties.Resources.osaka_minions_theme_park_at_usj_170204;
            this.boardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boardPanel.Enabled = false;
            this.boardPanel.Location = new System.Drawing.Point(116, 13);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(1076, 326);
            this.boardPanel.TabIndex = 19;
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = global::Snake.Properties.Resources.bananas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 850);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.boardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TheGame";
            this.Text = "Snake Game";
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leftBTN;
        private System.Windows.Forms.Button downBTN;
        private System.Windows.Forms.Button upBTN;
        private System.Windows.Forms.Button rightBTN;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label modeLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Button pauseBTN;
        private System.Windows.Forms.Button startBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Button downrightBTN;
        private System.Windows.Forms.Button downleftBTN;
        private System.Windows.Forms.Button uprightBTN;
        private System.Windows.Forms.Button upleftBTN;
        private System.Windows.Forms.Button finishBTN;
        private System.Windows.Forms.Label speedLBL;
        private System.Windows.Forms.Label label5;
    }
}

