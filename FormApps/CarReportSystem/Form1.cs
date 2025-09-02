using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //カーレポート管理リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
            dgvRecod.DataSource = listCarReports;
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //記録者の履歴をコンボボックスへの登録（重複なし）
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                //未登録なら登録【登録済みなら何もしない】
                cbAuthor.Items.Add(author);
            }
        }

        //車名履歴をコンボボックスへ登録（重複なし）
        private void setCdCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                //未登録なら登録【登録済みなら何もしない】
                cbCarName.Items.Add(carName);
            }
        }

        private void btRecordAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }
            var CarReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbRepote.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(CarReport);
            setCbAuthor(cbAuthor.Text);
            setCdCarName(cbCarName.Text);
            InputItemAllClear();
        }

        //入力項目のすべてをクリア
        private void InputItemAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOrther.Checked = true;
            cbCarName.Text = string.Empty;
            tbRepote.Text = string.Empty;
            pbPicture.Image = null;
        }

        private CarReport.MakerGroup getRadioButtonMaker() {
            if (rbToyota.Checked)
                return CarReport.MakerGroup.トヨタ;
            if (rbNissan.Checked)
                return CarReport.MakerGroup.日産;
            if (rbHomda.Checked)
                return CarReport.MakerGroup.ホンダ;
            if (rbSubaru.Checked)
                return CarReport.MakerGroup.スバル;
            if (rbYunyuu.Checked)
                return CarReport.MakerGroup.輸入車;
            return CarReport.MakerGroup.その他;
        }

        private void dgvRecod_Click(object sender, EventArgs e) {
            if (dgvRecod.CurrentRow is null) return;
            dtpDate.Value = (DateTime)dgvRecod.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecod.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvRecod.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvRecod.CurrentRow.Cells["CarName"].Value;
            tbRepote.Text = (string)dgvRecod.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecod.CurrentRow.Cells["Picture"].Value;

        }
        //指定したメイカーラジオボタンをセット
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHomda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbYunyuu.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOrther.Checked = true;
                    break;
            }
        }

        //新規追加のイベントハンドラ
        private void btNewRecord_Click(object sender, EventArgs e) {
            InputItemAllClear();
        }

        //修正ボタンのイベントハンドラ
        private void btRecordModify_Click(object sender, EventArgs e) {
            //if ((dgvRecod.CurrentRow is null)
            //    || (!dgvRecod.CurrentRow.Selected)) return;
            if (dgvRecod.Rows.Count == 0) return;
            int index = dgvRecod.CurrentRow.Index;
            listCarReports[index].Date = dtpDate.Value;
            listCarReports[index].Author = cbAuthor.Text;
            listCarReports[index].Maker = getRadioButtonMaker();
            listCarReports[index].CarName = cbCarName.Text;
            listCarReports[index].Report = tbRepote.Text;
            listCarReports[index].Picture = pbPicture.Image;
            dgvRecod.Refresh();
        }

        //消去ボタンのイベントハンドラ
        private void btRecordDelete_Click(object sender, EventArgs e) {
            if ((dgvRecod.CurrentRow is null)
                || (!dgvRecod.CurrentRow.Selected)) return;
            //選択されているインデックス
            int index = dgvRecod.CurrentRow.Index;
            listCarReports.RemoveAt(index);
        }

        private void Form1_Load(object sender, EventArgs e) {
            InputItemAllClear();

            //交互に色を設定（データグリッドビュー）
            dgvRecod.DefaultCellStyle.BackColor = Color.LightGray;
            dgvRecod.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

            //設定ファイルを読み込み
            //P286以降を参考にする（ファイル名：setting.xml）
            if (File.Exists("setting.xml")) {
                try {
                    using (var reader = XmlReader.Create("setting.xml")) {
                        var serializer = new XmlSerializer(typeof(Settings));
                        settings = serializer.Deserialize(reader) as Settings;
                        BackColor = Color.FromArgb(settings.MainFormBackColor);
                        //設定クラスのインスタンスにも現在の設定色を設定
                        //settings.MainFormBackColor = BackColor.ToArgb();
                        //settings = set;
                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "設定ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);
                }
            } else {
                tsslbMessage.Text = "設定ファイルがありません";
            }

        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tsmiAbout_Click(object sender, EventArgs e) {
            fmVersion fmv = new fmVersion();
            fmv.ShowDialog();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                //設定ファイルへ保存
                settings.MainFormBackColor = cdColor.Color.ToArgb();
            }
        }

        //ファイルオープン処理
        private void reportOpenFile() {
            if (ofdReportFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open
                        (ofdReportFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRecod.DataSource = listCarReports;

                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();
                        //コンボボックスに登録
                        foreach (var report in listCarReports) {
                            setCbAuthor(report.Author);
                            setCdCarName(report.CarName);
                        }
                    }
                }
                catch (Exception) {
                    tsslbMessage.Text = "ファイル形式が違います";
                }
            }
        }

        //ファイルセーブ処理
        private void reportSaveFile() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
#pragma warning disable SYSLIB0011
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                    using (FileStream fs = File.Open
                            (sfdReportFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listCarReports);

                    }
                }
                catch (Exception ex) {
                    tsslbMessage.Text = "ファイル書き出しエラー";
                    MessageBox.Show(ex.Message);//より具体的なエラーを出力
                }
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            reportSaveFile();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            reportOpenFile();
        }

        //フォームが閉じられたら呼ばれる
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理
            //P284以降を参考にする（ファイル名：setting.xml)
            try {
                using (var writer = XmlWriter.Create("stting.xml")) {
                    var serializer = new XmlSerializer(settings.GetType());
                    serializer.Serialize(writer, settings);
                }

            }
            catch (Exception ex) {
                tsslbMessage.Text = "設定ファイル書き出しエラー";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
