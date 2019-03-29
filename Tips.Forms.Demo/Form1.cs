using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tips.Forms
{
    public partial class Form1 : Form
    {
        /// <summary>有効状態操作オブジェクト</summary>
        private EnabledController controller;

        public Form1()
        {
            InitializeComponent();

            controller = new EnabledController(this);
            labelWidthInfo.Text = string.Format(labelWidthInfo.Text, textBox3.Width);
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            // 有効状態を保存
            controller.Save();

            // 全コントロールを無効化
            controller.SetEnabled(false);

            // 適当に長い処理
            await Task.Run(() => Thread.Sleep(TimeSpan.FromSeconds(1.97)));

            // 有効状態を保存した状態に戻す
            controller.Restore();
        }

        #region 有効状態の単体切替

        private void buttonSwitch1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
        }

        private void buttonSwitch2_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = !textBox2.Enabled;
        }

        private void buttonSwitch3_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = !textBox3.Enabled;
        }

        #endregion
    }
}
