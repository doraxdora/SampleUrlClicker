namespace UrlClicker
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.lb_url = new System.Windows.Forms.ListBox();
            this.txb_url = new System.Windows.Forms.TextBox();
            this.lbl_url = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txb_time = new System.Windows.Forms.TextBox();
            this.lbl_url_list = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_hist = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_hist_clear = new System.Windows.Forms.Button();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.group2.SuspendLayout();
            this.group1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_url
            // 
            this.lb_url.FormattingEnabled = true;
            this.lb_url.ItemHeight = 12;
            this.lb_url.Location = new System.Drawing.Point(20, 105);
            this.lb_url.Name = "lb_url";
            this.lb_url.Size = new System.Drawing.Size(567, 88);
            this.lb_url.TabIndex = 3;
            this.lb_url.SelectedIndexChanged += new System.EventHandler(this.Lb_url_SelectedIndexChanged);
            // 
            // txb_url
            // 
            this.txb_url.Location = new System.Drawing.Point(20, 53);
            this.txb_url.Name = "txb_url";
            this.txb_url.Size = new System.Drawing.Size(270, 19);
            this.txb_url.TabIndex = 0;
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(18, 38);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(76, 12);
            this.lbl_url.TabIndex = 1;
            this.lbl_url.Text = "追加するURL：";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(296, 51);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "追加";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // txb_time
            // 
            this.txb_time.Location = new System.Drawing.Point(20, 221);
            this.txb_time.Name = "txb_time";
            this.txb_time.Size = new System.Drawing.Size(75, 19);
            this.txb_time.TabIndex = 4;
            // 
            // lbl_url_list
            // 
            this.lbl_url_list.AutoSize = true;
            this.lbl_url_list.Location = new System.Drawing.Point(18, 90);
            this.lbl_url_list.Name = "lbl_url_list";
            this.lbl_url_list.Size = new System.Drawing.Size(63, 12);
            this.lbl_url_list.TabIndex = 5;
            this.lbl_url_list.Text = "クリックURL：";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(18, 206);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(77, 12);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "実行間隔（分）";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(196, 219);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(115, 219);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "開始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.Btn_start_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(377, 51);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "削除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.Btn_del_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lb_hist
            // 
            this.lb_hist.FormattingEnabled = true;
            this.lb_hist.ItemHeight = 12;
            this.lb_hist.Location = new System.Drawing.Point(20, 18);
            this.lb_hist.Name = "lb_hist";
            this.lb_hist.Size = new System.Drawing.Size(567, 136);
            this.lb_hist.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(560, 491);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "閉じる";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_hist_clear
            // 
            this.btn_hist_clear.Location = new System.Drawing.Point(19, 160);
            this.btn_hist_clear.Name = "btn_hist_clear";
            this.btn_hist_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_hist_clear.TabIndex = 8;
            this.btn_hist_clear.Text = "履歴クリア";
            this.btn_hist_clear.UseVisualStyleBackColor = true;
            this.btn_hist_clear.Click += new System.EventHandler(this.Btn_hist_clear_Click);
            // 
            // group2
            // 
            this.group2.Controls.Add(this.lb_hist);
            this.group2.Controls.Add(this.btn_hist_clear);
            this.group2.Location = new System.Drawing.Point(30, 274);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(605, 191);
            this.group2.TabIndex = 20;
            this.group2.TabStop = false;
            this.group2.Text = "実行履歴";
            // 
            // group1
            // 
            this.group1.Controls.Add(this.lb_url);
            this.group1.Controls.Add(this.txb_url);
            this.group1.Controls.Add(this.lbl_url);
            this.group1.Controls.Add(this.btn_add);
            this.group1.Controls.Add(this.txb_time);
            this.group1.Controls.Add(this.lbl_url_list);
            this.group1.Controls.Add(this.lbl_time);
            this.group1.Controls.Add(this.btn_stop);
            this.group1.Controls.Add(this.btn_start);
            this.group1.Controls.Add(this.btn_del);
            this.group1.Location = new System.Drawing.Point(30, 12);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(605, 256);
            this.group1.TabIndex = 19;
            this.group1.TabStop = false;
            this.group1.Text = "URLリクエスト設定";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(671, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel1.Text = "停止";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 544);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.group2.ResumeLayout(false);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_url;
        private System.Windows.Forms.TextBox txb_url;
        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txb_time;
        private System.Windows.Forms.Label lbl_url_list;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lb_hist;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_hist_clear;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

