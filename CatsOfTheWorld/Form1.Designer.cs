namespace CatsOfTheWorld
{
    partial class Form1
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
            this.txtCat = new System.Windows.Forms.TextBox();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.lbCatsOnFile = new System.Windows.Forms.ListBox();
            this.lblCatsOnFile = new System.Windows.Forms.Label();
            this.btnCopyCats = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCopyCats);
            this.Controls.Add(this.lblCatsOnFile);
            this.Controls.Add(this.lbCatsOnFile);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.txtCat);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

