using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSAP.VIEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        /*
新增、修改、删除、保存、放弃的任务，现在设计好的界面如图3-57所示。
tsbInsert tsbEdit tsbDelete tsbSave tsbCancel
图3-57 添加增删改等按钮
（13）将GroupBox（gbEdit）的Enabled属性设置为“False”，表示最开始GroupBox里面的控件都设置为不可编辑状态。
（14）切换到Course的代码页，编写如下自定义方法如下。该方法将数据导航条、GroupBox、新增、修改、删除、保存、放弃的Enabled状态取反，即原来为“True”的将变为“False”，原来为“False”的将变为“True”。

private void ChangeEnabledState()
{
     courseBindingNavigator.Enabled = !courseBindingNavigator.Enabled;
     gbEdit.Enabled = !gbEdit.Enabled;
     foreach (ToolStripButton b in tsControl.Items)
     {
          b.Enabled = !b.Enabled;
     }
}
（15）双击“新增”按钮，生成Click事件框架，为其编写代码如下。

private void tsbInsert_Click(object sender, EventArgs e)
{
     ChangeEnabledState();
     courseBindingSource.AddNew();
     couNoTextBox.Focus();
}
本段代码功能如下。
① 切换Enabled状态。
② 调用courseBindingSource的AddNew方法，在数据集中添加一条新的数据行。
③ 将光标定位到“课程代码”文本框中。
（16）类似地，为“修改”按钮编写其Click事件代码如下。

private void tsbEdit_Click(object sender, EventArgs e)
{
     ChangeEnabledState();
     couNoTextBox.Focus();
}
本段代码功能如下。
① 切换Enabled状态，这样就已经可以修改当前数据行的数据了。
② 将光标定位到“课程代码”文本框中。
17）为“保存”按钮编写其Click事件代码如下。

private void tsbSave_Click(object sender, EventArgs e)
{
     ChangeEnabledState();
     this.Validate();
     this.courseBindingSource.EndEdit();
     this.tableAdapterManager.UpdateAll(this.dsXk);
}
本段代码功能如下。
① 切换Enabled回到原来的状态。
② 验证数据的合法性。
③ 结束编辑。
④ 将数据集中的数据更新到数据库中。
（18）为“放弃”按钮编写其Click事件代码如下。
oooooooooooooooooook
private void tsbCancel_Click(object sender, EventArgs e)
{
     ChangeEnabledState();
     this.courseBindingSource.CancelEdit();
}
本段代码功能如下。
① 切换Enabled回到原来的状态。
② 取消所做的修改。
（19）为“删除”按钮编写其Click事件代码如下。

private void tsbDelete_Click(object sender, EventArgs e)
{
     if (courseBindingSource.Current != null)
     {
           if (MessageBox.Show("确实要删除吗?", "确认", MessageBoxButtons.YesNo,
MessageBoxIcon.Question) == DialogResult.Yes)
           {
                courseBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dsXk);
           }
     }
}
本段代码功能如下。
① 先判断当前是否有数据，如果有，询问用户是否确认，如果确认，则移除当前行。
② 将数据集的变化更新到数据库中。
（20）在主窗体中单击“课程信息”菜单，运行效果如图3-58所示。

图3-58 课程信息运行效果
（21）在不违反数据库相关约束规则的前提下，可做如下测试。
① 单击“新增”按钮，如图3-59所示，注意各控件的


*/
    }
}
