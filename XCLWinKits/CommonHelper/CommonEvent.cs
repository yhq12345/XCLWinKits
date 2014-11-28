using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommonHelper
{
    public class CommonEvent
    {
        /// <summary>
        /// 设置textbox的全选事件
        /// </summary>
        public static void SetTextBoxSelectAllEvent(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
