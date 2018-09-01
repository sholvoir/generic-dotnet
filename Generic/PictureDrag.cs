using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace Vultrue.Generic
{
    public partial class PictureDrag : UserControl
    {
        #region 变量
        private Image image1;
        private Image image2;
        private Color backColor;
        private Color activebackColor = Color.LightBlue;
        private Point mousePoint;
        private bool isMouseDown = false;
        private bool isSelected = false;
        private int twinkleTime = 0;
        #endregion

        #region 构造

        /// <summary>
        /// 构造可拖放的图形文本控件
        /// </summary>
        public PictureDrag()
        {
            InitializeComponent();
            base.Click += new EventHandler(PictureTrans_Click);
            base.DoubleClick += new EventHandler(PictureTrans_DoubleClick);
            this.Disposed += new EventHandler(PictureDrag_Disposed);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureDrag_Load(object sender, EventArgs e)
        {
            backColor = BackColor;
        }

        /// <summary>
        /// 销毁处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureDrag_Disposed(object sender, EventArgs e)
        {
            twinkleTime = 0;
        }

        #endregion

        #region 属性

        /// <summary>
        /// 获取或设置由Vultrue.Generic.PictureDrag显示的文本
        /// </summary>
        [Browsable(true)]
        [SettingsBindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return labelTrans.Text; }
            set { labelTrans.Text = value; }
        }

        /// <summary>
        /// 获取或设置由Vultrue.Generic.PictureDrag显示的图像
        /// </summary>
        [DefaultValue(null)]
        public Image Image1
        {
            get { return image1; }
            set { pictureBoxTrans.Image = image1 = value; }
        }

        /// <summary>
        /// 获取或设置由Vultrue.Generic.PictureDrag闪烁时的显示的图像
        /// </summary>
        [DefaultValue(null)]
        public Image Image2
        {
            get { return image2; }
            set { image2 = value; }
        }

        /// <summary>
        /// 获取或设置由Vultrue.Generic.PictureDrag的闪烁时间
        /// </summary>
        [DefaultValue(0)]
        public int TwinkleTime
        {
            get { return twinkleTime; }
            set
            {
                if (value < 0) throw new Exception("TwinkleTime必须大于0");
                if (twinkleTime == 0 && value > 0) { twinkleTime = value; twinkle(); }
                else twinkleTime = value;
            }
        }

        /// <summary>
        /// 激活时的背景色
        /// </summary>
        public Color ActiveBackColor
        {
            get { return activebackColor; }
            set { activebackColor = value; }
        }

        [Browsable(false)]
        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }
        }

        /// <summary>
        /// 拖放开始时的鼠标位置
        /// </summary>
        [Browsable(false)]
        public Point MousePoint
        {
            get { return mousePoint; }
        }

        #endregion

        #region 事件

        /// <summary>
        /// 在单击控件是发生
        /// </summary>
        public new event EventHandler Click;

        /// <summary>
        /// 在双击控件时发生
        /// </summary>
        public new event EventHandler DoubleClick;

        #endregion

        #region 核心处理

        /// <summary>
        /// 闪烁处理
        /// </summary>
        private void twinkle()
        {
            new Thread(delegate()
            {
                while (twinkleTime > 0)
                {
                    pictureBoxTrans.Image = image2;
                    Thread.Sleep(twinkleTime);
                    pictureBoxTrans.Image = image1;
                    Thread.Sleep(twinkleTime);
                }
            }).Start();
        }

        /// <summary>
        /// 鼠标按下处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureTrans_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePoint = PointToClient(((Control)sender).PointToScreen(e.Location));
                isMouseDown = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (Click != null) Click(this, e);
            }
        }

        /// <summary>
        /// 鼠标弹起处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureTrans_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        /// <summary>
        /// 鼠标移动处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureTrans_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                isMouseDown = false;
                DoDragDrop(this, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        /// <summary>
        /// 鼠标单击处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureTrans_Click(object sender, EventArgs e)
        {
            if (Click != null) Click(this, e);
        }

        /// <summary>
        /// 鼠标双击处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureTrans_DoubleClick(object sender, EventArgs e)
        {
            if (DoubleClick != null) DoubleClick(this, e);
        }

        /// <summary>
        /// 鼠标进入处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureTrans_MouseEnter(object sender, EventArgs e)
        {
            BackColor = activebackColor; ;
        }

        /// <summary>
        /// 鼠标离开处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureTrans_MouseLeave(object sender, EventArgs e)
        {
            if (!isSelected) BackColor = backColor;
        }

        #endregion
    }
}
