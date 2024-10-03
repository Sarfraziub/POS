using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ezziresto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BL.Setting.Setting setting = new BL.Setting.Setting();
            DataTable dt = setting.get_setting_by_id();
            Properties.Settings.Default.lang = dt.Rows[0]["lang"].ToString();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PL.Auth.Form_Login());
        }
    }
}
