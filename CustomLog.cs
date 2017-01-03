using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signDrivenMenu
{
    public class CustomLog
    {
        private RichTextBox mTbxLog;

        public void setLogTextBox(RichTextBox tbxLog)
        {
            mTbxLog = tbxLog;
        }
        
        public void e(String log)
        {
            //print error log (text color : red)
            mTbxLog.AppendText(log + "\n");
        }

        public void d(String log)
        {
            //print debug log (text color : blue)
            mTbxLog.AppendText(log + "\n");
        }

        public void setText(String text)
        {
            mTbxLog.Text = text + "\n";
        }
    }
}
