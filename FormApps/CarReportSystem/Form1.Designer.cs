namespace CarReportSystem {
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpDate = new DateTimePicker();
            cbAuthor = new ComboBox();
            groupBox1 = new GroupBox();
            rbOrther = new RadioButton();
            rbYunyuu = new RadioButton();
            rbSubaru = new RadioButton();
            rbHomda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            cbCarName = new ComboBox();
            tbRepote = new TextBox();
            dgvRecod = new DataGridView();
            pbPicture = new PictureBox();
            btOpen = new Button();
            btPicDelete = new Button();
            btRecordAdd = new Button();
            btRecordModify = new Button();
            btRecordDelete = new Button();
            ofdPicFileOpen = new OpenFileDialog();
            btNewRecord = new Button();
            ssMessageArea = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsmiExit = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tsmiAbout = new ToolStripMenuItem();
            cdColor = new ColorDialog();
            sfdReportFileSave = new SaveFileDialog();
            ofdReportFileOpen = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ssMessageArea.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(7, 93);
            label2.Name = "label2";
            label2.Size = new Size(76, 30);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(28, 210);
            label4.Name = "label4";
            label4.Size = new Size(55, 30);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(9, 262);
            label5.Name = "label5";
            label5.Size = new Size(74, 30);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(28, 384);
            label6.Name = "label6";
            label6.Size = new Size(55, 30);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(456, 46);
            label7.Name = "label7";
            label7.Size = new Size(55, 30);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(94, 43);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(94, 94);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(208, 33);
            cbAuthor.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOrther);
            groupBox1.Controls.Add(rbYunyuu);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHomda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(94, 141);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 53);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbOrther
            // 
            rbOrther.AutoSize = true;
            rbOrther.Location = new Point(307, 19);
            rbOrther.Name = "rbOrther";
            rbOrther.Size = new Size(56, 19);
            rbOrther.TabIndex = 5;
            rbOrther.TabStop = true;
            rbOrther.Text = "その他";
            rbOrther.UseVisualStyleBackColor = true;
            // 
            // rbYunyuu
            // 
            rbYunyuu.AutoSize = true;
            rbYunyuu.Location = new Point(240, 19);
            rbYunyuu.Name = "rbYunyuu";
            rbYunyuu.Size = new Size(61, 19);
            rbYunyuu.TabIndex = 4;
            rbYunyuu.TabStop = true;
            rbYunyuu.Text = "輸入車";
            rbYunyuu.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(180, 19);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 3;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHomda
            // 
            rbHomda.AutoSize = true;
            rbHomda.Location = new Point(121, 19);
            rbHomda.Name = "rbHomda";
            rbHomda.Size = new Size(53, 19);
            rbHomda.TabIndex = 2;
            rbHomda.TabStop = true;
            rbHomda.Text = "ホンダ";
            rbHomda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(66, 19);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 1;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(10, 19);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(94, 211);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(208, 33);
            cbCarName.TabIndex = 2;
            // 
            // tbRepote
            // 
            tbRepote.Location = new Point(94, 262);
            tbRepote.Multiline = true;
            tbRepote.Name = "tbRepote";
            tbRepote.Size = new Size(373, 98);
            tbRepote.TabIndex = 4;
            // 
            // dgvRecod
            // 
            dgvRecod.AllowUserToAddRows = false;
            dgvRecod.AllowUserToDeleteRows = false;
            dgvRecod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecod.Location = new Point(94, 384);
            dgvRecod.MultiSelect = false;
            dgvRecod.Name = "dgvRecod";
            dgvRecod.ReadOnly = true;
            dgvRecod.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecod.Size = new Size(656, 150);
            dgvRecod.TabIndex = 5;
            dgvRecod.Click += dgvRecod_Click;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(506, 79);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(246, 196);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 6;
            pbPicture.TabStop = false;
            // 
            // btOpen
            // 
            btOpen.FlatStyle = FlatStyle.Flat;
            btOpen.Location = new Point(585, 50);
            btOpen.Name = "btOpen";
            btOpen.Size = new Size(75, 23);
            btOpen.TabIndex = 7;
            btOpen.Text = "開く...";
            btOpen.UseVisualStyleBackColor = true;
            btOpen.Click += btOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.Location = new Point(675, 50);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 8;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = true;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // btRecordAdd
            // 
            btRecordAdd.FlatStyle = FlatStyle.Flat;
            btRecordAdd.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordAdd.Location = new Point(512, 303);
            btRecordAdd.Name = "btRecordAdd";
            btRecordAdd.Size = new Size(67, 46);
            btRecordAdd.TabIndex = 7;
            btRecordAdd.Text = "追加";
            btRecordAdd.UseVisualStyleBackColor = true;
            btRecordAdd.Click += btRecordAdd_Click;
            // 
            // btRecordModify
            // 
            btRecordModify.FlatStyle = FlatStyle.Flat;
            btRecordModify.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordModify.Location = new Point(585, 303);
            btRecordModify.Name = "btRecordModify";
            btRecordModify.Size = new Size(67, 46);
            btRecordModify.TabIndex = 7;
            btRecordModify.Text = "修正";
            btRecordModify.UseVisualStyleBackColor = true;
            btRecordModify.Click += btRecordModify_Click;
            // 
            // btRecordDelete
            // 
            btRecordDelete.FlatStyle = FlatStyle.Flat;
            btRecordDelete.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btRecordDelete.Location = new Point(658, 303);
            btRecordDelete.Name = "btRecordDelete";
            btRecordDelete.Size = new Size(67, 46);
            btRecordDelete.TabIndex = 7;
            btRecordDelete.Text = "消去";
            btRecordDelete.UseVisualStyleBackColor = true;
            btRecordDelete.Click += btRecordDelete_Click;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // btNewRecord
            // 
            btNewRecord.Location = new Point(344, 43);
            btNewRecord.Name = "btNewRecord";
            btNewRecord.Size = new Size(89, 30);
            btNewRecord.TabIndex = 9;
            btNewRecord.Text = "新規入力";
            btNewRecord.UseVisualStyleBackColor = true;
            btNewRecord.Click += btNewRecord_Click;
            // 
            // ssMessageArea
            // 
            ssMessageArea.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            ssMessageArea.Location = new Point(0, 549);
            ssMessageArea.Name = "ssMessageArea";
            ssMessageArea.Size = new Size(768, 22);
            ssMessageArea.TabIndex = 10;
            ssMessageArea.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(118, 17);
            tsslbMessage.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(768, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, tsmiExit });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(67, 20);
            toolStripMenuItem1.Text = "ファイル(F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(180, 22);
            開くToolStripMenuItem.Text = "開く";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(180, 22);
            保存ToolStripMenuItem.Text = "保存";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(180, 22);
            色設定ToolStripMenuItem.Text = "色設定";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.ShortcutKeys = Keys.Alt | Keys.F4;
            tsmiExit.Size = new Size(180, 22);
            tsmiExit.Text = "終了";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { tsmiAbout });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(65, 20);
            toolStripMenuItem2.Text = "ヘルプ(H)";
            // 
            // tsmiAbout
            // 
            tsmiAbout.Name = "tsmiAbout";
            tsmiAbout.Size = new Size(155, 22);
            tsmiAbout.Text = "このアプリについて";
            tsmiAbout.Click += tsmiAbout_Click;
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 571);
            Controls.Add(ssMessageArea);
            Controls.Add(menuStrip1);
            Controls.Add(btNewRecord);
            Controls.Add(btPicDelete);
            Controls.Add(btRecordDelete);
            Controls.Add(btRecordModify);
            Controls.Add(btRecordAdd);
            Controls.Add(btOpen);
            Controls.Add(pbPicture);
            Controls.Add(dgvRecod);
            Controls.Add(tbRepote);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecod).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ssMessageArea.ResumeLayout(false);
            ssMessageArea.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpDate;
        private ComboBox cbAuthor;
        private GroupBox groupBox1;
        private RadioButton rbSubaru;
        private RadioButton rbHomda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private RadioButton rbOrther;
        private RadioButton rbYunyuu;
        private ComboBox cbCarName;
        private TextBox tbRepote;
        private DataGridView dgvRecod;
        private PictureBox pbPicture;
        private Button btOpen;
        private Button btPicDelete;
        private Button btRecordAdd;
        private Button btRecordModify;
        private Button btRecordDelete;
        private OpenFileDialog ofdPicFileOpen;
        private Button btNewRecord;
        private StatusStrip ssMessageArea;
        private ToolStripStatusLabel tsslbMessage;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem tsmiAbout;
        private ColorDialog cdColor;
        private SaveFileDialog sfdReportFileSave;
        private OpenFileDialog ofdReportFileOpen;
    }
}
