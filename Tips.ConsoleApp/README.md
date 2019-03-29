# Tips.ConsoleApp

## 機能説明

### ConsoleEx.Timeout メソッド (Tips.ConsoleApp)

.NET の基本クラスライブラリにある System.Console クラスには、いわゆるコマンド プロンプトの `TIMEOUT` コマンドに該当する機能が無いのでそれを疑似的に実装したメソッドです。

#### 使用例

```cs
static void Main(string[] args)
{
    Console.WriteLine("以下、ConsoleEx.Timeout メソッドのデモをお送り致します。");
    Console.WriteLine();

    ConsoleEx.Timeout(milliseconds: 5000L);
    ConsoleEx.Timeout(TimeSpan.FromSeconds(722));
}
```

#### 実行結果

![実行結果](https://raw.githubusercontent.com/TanaUmbreon/CSharpTips/images/ConsoleEx-Timeout.png)

