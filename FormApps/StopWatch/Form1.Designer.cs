namespace StopWatch {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lbTimeDisp = new System.Windows.Forms.Label();
            this.btStrt = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btRset = new System.Windows.Forms.Button();
            this.tmDispTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbTimeDisp
            // 
            this.lbTimeDisp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbTimeDisp.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTimeDisp.Location = new System.Drawing.Point(53, 37);
            this.lbTimeDisp.Name = "lbTimeDisp";
            this.lbTimeDisp.Size = new System.Drawing.Size(284, 66);
            this.lbTimeDisp.TabIndex = 0;
            // 
            // btStrt
            // 
            this.btStrt.Location = new System.Drawing.Point(53, 129);
            this.btStrt.Name = "btStrt";
            this.btStrt.Size = new System.Drawing.Size(124, 58);
            this.btStrt.TabIndex = 1;
            this.btStrt.Text = "スタート";
            this.btStrt.UseVisualStyleBackColor = true;
            this.btStrt.Click += new System.EventHandler(this.btStrt_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(213, 129);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(124, 58);
            this.btStop.TabIndex = 2;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btRset
            // 
            this.btRset.Location = new System.Drawing.Point(53, 226);
            this.btRset.Name = "btRset";
            this.btRset.Size = new System.Drawing.Size(124, 58);
            this.btRset.TabIndex = 3;
            this.btRset.Text = "リセット";
            this.btRset.UseVisualStyleBackColor = true;
            this.btRset.Click += new System.EventHandler(this.btRset_Click);
            // 
            // tmDispTimer
            // 
            this.tmDispTimer.Tick += new System.EventHandler(this.tmDispTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 329);
            this.Controls.Add(this.btRset);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStrt);
            this.Controls.Add(this.lbTimeDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimeDisp;
        private System.Windows.Forms.Button btStrt;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btRset;
        private System.Windows.Forms.Timer tmDispTimer;
    }
}

