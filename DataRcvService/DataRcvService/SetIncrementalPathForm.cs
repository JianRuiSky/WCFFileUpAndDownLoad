using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataRcvService
{
    /// <summary>
    /// 本窗体的功能是修改配置文件中的增量文件路径配置         
    /// </summary>
    public partial class SetIncrementalPathForm : Form
    {
        public SetIncrementalPathForm()
        {
            InitializeComponent();
            ReadPath();
        }

        /// <summary>
        /// 保存增量文件夹的设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ToolClass.UpdateAppConfig("five", txtFivePath.Text);     //更新five增量文件路径
                ToolClass.UpdateAppConfig("day", txtDayPath.Text);     //更新day增量文件路径
                ToolClass.UpdateAppConfig("ddx", txtDDXPath.Text);   //更新ddx增量文件路径
                ToolClass.ShowHintMsgBox("保存增量文件夹设置成功。");
                ReadPath();
            }
            catch (Exception ex)
            {
                ToolClass.ShowErrorMsgBox(ex.Message);
                SaveTextLog.WriteErrorLog(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 读取配置文件中的appSettings节点中的路径配置
        /// </summary>
        private void ReadPath()
        {
            try
            {
                string dayPath = ToolClass.GetAppConfig("day");
                string fivePath = ToolClass.GetAppConfig("five");
                string ddxPath = ToolClass.GetAppConfig("ddx");
                string hintMsg = "";
                if (string.IsNullOrEmpty(dayPath))
                {
                    hintMsg += "请在配置文件中添加一个day节点，值为增量文件的路径。\r\n";
                }
                else
                {
                    txtDayPath.Text = dayPath;
                }
                if (string.IsNullOrEmpty(fivePath))
                {
                    hintMsg += "请在配置文件中添加一个five节点，值为增量文件的路径。\r\n";
                }
                else
                {
                    txtFivePath.Text = fivePath;
                }
                if (string.IsNullOrEmpty(ddxPath))
                {
                    hintMsg += "请在配置文件中添加一个ddx节点，值为增量文件的路径。";
                }
                else
                {
                    txtDDXPath.Text = ddxPath;
                }
                if (!string.IsNullOrEmpty(hintMsg))
                {
                    ToolClass.ShowHintMsgBox(hintMsg);
                }
            }
            catch (Exception ex)
            {
                ToolClass.ShowErrorMsgBox("读取配置文件失败。" + ex.Message);
                SaveTextLog.WriteErrorLog(ex.ToString());
            }
        }
    }
}
