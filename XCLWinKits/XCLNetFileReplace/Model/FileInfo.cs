using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XCLNetFileReplace.Model
{
    public class FileInfo
    {
        public string 文件名 { get; set; }

        private string _路径 = string.Empty;
        public string 路径
        {
            get
            {
                return this._路径;
            }
            set
            {
                //主要是将扩展名转为小写
                this._路径 = string.Format("{0}.{1}", value.Substring(0, value.LastIndexOf('.')), XCLNetTools.FileHandler.ComFile.GetExtName(value).ToLower());
            }
        }

        private string _扩展名 = string.Empty;
        public string 扩展名
        {
            get
            {
                return this._扩展名;
            }
            set
            {
                this._扩展名 = (string.IsNullOrEmpty(value) ? string.Empty : value.ToLower());
            }
        }

        public string 是否已处理 { get; set; }

        public string 是否处理成功 { get; set; }

        private decimal _处理用时 = 0.0m;
        /// <summary>
        /// 处理用时（秒）
        /// </summary>
        public decimal 处理用时
        {
            get { return this._处理用时; }
            set { this._处理用时 = value; }
        }

        public string 备注 { get; set; }
    }
}
