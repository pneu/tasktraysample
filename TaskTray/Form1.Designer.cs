namespace TaskTray
{
    partial class TaskTrayAppForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskTrayAppForm));
            this.notifyIconTaskTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTaskTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTaskTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconTaskTray
            // 
            this.notifyIconTaskTray.ContextMenuStrip = this.contextMenuStripTaskTray;
            this.notifyIconTaskTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTaskTray.Icon")));
            this.notifyIconTaskTray.Text = "notifyIcon1";
            this.notifyIconTaskTray.Visible = true;
            // 
            // contextMenuStripTaskTray
            // 
            this.contextMenuStripTaskTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.contextMenuStripTaskTray.Name = "contextMenuStrip1";
            this.contextMenuStripTaskTray.Size = new System.Drawing.Size(153, 48);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CloseToolStripMenuItem.Text = "閉じる(&C)";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // TaskTrayAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TaskTrayAppForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStripTaskTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconTaskTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTaskTray;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;

    }
}

