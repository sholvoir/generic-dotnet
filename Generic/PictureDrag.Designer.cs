namespace Vultrue.Generic
{
    partial class PictureDrag
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTrans = new System.Windows.Forms.PictureBox();
            this.labelTrans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrans
            // 
            this.pictureBoxTrans.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxTrans.Location = new System.Drawing.Point(16, 8);
            this.pictureBoxTrans.Name = "pictureBoxTrans";
            this.pictureBoxTrans.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTrans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTrans.TabIndex = 0;
            this.pictureBoxTrans.TabStop = false;
            this.pictureBoxTrans.DoubleClick += new System.EventHandler(this.PictureTrans_DoubleClick);
            this.pictureBoxTrans.MouseLeave += new System.EventHandler(this.PictureTrans_MouseLeave);
            this.pictureBoxTrans.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseMove);
            this.pictureBoxTrans.Click += new System.EventHandler(this.PictureTrans_Click);
            this.pictureBoxTrans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseDown);
            this.pictureBoxTrans.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseUp);
            this.pictureBoxTrans.MouseEnter += new System.EventHandler(this.PictureTrans_MouseEnter);
            // 
            // labelTrans
            // 
            this.labelTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTrans.AutoSize = true;
            this.labelTrans.Location = new System.Drawing.Point(4, 48);
            this.labelTrans.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.labelTrans.MaximumSize = new System.Drawing.Size(56, 48);
            this.labelTrans.MinimumSize = new System.Drawing.Size(56, 12);
            this.labelTrans.Name = "labelTrans";
            this.labelTrans.Size = new System.Drawing.Size(56, 12);
            this.labelTrans.TabIndex = 1;
            this.labelTrans.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTrans.MouseLeave += new System.EventHandler(this.PictureTrans_MouseLeave);
            this.labelTrans.DoubleClick += new System.EventHandler(this.PictureTrans_DoubleClick);
            this.labelTrans.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseMove);
            this.labelTrans.Click += new System.EventHandler(this.PictureTrans_Click);
            this.labelTrans.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseDown);
            this.labelTrans.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseUp);
            this.labelTrans.MouseEnter += new System.EventHandler(this.PictureTrans_MouseEnter);
            // 
            // PictureDrag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labelTrans);
            this.Controls.Add(this.pictureBoxTrans);
            this.MaximumSize = new System.Drawing.Size(64, 80);
            this.MinimumSize = new System.Drawing.Size(64, 72);
            this.Name = "PictureDrag";
            this.Size = new System.Drawing.Size(64, 72);
            this.Load += new System.EventHandler(this.PictureDrag_Load);
            this.MouseLeave += new System.EventHandler(this.PictureTrans_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureTrans_MouseUp);
            this.MouseEnter += new System.EventHandler(this.PictureTrans_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrans;
        private System.Windows.Forms.Label labelTrans;
    }
}
