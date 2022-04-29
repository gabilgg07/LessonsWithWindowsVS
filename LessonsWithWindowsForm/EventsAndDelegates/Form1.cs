using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsAndDelegates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Form-un constructor-u

            // btnAddFullname button-umuzda .MouseDown event-i bas verdikde
            // btnAddFullname_MouseRightClick methodunu icra et.
            btnAddFullname.MouseDown += btnAddFullname_MouseRightClick;

            // 2 event 1 methodu cagirir:
            btnAddFullname.Click += btnAddFullname_Click;
            btn2.Click += btnAddFullname_Click;
        }

        private void btnAddFullname_MouseRightClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Mouse Right Clicked");
            }
        }

        private void lblFullname_Click(object sender, EventArgs e)
        {
            txtFullname.Focus();
        }


        private void txtFullname_TextChanged(object sender, EventArgs e)
        {
            if (listFullname.Items.Contains(txtFullname.Text.Trim()))
            {
                this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(30)))), ((int)(((byte)(4)))));
            }
            else
            {
                this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }
        }

        private void txtFullname_KeyPressEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                AddFullname();
            }
        }

        private void btnAddFullname_Click(object sender, EventArgs e)
        {
            // sender tezyiq olunani (burada click olunan buttonu) qaytarir.

            // as safe casting
            Button b = sender as Button;

            if (b != null)
            {
                // hansi button basilarsa onun adini qaytarir. ona gore is gorulur:
                string strText = b.Text;
                if (strText == "Add")
                {
                    AddFullname();
                }
                MessageBox.Show(strText);
            }
            
        }

        private void listFullname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddFullname()
        {
            string fullname = txtFullname.Text.Trim();

            if (!string.IsNullOrWhiteSpace(fullname))
            {
                if (listFullname.Items.Contains(txtFullname.Text.Trim()))
                {
                    MessageBox.Show("Bu ad ve soyaddan artiq var!");
                }
                else
                {
                    listFullname.Items.Add(fullname);
                }
            }
            else
            {
                MessageBox.Show("Xanani bos qoymayin!");
            }

            txtFullname.Text = "";
        }

    }
}
