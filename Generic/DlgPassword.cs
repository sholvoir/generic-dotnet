using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vultrue.Generic
{
    public partial class DlgPassword : Form
    {
        private Credential credential;

        /// <summary>
        /// ����
        /// </summary>
        public DlgPassword(Credential credential)
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
        /// �����û���, ֱ�Ӷ�λ�������
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
            if (textBoxNewPassword.Text.Length == 0)
            {
                MessageBox.Show("������������", "��������");
                textBoxNewPassword.Focus();
                return;
            }
            if (new Regex(credential.PasswordRestrict).Match(textBoxNewPassword.Text).Success)
            {
                MessageBox.Show("�����ʽ����", "��������");
                textBoxNewPassword.Focus();
                return;
            }
            if (textBoxNewPassword.Text != textBoxConfirmPassowrd.Text)
            {
                MessageBox.Show("�����������벻һ��", "��������");
                textBoxConfirmPassowrd.Focus();
                return;
            }
            credential.Password = textBoxPassword.Text;
            credential.NewUserName = textBoxUserName.Text;
            credential.NewPassword = textBoxNewPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}