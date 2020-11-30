namespace CatsOfTheWorld
{
    partial class frmCatsOfTheWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatsOfTheWorld));
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.lbCatsOnFile = new System.Windows.Forms.ListBox();
            this.lblCatsOnFile = new System.Windows.Forms.Label();
            this.btnCopyCats = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(146, 127);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(156, 20);
            this.txtCat.TabIndex = 0;
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(114, 130);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(23, 13);
            this.lblCat.TabIndex = 1;
            this.lblCat.Text = "Cat";
            this.lblCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(318, 123);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddCat.TabIndex = 2;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // lbCatsOnFile
            // 
            this.lbCatsOnFile.FormattingEnabled = true;
            this.lbCatsOnFile.Location = new System.Drawing.Point(146, 262);
            this.lbCatsOnFile.Name = "lbCatsOnFile";
            this.lbCatsOnFile.Size = new System.Drawing.Size(120, 95);
            this.lbCatsOnFile.TabIndex = 3;
            // 
            // lblCatsOnFile
            // 
            this.lblCatsOnFile.AutoSize = true;
            this.lblCatsOnFile.Location = new System.Drawing.Point(76, 262);
            this.lblCatsOnFile.Name = "lblCatsOnFile";
            this.lblCatsOnFile.Size = new System.Drawing.Size(64, 13);
            this.lblCatsOnFile.TabIndex = 4;
            this.lblCatsOnFile.Text = "Cats On File";
            this.lblCatsOnFile.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCopyCats
            // 
            this.btnCopyCats.Location = new System.Drawing.Point(288, 262);
            this.btnCopyCats.Name = "btnCopyCats";
            this.btnCopyCats.Size = new System.Drawing.Size(75, 23);
            this.btnCopyCats.TabIndex = 5;
            this.btnCopyCats.Text = "Copy Cats";
            this.btnCopyCats.UseVisualStyleBackColor = true;
            this.btnCopyCats.Click += new System.EventHandler(this.btnCopyCats_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 392);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmCatsOfTheWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCopyCats);
            this.Controls.Add(this.lblCatsOnFile);
            this.Controls.Add(this.lbCatsOnFile);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtCat);
            this.Name = "frmCatsOfTheWorld";
            this.Text = "Cats Of The World";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.ListBox lbCatsOnFile;
        private System.Windows.Forms.Label lblCatsOnFile;
        private System.Windows.Forms.Button btnCopyCats;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

