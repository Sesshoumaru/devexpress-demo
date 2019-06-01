namespace XtraEditorsDemo
{
    partial class LableControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LableControlForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelControl1.Location = new System.Drawing.Point(21, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(283, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "<b>Click</b> <href=\"http://www.devexpress.com\">www.devexpress.com</href>  to open" +
    " our web site.";
            this.labelControl1.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.labelControl1_HyperlinkClick);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl2.Appearance.Image")));
            this.labelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl2.Location = new System.Drawing.Point(21, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "labelControl2";
            // 
            // labelControl30
            // 
            this.labelControl30.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl30.Appearance.Image")));
            this.labelControl30.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl30.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl30.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl30.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl30.LineVisible = true;
            this.labelControl30.Location = new System.Drawing.Point(46, 111);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(273, 68);
            this.labelControl30.TabIndex = 2;
            this.labelControl30.Text = "LineOrientation控制线条显示方向";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.Appearance.Image")));
            this.labelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.labelControl3.Location = new System.Drawing.Point(116, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 20);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "labelControl3";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl4.Appearance.Image")));
            this.labelControl4.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
            this.labelControl4.Location = new System.Drawing.Point(234, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 33);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "labelControl4";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoEllipsis = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(8, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(296, 70);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "我是一段很长的文字，我会重复很多次。我是一段很长的文字，我会重复很多次。我是一段很长的文字，我会重复很多次。我是一段很长的文字，我会重复很多次。我是一段很长的文字" +
    "，我会重复很多次。我是一段很长的文字，我会重复很多次。";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl6.Appearance.Image")));
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl6.LineColor = System.Drawing.Color.Blue;
            this.labelControl6.LineVisible = true;
            this.labelControl6.Location = new System.Drawing.Point(31, 150);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(273, 47);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "LineColor控制线条显示颜色";
            // 
            // LableControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 306);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl30);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "LableControlForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}

