# Tips.Forms

## EnabledController クラス

フォームに追加されている全子孫コントロールの有効状態 (Enabled プロパティの値) を一元的に操作することができます。提供する機能は以下の通りです。

- 有効状態を任意のタイミングで保存して元に戻す。
- 全コントロールの有効状態を指定した値に一括変更する。

### デモ画面

1. コントロールの有効状態を任意に設定する。  
  ![実行結果](https://raw.githubusercontent.com/TanaUmbreon/CSharpTips/images/EnabledController-Demo-1.png)
2. 有効状態を保存して全て無効化する。  
  ![実行結果](https://raw.githubusercontent.com/TanaUmbreon/CSharpTips/images/EnabledController-Demo-2.png)
3. 有効状態を保存した状態に戻す。  
  ![実行結果](https://raw.githubusercontent.com/TanaUmbreon/CSharpTips/images/EnabledController-Demo-3.png)

### サンプルコード

```cs
public partial class Form1 : Form
{
    /// <summary>有効状態操作オブジェクト</summary>
    private EnabledController controller;

    public Form1()
    {
        InitializeComponent();
        controller = new EnabledController(this);

        // コントロールの有効状態を任意に設定 … (1)
        textBox1.Enabled = false;
        textBox2.Enabled = true;
        textBox3.Enabled = false;
        button1.Enabled = true;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        // 有効状態を保存 … (2)
        controller.Save();

        // 全コントロールを無効化 … (2)
        controller.SetEnabled(false);

        // 適当に長い処理
        await Task.Run(() => Thread.Sleep(TimeSpan.FromSeconds(1.97)));

        // 有効状態を保存した状態に戻す … (3)
        controller.Restore();
    }
}
```