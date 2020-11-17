using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace UrlClicker
{
    class FileUtil
    {

        /// <summary>
        /// ファイルまたはフォルダが存在するかどうかを返します.
        /// </summary>
        /// <param name="path">ファイル（ディレクトリ）パス</param>
        /// <returns>TRUE：存在する／FALSE：存在しない</returns>
        public static bool IsExists(string path)
        {
            return IsExistsFile(path) | IsExistsDirectory(path);
        }

        /// <summary>
        /// ファイルが存在するかどうかを返します.
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <returns>TRUE：存在する／FALSE：存在しない</returns>
        public static bool IsExistsFile(string filePath)
        {
            return File.Exists(filePath);
        }

        /// <summary>
        /// ディレクトリが存在するかどうかを返します.
        /// </summary>
        /// <param name="directoryPath">ディレクトリパス</param>
        /// <returns>TRUE：存在する／FALSE：存在しない</returns>
        public static bool IsExistsDirectory(string directoryPath)
        {
            return Directory.Exists(directoryPath);
        }

        /// <summary>
        /// 設定ファイルを保存します.
        /// </summary>
        /// <param name="set">設定情報</param>
        /// <param name="path">保存先ファイルパス</param>
        public static void SaveSettingInfo(SettingInfo set, string path)
        {
            XmlSerializer serializer1 = new XmlSerializer(typeof(SettingInfo));

            // ファイルを開く（UTF-8 BOM無し）
            StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(false));

            // シリアル化し、XMLファイルに保存する
            serializer1.Serialize(sw, set);

            // 閉じる
            sw.Close();
        }

        /// <summary>
        /// 設定ファイルを読み込みます.
        /// </summary>
        /// <param name="path">設定情報ファイルのパス</param>
        /// <returns></returns>
        public static SettingInfo LoadSettingInfo(string path)
        {
            SettingInfo set = new SettingInfo();

            // XmlSerializerオブジェクトの作成
            XmlSerializer serializer = new XmlSerializer(typeof(SettingInfo));
            // ファイルを開く
            StreamReader sr = new StreamReader(path, new UTF8Encoding(false));
            // XMLファイルから読み込み、逆シリアル化する
            set = (SettingInfo)serializer.Deserialize(sr);
            // 閉じる
            sr.Close();

            return set;
        }

    }
}
