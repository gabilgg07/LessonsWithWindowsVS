
namespace GetDirectoriesFromDisks
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
            this.btnFromC = new System.Windows.Forms.Button();
            this.btnFromD = new System.Windows.Forms.Button();
            this.lstDirs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFromC
            // 
            this.btnFromC.Location = new System.Drawing.Point(42, 40);
            this.btnFromC.Name = "btnFromC";
            this.btnFromC.Size = new System.Drawing.Size(205, 88);
            this.btnFromC.TabIndex = 0;
            this.btnFromC.Text = "From C:";
            this.btnFromC.UseVisualStyleBackColor = true;
            this.btnFromC.Click += new System.EventHandler(this.btnFromC_Click);
            // 
            // btnFromD
            // 
            this.btnFromD.Location = new System.Drawing.Point(42, 324);
            this.btnFromD.Name = "btnFromD";
            this.btnFromD.Size = new System.Drawing.Size(205, 88);
            this.btnFromD.TabIndex = 1;
            this.btnFromD.Text = "From D:";
            this.btnFromD.UseVisualStyleBackColor = true;
            this.btnFromD.Click += new System.EventHandler(this.btnFromD_Click);
            // 
            // lstDirs
            // 
            this.lstDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDirs.FormattingEnabled = true;
            this.lstDirs.ItemHeight = 16;
            this.lstDirs.Location = new System.Drawing.Point(253, 40);
            this.lstDirs.Name = "lstDirs";
            this.lstDirs.Size = new System.Drawing.Size(541, 372);
            this.lstDirs.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDirs);
            this.Controls.Add(this.btnFromD);
            this.Controls.Add(this.btnFromC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFromC;
        private System.Windows.Forms.Button btnFromD;
        private System.Windows.Forms.ListBox lstDirs;
    }
}

