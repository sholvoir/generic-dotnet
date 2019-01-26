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
        /// ����
        /// </summary>
        public DlgLogin(Credential credential)
        {
            InitializeComponent();
            this.credential = credential;
        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DlgLogin_Load(object sender, EventArgs e)
        {
            textBoxUserName.Text = credential.UserName;
        }

        /// <summary>
        /// ���µ�¼ʱ, ֱ�Ӷ�λ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DlgLogin_Shown(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Length > 0) textBoxPassword.Focus();
        }

        /// <summary>
        /// ��֤����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Length == 0)
            {
                MessageBox.Show("�������û���", "��������");
                textBoxUserName.Focus();
                return;
            }
            if (new Regex(credential.UserNameRestrict).Match(textBoxUserName.Text).Success)
            {
                MessageBox.Show("�û�����ʽ����", "��������");
                textBoxUserName.Focus();
                return;
            }
            if (textBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("����������", "��������");
                textBoxPassword.Focus();
                return;
            }
            if (new Regex(credential.PasswordRestrict).Match(textBoxPassword.Text).Success)
            {
                MessageBox.Show("�����ʽ����", "��������");
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