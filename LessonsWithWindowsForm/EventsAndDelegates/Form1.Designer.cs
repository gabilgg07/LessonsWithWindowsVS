
using System;
using System.Windows.Forms;

namespace EventsAndDelegates
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
            this.lblFullname = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.btnAddFullname = new System.Windows.Forms.Button();
            this.listFullname = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFullname
            // 
            this.lblFullname.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFullname.Location = new System.Drawing.Point(65, 27);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(100, 25);
            this.lblFullname.TabIndex = 0;
            this.lblFullname.Text = "Ad Soyad";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFullname.Click += new System.EventHandler(this.lblFullname_Click);
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFullname.Location = new System.Drawing.Point(65, 66);
            this.txtFullname.Margin = new System.Windows.Forms.Padding(10);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(220, 30);
            this.txtFullname.TabIndex = 1;
            this.txtFullname.TextChanged += new System.EventHandler(this.txtFullname_TextChanged);
            this.txtFullname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullname_KeyPressEnter);
            // 
            // btnAddFullname
            // 
            this.btnAddFullname.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFullname.Location = new System.Drawing.Point(65, 125);
            this.btnAddFullname.Name = "btnAddFullname";
            this.btnAddFullname.Size = new System.Drawing.Size(220, 39);
            this.btnAddFullname.TabIndex = 2;
            this.btnAddFullname.Text = "Add";
            this.btnAddFullname.UseVisualStyleBackColor = false;

            // DotNet 2 parametrli method qebul eden EventHandler adli delegate hazirlayib:
            // object(ve ya her hansi bir konkret tip) sender, EventArg e.

            // delegte - ler de referance type-dir.

            //this.btnAddFullname.Click += new System.EventHandler(this.btnAddFullname_Click);
            // 
            // listFullname
            // 
            this.listFullname.BackColor = System.Drawing.Color.Silver;
            this.listFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFullname.ForeColor = System.Drawing.SystemColors.Info;
            this.listFullname.FormattingEnabled = true;
            this.listFullname.ItemHeight = 29;
            this.listFullname.Location = new System.Drawing.Point(458, 27);
            this.listFullname.Name = "listFullname";
            this.listFullname.Size = new System.Drawing.Size(294, 381);
            this.listFullname.TabIndex = 3;
            this.listFullname.SelectedIndexChanged += new System.EventHandler(this.listFullname_SelectedIndexChanged);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(68, 192);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(217, 45);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.listFullname);
            this.Controls.Add(this.btnAddFullname);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.lblFullname);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "EventDelegate";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnAddFullname;
        private System.Windows.Forms.ListBox listFullname;
        private Button btn2;
    }
}

