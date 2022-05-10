using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetDirectoriesFromDisks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFromC_Click(object sender, EventArgs e)
        {
            // burda yazdigimiz kodlar ancaq bu buttonda istifade edildiyi ucun
            // ayrica method yazmagimiza ehtiyac yoxdur.
            // Anonymous methodla RunSafe delegatemize oture bilerik:
            RunSafe(delegate {
                string[] dirs = Directory.GetDirectories("C:\\");

                lstDirs.Items.Clear();

                foreach (var item in dirs)
                {
                    lstDirs.Items.Add(item);
                }
            });

            // Anonymous methodlarin parametr qebul eden formada:

            Action<string> tAction = delegate (string str)
            {
                MessageBox.Show($"Anonymous method's parametr value is: {str}");
            };

            tAction("AnonymousMethodSValue");
        }

        private void btnFromD_Click(object sender, EventArgs e)
        {
            // Lambda methods:
            // => isaresi Lambda isaresi adlanir.
            // if-deki basqadi.
            // () methodun bodisi {} bu olsun deyende Lambda isaresi sayilir.
            // Asp.Net de cox istifade edilecek.
            RunSafe(() => {
                string[] dirs = Directory.GetDirectories("D:\\");

                lstDirs.Items.Clear();

                foreach (var item in dirs)
                {
                    lstDirs.Items.Add(item);
                }
            });

            // Lambda methodlarin parametr qebul eden formasi:
            Action<int> tAction = (int x) =>
            {
                MessageBox.Show($"Lambda method's parametr value is: {x}");
            };

            tAction(11);
        }

        // Bele bir method yazirik ki, tehlukesis button clicklerimizi islede bilek.
        // Nese problem olanda partlamasin, mesaj kimi mene gostersin.

        // callback methods adlanir.
        // yeni argument kimi gonderilmis method (bodyde) cagrilir,
        // harda gonderilibse orada isleyir.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action">Is callback method</param>
        void RunSafe(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Xeta", 0, MessageBoxIcon.Error);
            }
        }
    }
}
