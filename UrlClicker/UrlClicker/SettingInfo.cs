using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlClicker
{
    public class SettingInfo
    {
        /// <summary>
        /// 実行間隔
        /// </summary>
        public string Interval { set; get; }

        /// <summary>
        /// 処理タイプ（0：自動解凍EXE／1：削除EXE）
        /// </summary>
        public List<String> HistoryList { set; get; }

        /// <summary>
        /// 選択中のリストビューアイテム
        /// </summary>
        public List<String> UrlList { set; get; }

    }
}
