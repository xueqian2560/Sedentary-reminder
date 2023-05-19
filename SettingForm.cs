using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
namespace 久坐提醒
{
    public partial class SettingForm : Form
    {
        // 单例实例
        private static SettingForm instance = null;

        // 获取或创建单例实例
        public static SettingForm GetInstance()
        {
            if (instance == null)
            {
                instance = new SettingForm();
            }
            return instance;
        }
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            label4.Visible = false;

            if (trackBar1.Value == 1)
            {
                label3.Text = label3.Text = "提示时间" + "5" + " " + "分钟";
                label4.Text = "5";
                // 如果 trackBar1.Value 等于 0，则执行这里的代码
            }
            else if (trackBar1.Value == 2)
            {
                label3.Text = label3.Text = "提示时间" + "10" + " " + "分钟";
                label4.Text = "10";
            }
            else if (trackBar1.Value == 3)
            {
                label3.Text = label3.Text = "提示时间" + "15" + " " + "分钟";
                label4.Text = "15";
            }
            else if (trackBar1.Value == 4)
            {
                label3.Text = label3.Text = "提示时间" + "20" + " " + "分钟";
                label4.Text = "20";
            }
            else if (trackBar1.Value == 5)
            {
                label3.Text = label3.Text = "提示时间" + "25" + " " + "分钟";
                label4.Text = "25";
            }
            else if (trackBar1.Value == 6)
            {
                label3.Text = label3.Text = "提示时间" + "30" + " " + "分钟";
                label4.Text = "30";
            }


            string appPath = Application.ExecutablePath;

            // 打开注册表项HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run
            RegistryKey runKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");

            // 获取启动项中名为"MyApp"的值
            string value = (string)runKey.GetValue("jiuzuo");

            // 判断该值是否等于当前应用程序的路径
            if (!string.IsNullOrEmpty(value) && value.Equals(appPath))
            {
                // 该应用程序已被设置为Windows启动项中的应用程序
                checkBox1.Checked = true;
            }
            else
            {
                // 该应用程序未被设置为Windows启动项中的应用程序
                checkBox1.Checked = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // label3.Text = label3.Text = "提示时间" + trackBar1.Value.ToString() + " " + "分钟";
            if (trackBar1.Value == 1)
            {
                label3.Text = label3.Text = "提示时间" + "5" + " " + "分钟";
                label4.Text = "5";

                // 如果 trackBar1.Value 等于 0，则执行这里的代码
            }
            else if (trackBar1.Value == 2)
            {
                label3.Text = label3.Text = "提示时间" + "10" + " " + "分钟";
                label4.Text = "10";
            }
            else if (trackBar1.Value == 3)
            {
                label3.Text = label3.Text = "提示时间" + "15" + " " + "分钟";
                label4.Text = "15";
            }
            else if (trackBar1.Value == 4)
            {
                label3.Text = label3.Text = "提示时间" + "20" + " " + "分钟";
                label4.Text = "20";
            }
            else if (trackBar1.Value == 5)
            {
                label3.Text = label3.Text = "提示时间" + "25" + " " + "分钟";
                label4.Text = "25";
            }
            else if (trackBar1.Value == 6)
            {
                label3.Text = label3.Text = "提示时间" + "30" + " " + "分钟";
                label4.Text = "30";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 6;
            label3.Text = label3.Text = "提示时间" + "30" + " " + "分钟";
            label4.Text = "30";


            label4.Text = Properties.Resources.trackbarValuehold;
        }

        private void SettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            label4.Text = Properties.Resources.trackbarValuehold;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = Properties.Resources.trackbarValuehold;
            String timValue=

        }
    }
}
