using Microsoft.Win32;
using System.Configuration;

namespace 久坐提醒
{

    public partial class Form1 : Form
    {
        // 获取主屏幕分辨率
        int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
        int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // SettingForm settingForm = new SettingForm();
            notifyIcon1.Visible = true;



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
            this.notifyIcon1.Text = "久坐提醒器";

            // 获取当前应用程序的路径

            // 设置窗口的大小和位置
            // this.Width = 400; // 设置窗口宽度
            // this.Height = 200; // 设置窗口高度
            //  this.Left = ScreenWidth - this.Width; // 设置窗口左侧坐标
            //this.Top = ScreenHeight - this.Height; // 设置窗口顶部坐标
            // this.WindowState = FormWindowState.Minimized;                           // 设置倒计时剩余时间为30分钟（1800秒）
            int remainingTimeStateValue = int.Parse(Properties.Resources.remainingTimeValuehold);
            // int remainingTime = 1800;//1800
            // int remainingTime = 5;
            int remainingTime = remainingTimeStateValue;

            this.label2.Text = $"{remainingTime / 60:00}:{remainingTime % 60:00}";
            timer1.Interval = 1000; // 定时器间隔为1秒
                                    // 启动定时器
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int remainingTime = 1800;//1800

            if (remainingTime == 0)
            {
                this.label2.Text = $"{remainingTime / 60:00}:{remainingTime % 60:00}";
                timer1.Interval = 1000; // 定时器间隔为1秒
                                        // 启动定时器
                timer1.Start();
                // this.WindowState = FormWindowState.Minimized;
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
                // this.Activate();
                notifyIcon1.Visible = true;
            }
            else
            {

                this.Hide();
                this.WindowState = FormWindowState.Minimized;

                notifyIcon1.Visible = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            // 获取当前倒计时剩余时间
            int remainingTime = Convert.ToInt32(this.label2.Text.Substring(0, 2)) * 60 +
                                Convert.ToInt32(this.label2.Text.Substring(3, 2));

            // 剩余时间减1秒
            remainingTime--;

            // 更新文本框中显示的倒计时剩余时间
            this.label2.Text = $"{remainingTime / 60:00}:{remainingTime % 60:00}";
            notifyIcon1.BalloonTipText = label2.Text;

            // 如果倒计时剩余时间为0，停止定时器
            if (remainingTime == 0)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                // Timer timer1 = (Timer)sender;
                timer1.Stop();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            notifyIcon1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string appPath = Application.ExecutablePath;

                // 打开注册表项HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run
                RegistryKey runKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                // 将应用程序添加到启动项中，设置值为应用程序的路径 
                runKey.SetValue("jiuzuo", appPath);
            }
            else
            {
                // 获取当前应用程序的路径
                string appPath = Application.ExecutablePath;

                // 打开注册表项HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run
                RegistryKey runKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

                // 从启动项中删除指定的应用程序
                runKey.DeleteValue("jiuzuo", false);
            }

        }

        private void notifyIcon1_MouseHover(object sender, MouseEventArgs e)
        {

            // 设置通知的标题和文本内容
            notifyIcon1.BalloonTipTitle = "久坐提醒";
            notifyIcon1.BalloonTipText = label2.Text;

            // 显示通知
            notifyIcon1.ShowBalloonTip(2000);
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            SettingForm.GetInstance().Show();


        }
    }
}

