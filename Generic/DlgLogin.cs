using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vultrue.Generic {
    public partial class DlgLogin : Form
    {
        private Credential credential;

        /// <summary>
        /// 构造
        /// </summary>
        public DlgLogin(Credential credential)
        {
            InitializeComponent();
            this.credential = credential;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DlgLogin_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = credential.UserName;
        }

        /// <summary>
        /// 重新登录时, 直接定位到密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DlgLogin_Shown(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Length > 0) textBoxPassword.Focus();
        }

        /// <summary>
        /// 验证密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Length == 0)
            {
                MessageBox.Show("请输入用户名", "发生错误");
                textBoxUserName.Focus();
                return;
            }
            if (new Regex(credential.UserNameRestrict).Match(textBoxUserName.Text).Success)
            {
                MessageBox.Show("用户名格式错误", "发生错误");
                textBoxUserName.Focus();
                return;
            }
            if (textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("请输入密码", "发生错误");
                textBoxPassword.Focus();
                return;
            }
            if (new Regex(credential.PasswordRestrict).Match(textBoxPassword.Text).Success)
            {
                MessageBox.Show("密码格式错误", "发生错误");
                textBoxPassword.Focus();
                return;
            }
            credential.UserName = textBoxUserName.Text;
            credential.Password = textBoxPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    public class Credential
    {
        public Credential()
        {
            UserName = "";
            Password = "";
            NewUserName = "";
            NewPassword = "";
            UserNameRestrict = @"\W+";
            PasswordRestrict = @"\W+";
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string NewUserName { get; set; }
        public string NewPassword { get; set; }
        public string UserNameRestrict { get; set; }
        public string PasswordRestrict { get; set; }
    }
}