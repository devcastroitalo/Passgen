using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Passgen
{
    public partial class Frm_Main : Form
    {
        public string Password { get; set; }

        public Frm_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates password until the password generated be classified as Secure
        /// </summary>
        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            CheckPasswordStrength checkPassword = new CheckPasswordStrength();

            while (true)
            {
                this.Password = Generator.Generate(this.Ckb_Numbers.Checked, this.Ckb_Symbols.Checked);

                if (checkPassword.GetPasswordStrength(this.Password).ToString() == "Secure")
                {
                    break;
                }
            }

            this.Txt_Password.Text = this.Password;
        }

        /// <summary>
        /// Copy the generated password to clipboard only if there is a password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Clipboard_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.Password))
            {
                MessageBox.Show("No password generated", "Passgen", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Clipboard.SetText(this.Password);
            MessageBox.Show("Password copied to clipboard", "Passgen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
