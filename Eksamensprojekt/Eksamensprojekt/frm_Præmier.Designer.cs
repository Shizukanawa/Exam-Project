namespace Eksamensprojekt
{
    partial class frm_Præmier
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
            this.ptb_GrayPrize = new System.Windows.Forms.PictureBox();
            this.ptb_LightBluePrize = new System.Windows.Forms.PictureBox();
            this.ptb_DarkBluePrize = new System.Windows.Forms.PictureBox();
            this.ptb_PurplePrize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_GrayPrize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LightBluePrize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DarkBluePrize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_PurplePrize)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_GrayPrize
            // 
            this.ptb_GrayPrize.Location = new System.Drawing.Point(13, 13);
            this.ptb_GrayPrize.Name = "ptb_GrayPrize";
            this.ptb_GrayPrize.Size = new System.Drawing.Size(120, 120);
            this.ptb_GrayPrize.TabIndex = 0;
            this.ptb_GrayPrize.TabStop = false;
            this.ptb_GrayPrize.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptb_LightBluePrize
            // 
            this.ptb_LightBluePrize.Location = new System.Drawing.Point(13, 139);
            this.ptb_LightBluePrize.Name = "ptb_LightBluePrize";
            this.ptb_LightBluePrize.Size = new System.Drawing.Size(120, 120);
            this.ptb_LightBluePrize.TabIndex = 1;
            this.ptb_LightBluePrize.TabStop = false;
            this.ptb_LightBluePrize.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ptb_DarkBluePrize
            // 
            this.ptb_DarkBluePrize.Location = new System.Drawing.Point(13, 265);
            this.ptb_DarkBluePrize.Name = "ptb_DarkBluePrize";
            this.ptb_DarkBluePrize.Size = new System.Drawing.Size(120, 120);
            this.ptb_DarkBluePrize.TabIndex = 2;
            this.ptb_DarkBluePrize.TabStop = false;
            // 
            // ptb_PurplePrize
            // 
            this.ptb_PurplePrize.Location = new System.Drawing.Point(12, 391);
            this.ptb_PurplePrize.Name = "ptb_PurplePrize";
            this.ptb_PurplePrize.Size = new System.Drawing.Size(120, 120);
            this.ptb_PurplePrize.TabIndex = 3;
            this.ptb_PurplePrize.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "50 Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "100 Point";
            // 
            // frm_Præmier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_PurplePrize);
            this.Controls.Add(this.ptb_DarkBluePrize);
            this.Controls.Add(this.ptb_LightBluePrize);
            this.Controls.Add(this.ptb_GrayPrize);
            this.Name = "frm_Præmier";
            this.Text = "Præmier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Præmier_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_GrayPrize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_LightBluePrize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DarkBluePrize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_PurplePrize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_GrayPrize;
        private System.Windows.Forms.PictureBox ptb_LightBluePrize;
        private System.Windows.Forms.PictureBox ptb_DarkBluePrize;
        private System.Windows.Forms.PictureBox ptb_PurplePrize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}