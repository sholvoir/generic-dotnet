using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vultrue.Generic
{
    public partial class DlgServiceUri : Form
    {
        private ServiceUri serviceUri;

        public DlgServiceUri(ServiceUri serviceUri)
        {
            InitializeComponent();
            this.serviceUri = serviceUri;
        }

        private void DlgServiceUri_Load(object sender, EventArgs e)
        {
            textBoxServer.Text = serviceUri.Server;
            textBoxPort.Text = serviceUri.Port.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxServer.Text.Length == 0)
            {
                MessageBox.Show("请输入服务器名或IP地址", "发生错误");
                textBoxServer.Focus();
                return;
            }
            if (new Regex(@"[^a-zA-Z_.0-9]+").Match(textBoxServer.Text).Success)
            {
                MessageBox.Show("服务器格式错误", "发生错误");
                textBoxServer.Focus();
                return;
            }
            if (textBoxPort.Text.Length == 0)
            {
                MessageBox.Show("请输入服务端口号", "发生错误");
                textBoxPort.Focus();
                return;
            }
            if (new Regex(@"[^0-9]+").Match(textBoxPort.Text).Success
                || textBoxPort.Text.Length > 5)
            {
                MessageBox.Show("服务端口号为1024-65525之间的一个整数", "发生错误");
                textBoxPort.Focus();
                return;
            }
            serviceUri.Server = textBoxServer.Text;
            serviceUri.Port = int.Parse(textBoxPort.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    public class ServiceUri
    {
        public string Server { get; set; }
        public int Port { get; set; }

        public ServiceUri()
        {
            Server = "localhost";
            Port = 80;
        }

        public ServiceUri(string server, int port)
        {
            Server = server;
            Port = port;
        }
    }

}
