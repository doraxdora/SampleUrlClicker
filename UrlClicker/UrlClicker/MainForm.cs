using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Reflection;

namespace UrlClicker
{
    public partial class MainForm : Form
    {
        // 設定ファイルのパス
        private string appDir = "";
        private string settingFilePath = "";

        public MainForm()
        {
            InitializeComponent();

            // 実行ディレクトリのパスを取得
            Assembly mainAssembly = Assembly.GetExecutingAssembly();
            appDir = System.IO.Path.GetDirectoryName(mainAssembly.Location);

            // 設定ファイル名
            settingFilePath = appDir + @"\settings.config";

            // 前回設定情報を復元
            RestoreSettings();

        }

        /// <summary>
        /// 追加ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_add_Click(object sender, EventArgs e)
        {
            lb_url.Items.Add(txb_url.Text);
            txb_url.Text = "";
        }

        /// <summary>
        /// URLリスト選択変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lb_url_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_url.SelectedItem != null)
            {
                String text = lb_url.SelectedItem.ToString();
                txb_url.Text = text;
            }
        }

        /// <summary>
        /// 開始ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_start_Click(object sender, EventArgs e)
        {
            int time = 0;
            int.TryParse(txb_time.Text, out time);
            timer1.Interval = time * 60000;
            timer1.Enabled = true;
            toolStripStatusLabel1.Text = "実行中...";
            SendRequest();
        }

        /// <summary>
        /// 停止ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            toolStripStatusLabel1.Text = "停止";
        }

        /// <summary>
        /// タイマー処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            SendRequest();
        }

        /// <summary>
        /// リクエスト送信
        /// </summary>
        private void SendRequest()
        {
            foreach (String url in lb_url.Items)
            {

                //HttpWebRequestを作成
                try
                {
                    HttpWebRequest webreq = (HttpWebRequest)WebRequest.Create(url);

                    //サーバーからの応答を受信するためのHttpWebResponseを取得
                    HttpWebResponse webres = (HttpWebResponse)webreq.GetResponse();
                    //応答データを受信するためのStreamを取得
                    Stream st = webres.GetResponseStream();
                    //文字コードを指定して、StreamReaderを作成
                    StreamReader sr = new StreamReader(st, Encoding.UTF8);
                    //データをすべて受信
                    string htmlSource = sr.ReadToEnd();
                    //閉じる
                    sr.Close();
                    st.Close();
                    webres.Close();


                    DateTime dt = DateTime.Now;
                    string result = dt.ToString("yyyy/MM/dd HH:mm:ss");
                    lb_hist.Items.Add("[" + result + "] [" + url + "]");
                }
                catch
                {
                }

            }

        }

        /// <summary>
        /// 画面の入力値などを設定ファイルに保存します.
        /// </summary>
        private SettingInfo SaveSettings()
        {
            // 画面設定情報を取得し設定情報クラスにセット
            SettingInfo set = new SettingInfo();
            set.Interval = txb_time.Text;
            List<String> urlList = new List<String>();
            foreach (String item in lb_url.Items)
            {
                urlList.Add(item);
            }
            set.UrlList = urlList;

            List<String> histList = new List<String>();
            foreach (String item in lb_hist.Items)
            {
                histList.Add(item);
            }
            set.HistoryList = histList;

            // 設定ファイルの保存
            FileUtil.SaveSettingInfo(set, settingFilePath);

            return set;
        }

        /// <summary>
        /// 画面の前回情報を設定ファイルから復元します.
        /// </summary>
        private void RestoreSettings()
        {

            // 設定ファイルが存在しなければ処理を中止
            if (!FileUtil.IsExistsFile(settingFilePath))
            {
                return;
            }

            // 設定ファイルの読み込み
            SettingInfo set = FileUtil.LoadSettingInfo(settingFilePath);

            txb_time.Text = set.Interval;

            foreach (String url in set.UrlList)
            {
                lb_url.Items.Add(url);
            }

            foreach (String history in set.HistoryList)
            {
                lb_hist.Items.Add(history);
            }
        }

        /// <summary>
        /// 閉じるボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 履歴クリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_hist_clear_Click(object sender, EventArgs e)
        {
            lb_hist.Items.Clear();
        }

        /// <summary>
        /// 削除ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_del_Click(object sender, EventArgs e)
        {
            if (lb_url.SelectedItems != null)
            {
                lb_url.Items.RemoveAt(lb_url.SelectedIndex);
            }
        }

        /// <summary>
        /// フォーム閉じるとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 設定を保存
            SaveSettings();
        }
    }
}
