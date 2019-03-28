using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tips.Forms
{
    /// <summary>
    /// フォームに追加された全子孫コントロールの有効状態を保存し復元する機能を提供します。
    /// </summary>
    public class ControlEnabledRegister
    {
        /// <summary>操作対象のフォーム</summary>
        private Form form;
        /// <summary>コントロールとその有効状態を保持するマップ</summary>
        private Dictionary<Control, bool> controlEnabledMap;

        /// <summary>
        /// <see cref="ControlEnabledRegister"/> の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="form">有効状態を保持する</param>
        public ControlEnabledRegister(Form form)
        {
            this.form = form;

            controlEnabledMap = new Dictionary<Control, bool>();
            GetAllControls(form).ForEach(cont => controlEnabledMap.Add(cont, cont.Enabled));
        }

        /// <summary>
        /// 指定したコントロールに追加された全子孫コントロールのリストを取得します。
        /// </summary>
        /// <param name="parent">子孫コントロールを取得する親コントロール。</param>
        /// <returns><paramref name="parent"/> に追加された全子孫コントロールのリスト。</returns>
        private List<Control> GetAllControls(Control parent)
        {
            var controls = new List<Control>();
            
            foreach (var child in parent.Controls.OfType<Control>())
            {
                controls.Add(child);
                controls.AddRange(GetAllControls(child));
            }

            return controls;
        }

        /// <summary>
        /// 現在のコントロールの有効状態を保存します。
        /// </summary>
        public void Save()
        {
            if (InvokeIfRequired(Save)) { return; }

            // Dictionaryのforeach中に値を変えると例外が起きるのでキーを複製してそれをループ
            var keys = controlEnabledMap.Keys.ToList();
            keys.ForEach((key) =>
            {
                if (!controlEnabledMap.ContainsKey(key)) { return; }
                controlEnabledMap[key] = key.Enabled;
            });
        }

        /// <summary>
        /// 最後に保存した状態にコントロールの有効状態を復元します。
        /// </summary>
        public void Restore()
        {
            if (InvokeIfRequired(Restore)) { return; }

            foreach(var item in controlEnabledMap)
            {
                item.Key.Enabled = item.Value;
            }
        }

        /// <summary>
        /// 呼び出し元がフォームの作成されたスレッドと異なるスレッド上にある場合、
        /// 指定したメソッドをフォームが作成されたスレッド (Invoke) で呼び出します。
        /// 同じスレッド上にある場合は指定したメソッドを実行しません。
        /// </summary>
        /// <param name="action">フォームが作成されたスレッドで呼び出すメソッド。</param>
        /// <returns>Invoke が呼び出された場合は true。Invoke が呼び出されなかった場合は false。</returns>
        private bool InvokeIfRequired(Action action)
        {
            if (!form.InvokeRequired) { return false; }

            form.Invoke(action);
            return true;
        }
    }
}
