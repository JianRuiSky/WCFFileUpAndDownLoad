using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataRcvService
{
    /// <summary>
    /// 本窗体用于为本项目的主窗体，主要承担服务的动作、服务的设置以及文件的下载等等
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 提供服务的主机
        /// </summary>
        ServiceHost selfHost = new ServiceHost(typeof(DataRcvService));
        public MainForm()
        {
            InitializeComponent();
            tsmiStartService_Click(null, EventArgs.Empty);
            ShowPath();
            timerService.Enabled = true;
            lblServiceState.BackColor = Color.White;
        }

        /// <summary>
        /// 按钮“启动服务”按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiStartService_Click(object sender, EventArgs e)
        {
            try
            {
                if (selfHost.State == CommunicationState.Created)
                {
                    selfHost.Open();
                }
                else
                {
                    selfHost = new ServiceHost(typeof(DataRcvService));
                    selfHost.Open();
                }
                ShowMsgControlText("服务启动成功。");
                SaveTextLog.WriteOperateLog("服务启动成功。");
            }
            catch (Exception ex)
            {
                ShowMsgControlText(ex.Message);
                selfHost.Abort();
                SaveTextLog.WriteErrorLog(ex.ToString());
            }
        }
        /// <summary>
        /// 按钮“停止服务”按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiStopService_Click(object sender, EventArgs e)
        {
            try
            {
                selfHost.Close();
                ShowMsgControlText("服务停止。");
                SaveTextLog.WriteOperateLog("服务停止。");
            }
            catch (Exception ex)
            {
                ShowMsgControlText(ex.Message);
                selfHost.Abort();
                SaveTextLog.WriteErrorLog(ex.ToString());
            }
        }

        /// <summary>
        /// 显示修改配置文件的窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiIncrementalPath_Click(object sender, EventArgs e)
        {
            SetIncrementalPathForm setform = new SetIncrementalPathForm();
            setform.ShowDialog();
        }

        /// <summary>
        /// 服务器状态扫描
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerService_Tick(object sender, EventArgs e)
        {
            RefreshServiceState();
        }

        /// <summary>
        /// 显示消息到本界面文本控件
        /// </summary>
        /// <param name="msg"></param>
        public void ShowMsgControlText(string msg)
        {
            richTextBox1.AppendText(DateTime.Now.ToString() + " " + msg + "\r\n");
        }
        /// <summary>
        /// 在消息框中显示day、five和ddx增量文件的路径
        /// </summary>
        public void ShowPath()
        {
            try
            {
                string dayPath = ToolClass.GetAppConfig("day");
                string fivePath = ToolClass.GetAppConfig("five");
                string ddxPath = ToolClass.GetAppConfig("ddx");
                if (string.IsNullOrEmpty(dayPath))
                {
                    ShowMsgControlText("请在配置文件中添加一个day节点，值为增量文件的路径。");
                }
                else
                {
                    ShowMsgControlText("日线指标增量文件的路径：" + dayPath);
                }
                if (string.IsNullOrEmpty(fivePath))
                {
                    ShowMsgControlText("请在配置文件中添加一个five节点，值为增量文件的路径。");
                }
                else
                {
                    ShowMsgControlText("五分线指标增量文件的路径：" + ToolClass.GetAppConfig("five"));
                }
                if (string.IsNullOrEmpty(ddxPath))
                {
                    ShowMsgControlText("请在配置文件中添加一个ddx节点，值为增量文件的路径。");
                }
                else
                {
                    ShowMsgControlText("ddx增量文件的路径：" + ToolClass.GetAppConfig("ddx"));
                }
            }
            catch (Exception ex)
            {
                ShowMsgControlText(ex.Message);
                SaveTextLog.WriteErrorLog(ex.ToString());
            }
        }
        /// <summary>
        /// 刷新服务器运行状态文本和颜色
        /// </summary>
        public void RefreshServiceState()
        {
            if (selfHost.State == CommunicationState.Opened)
            {
                lblServiceState.Text = "正在运行";
                if (lblServiceState.BackColor == Color.White)
                {
                    lblServiceState.BackColor = Color.Green;
                }
                else if (lblServiceState.BackColor == Color.Green)
                {
                    lblServiceState.BackColor = Color.White;
                }
                else
                {

                }
            }
            else if (selfHost.State == CommunicationState.Closed)
            {
                lblServiceState.Text = "停止运行";
                if (lblServiceState.BackColor == Color.White)
                {
                    lblServiceState.BackColor = Color.Red;
                }
                else if (lblServiceState.BackColor == Color.Red)
                {
                    lblServiceState.BackColor = Color.White;
                }
            }
            else
            {
                lblServiceState.Text = selfHost.State.ToString();
            }
        }
    }
}
