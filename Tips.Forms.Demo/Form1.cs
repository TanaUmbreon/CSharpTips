using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tips.Forms
{
    public partial class Form1 : Form
    {
        private ControlEnabledRegister register;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            register = new ControlEnabledRegister(this);
        }

        #region コントロールの有効状態を任意に変更

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = checkBox4.Checked;
        }

        #endregion

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 有効状態を保持
                register.Save();

                // 全コントロールを無効化
                button1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;

                // 長い処理を実行
                await Task.Run(() => Thread.Sleep(TimeSpan.FromSeconds(2.0)));

                // 有効状態を復元
                register.Restore();
            }
            catch (Exception)
            {
            }
        }
    }
}
