# Tips

主にメモ用途の Tips 集です。

## プロジェクト構成

* `Tips.ConsoleApp`
  * コンソール アプリケーションで使用するためのコードをまとめています。
* `Tips.ConsoleApp.Demo`
  * Tips.ConsoleApp の動作デモを見ることができます。

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

![実行結果](images\ConsoleEx.Timeout.png)

## ライセンスについて

[MIT ライセンス](LICENSE)で公開しています。

## リリースノート

### 2018/3/22

* ConsoleEx.Timeout メソッドを実装。
