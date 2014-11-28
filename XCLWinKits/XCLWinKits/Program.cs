using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XCLWinKits
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool initiallyOwned = true;
            bool isCreated;
            System.Threading.Mutex m = new System.Threading.Mutex(initiallyOwned, "XCLWinKits", out isCreated);
            if (!(initiallyOwned && isCreated))
            {
                MessageBox.Show("当前程序已经在运行了，不能打开多个哦！", "系统提示");
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Index());
            }
        }
    }
}
