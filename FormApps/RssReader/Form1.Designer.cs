namespace RssReader {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btRssGet = new Button();
            lbTitles = new ListBox();
            wvRssLink = new Microsoft.Web.WebView2.WinForms.WebView2();
            btGoForward = new Button();
            btGoBack = new Button();
            cbUrl = new ComboBox();
            btFavorite = new Button();
            cbFavorite = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)wvRssLink).BeginInit();
            SuspendLayout();
            // 
            // btRssGet
            // 
            btRssGet.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRssGet.Location = new Point(648, 10);
            btRssGet.Name = "btRssGet";
            btRssGet.Size = new Size(77, 33);
            btRssGet.TabIndex = 1;
            btRssGet.Text = "取得";
            btRssGet.UseVisualStyleBackColor = true;
            btRssGet.Click += btRssGet_Click;
            // 
            // lbTitles
            // 
            lbTitles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTitles.DrawMode = DrawMode.OwnerDrawFixed;
            lbTitles.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTitles.FormattingEnabled = true;
            lbTitles.ItemHeight = 21;
            lbTitles.Location = new Point(15, 107);
            lbTitles.Name = "lbTitles";
            lbTitles.Size = new Size(710, 172);
            lbTitles.TabIndex = 2;
            lbTitles.Click += lbTitles_Click;
            lbTitles.DrawItem += lbTitles_DrawItem;
            // 
            // wvRssLink
            // 
            wvRssLink.AllowExternalDrop = true;
            wvRssLink.CreationProperties = null;
            wvRssLink.DefaultBackgroundColor = Color.White;
            wvRssLink.Location = new Point(15, 307);
            wvRssLink.Name = "wvRssLink";
            wvRssLink.Size = new Size(710, 324);
            wvRssLink.TabIndex = 3;
            wvRssLink.ZoomFactor = 1D;
            wvRssLink.SourceChanged += wvRssLink_SourceChanged;
            // 
            // btGoForward
            // 
            btGoForward.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGoForward.Location = new Point(83, 11);
            btGoForward.Name = "btGoForward";
            btGoForward.Size = new Size(62, 33);
            btGoForward.TabIndex = 4;
            btGoForward.Text = "進む";
            btGoForward.UseVisualStyleBackColor = true;
            btGoForward.Click += btGoForward_Click;
            // 
            // btGoBack
            // 
            btGoBack.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btGoBack.Location = new Point(15, 12);
            btGoBack.Name = "btGoBack";
            btGoBack.Size = new Size(62, 33);
            btGoBack.TabIndex = 4;
            btGoBack.Text = "戻る";
            btGoBack.UseVisualStyleBackColor = true;
            btGoBack.Click += btGoBack_Click;
            // 
            // cbUrl
            // 
            cbUrl.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbUrl.FormattingEnabled = true;
            cbUrl.Location = new Point(151, 11);
            cbUrl.Name = "cbUrl";
            cbUrl.Size = new Size(472, 33);
            cbUrl.TabIndex = 5;
            // 
            // btFavorite
            // 
            btFavorite.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btFavorite.Location = new Point(585, 61);
            btFavorite.Name = "btFavorite";
            btFavorite.Size = new Size(140, 33);
            btFavorite.TabIndex = 6;
            btFavorite.Text = "お気に入り追加";
            btFavorite.UseVisualStyleBackColor = true;
            btFavorite.Click += btFavorite_Click;
            // 
            // cbFavorite
            // 
            cbFavorite.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbFavorite.FormattingEnabled = true;
            cbFavorite.Location = new Point(93, 61);
            cbFavorite.Name = "cbFavorite";
            cbFavorite.Size = new Size(472, 33);
            cbFavorite.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 643);
            Controls.Add(cbFavorite);
            Controls.Add(btFavorite);
            Controls.Add(cbUrl);
            Controls.Add(btGoBack);
            Controls.Add(btGoForward);
            Controls.Add(wvRssLink);
            Controls.Add(lbTitles);
            Controls.Add(btRssGet);
            Name = "Form1";
            Text = "RssReader";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)wvRssLink).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btRssGet;
        private ListBox lbTitles;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvRssLink;
        private Button btGoForward;
        private Button btGoBack;
        private ComboBox cbUrl;
        private Button btFavorite;
        private ComboBox cbFavorite;
    }
}
