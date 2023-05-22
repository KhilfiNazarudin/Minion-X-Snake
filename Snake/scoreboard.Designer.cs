namespace Snake
{
    partial class scoreboard
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
            this.theDGV = new System.Windows.Forms.DataGridView();
            this.savescore = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.theDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // theDGV
            // 
            this.theDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theDGV.GridColor = System.Drawing.Color.Gold;
            this.theDGV.Location = new System.Drawing.Point(12, 65);
            this.theDGV.Name = "theDGV";
            this.theDGV.RowHeadersWidth = 51;
            this.theDGV.RowTemplate.Height = 24;
            this.theDGV.Size = new System.Drawing.Size(390, 178);
            this.theDGV.TabIndex = 0;
            this.theDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.theDGV_CellContentClick);
            // 
            // savescore
            // 
            this.savescore.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savescore.Location = new System.Drawing.Point(12, 386);
            this.savescore.Name = "savescore";
            this.savescore.Size = new System.Drawing.Size(159, 115);
            this.savescore.TabIndex = 1;
            this.savescore.Text = "Save your score?";
            this.savescore.UseVisualStyleBackColor = true;
            this.savescore.Click += new System.EventHandler(this.savescore_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(254, 386);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(148, 115);
            this.close.TabIndex = 2;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.scoreoardimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 744);
            this.Controls.Add(this.close);
            this.Controls.Add(this.savescore);
            this.Controls.Add(this.theDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "scoreboard";
            this.Text = "Scoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.theDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView theDGV;
        private System.Windows.Forms.Button savescore;
        private System.Windows.Forms.Button close;
    }
}