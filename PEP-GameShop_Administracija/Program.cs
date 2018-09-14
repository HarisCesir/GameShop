using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEP_GameShop_Administracija
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

                Application.Run(new frmMain());
            }
        }
    }
}
