namespace Snake
{
    partial class addscoreform
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addscoreBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name:";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.Location = new System.Drawing.Point(56, 163);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(168, 31);
            this.nameTB.TabIndex = 1;
            this.nameTB.Tag = "";
            this.nameTB.Text = "Name";
            // 
            // addscoreBTN
            // 
            this.addscoreBTN.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addscoreBTN.Location = new System.Drawing.Point(56, 248);
            this.addscoreBTN.Name = "addscoreBTN";
            this.addscoreBTN.Size = new System.Drawing.Size(168, 44);
            this.addscoreBTN.TabIndex = 2;
            this.addscoreBTN.Text = "Add score";
            this.addscoreBTN.UseVisualStyleBackColor = true;
            this.addscoreBTN.Click += new System.EventHandler(this.addscoreBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBTN.Location = new System.Drawing.Point(56, 315);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(168, 42);
            this.cancelBTN.TabIndex = 3;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // addscoreform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Snake.Properties.Resources.addscoreformimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.addscoreBTN);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "addscoreform";
            this.Text = "addscoreform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button addscoreBTN;
        private System.Windows.Forms.Button cancelBTN;
    }
}