using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezziresto.PL.Settings
{
    public partial class Form_Settings : DevExpress.XtraEditors.XtraForm
    {
        BL.Setting.Setting setting = new BL.Setting.Setting();
        int setting_id = 30;
        string lang = "en";

        public Form_Settings()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            DataTable tb = setting.get_setting_by_id(this.setting_id);
            if (tb.Rows.Count > 0)
            {
                txtCompany.Text = tb.Rows[0]["company"].ToString();
                txtTell.Text = tb.Rows[0]["tell"].ToString();
                txtPhone.Text = tb.Rows[0]["phone"].ToString();
                txtEmail.Text = tb.Rows[0]["email"].ToString();
                txtAddress.Text = tb.Rows[0]["address"].ToString();
                pictureEdit.EditValue = tb.Rows[0]["logo"];
                txtAccountN.Text = tb.Rows[0]["account_n"].ToString();
                txtBank.Text = tb.Rows[0]["bank"].ToString();
                txtSwiftCode.Text = tb.Rows[0]["swift_code"].ToString();
                txtCardPayment.Text = tb.Rows[0]["card_payment"].ToString();
                txtPointMoney.Text = tb.Rows[0]["point_money"].ToString();
                soundEffect.Text = tb.Rows[0]["sound"].ToString();

                if (tb.Rows[0]["lang"].ToString() == "fr-FR")
                {
                    txtLanguage.SelectedIndex = 0;
                }
                else if (tb.Rows[0]["lang"].ToString() == "en")
                {
                    txtLanguage.SelectedIndex = 1;
                }
                else if (tb.Rows[0]["lang"].ToString() == "ar")
                {
                    txtLanguage.SelectedIndex = 2;
                }
            }
        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dxValidationData.Validate())
            {
                byte[] bytes;

                MemoryStream stream = new MemoryStream();
                pictureEdit.Image.Save(stream, ImageFormat.Jpeg);
                bytes = stream.ToArray();

                setting.update_setting(
                    setting_id,
                    txtCompany.Text,
                    txtTell.Text,
                    txtTell.Text,
                    txtEmail.Text,
                    txtAddress.Text,
                    bytes,
                    lang,
                    txtAccountN.Text,
                    txtBank.Text,
                    txtSwiftCode.Text,
                    txtCardPayment.Text,
                    txtPointMoney.Text,
                    soundEffect.EditValue.ToString()
                    );

                Properties.Settings.Default.pointMoney = txtPointMoney.Text;
                Properties.Settings.Default.sound = soundEffect.EditValue.ToString();

                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"c:\Added.wav");
                    simpleSound.Play();
                }
            }
            else
            {
                if (Properties.Settings.Default.sound == "yes")
                {
                    SoundPlayer simpleSound = new SoundPlayer(@"c:\ValidationError.wav");
                    simpleSound.Play();
                }
            }
        }

        private void txtLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtLanguage.SelectedIndex == 0)
            {
                Properties.Settings.Default.lang = "fr-FR";
                lang = "fr";
                SoundPlayer selected = new SoundPlayer(@"c:\Wrong.wav");
                selected.Play();
            }
            else if (txtLanguage.SelectedIndex == 1)
            {
                Properties.Settings.Default.lang = "en";
                lang = "en";
                SoundPlayer selected = new SoundPlayer(@"c:\Wrong.wav");
                selected.Play();
            }
            else if (txtLanguage.SelectedIndex == 2)
            {
                Properties.Settings.Default.lang = "ar";
                lang = "ar";
                SoundPlayer selected = new SoundPlayer(@"c:\Wrong.wav");
                selected.Play();
            }
        }
    }
}