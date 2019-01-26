namespace Vultrue.Generic
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureDrag1 = new Vultrue.Generic.PictureDrag();
            this.SuspendLayout();
            // 
            // pictureDrag1
            // 
            this.pictureDrag1.AutoSize = true;
            this.pictureDrag1.BackColor = System.Drawing.Color.Transparent;
            this.pictureDrag1.Image1 = global::Vultrue.Generic.Properties.Resources.Transformer1;
            this.pictureDrag1.Image2 = global::Vultrue.Generic.Properties.Resources.Transformer2;
            this.pictureDrag1.Location = new System.Drawing.Point(200, 144);
            this.pictureDrag1.MinimumSize = new System.Drawing.Size(64, 72);
            this.pictureDrag1.Name = "pictureDrag1";
            this.pictureDrag1.Size = new System.Drawing.Size(64, 80);
            this.pictureDrag1.TabIndex = 0;
            this.pictureDrag1.Text = "pictureDrag1";
            this.pictureDrag1.DoubleClick += new System.EventHandler(this.pictureDrag1_DoubleClick);
            this.pictureDrag1.Click += new System.EventHandler(this.pictureDrag1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 505);
            this.Controls.Add(this.pictureDrag1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureDrag pictureDrag1;

    }
}

