using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSAP.PSAPCommon
{

    public abstract class PSAPCommon
    {
        public PSAPCommon()
        {

        }
        public static void EnterDoTab(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");  //回车时将焦点定位到下一个控件
            }
        }
    }
}
