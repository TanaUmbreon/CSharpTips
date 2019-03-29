namespace Tips.Forms
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelWidthInfo = new System.Windows.Forms.Label();
            this.buttonSwitch3 = new System.Windows.Forms.Button();
            this.buttonSwitch2 = new System.Windows.Forms.Button();
            this.buttonSwitch1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ブラッキーと一緒に暮らしたい";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "ブラッキーは俺の嫁";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 23);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "ブラッキー可愛いよブラッキー";
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRun.Location = new System.Drawing.Point(208, 282);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(100, 32);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "長い処理";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelWidthInfo);
            this.groupBox1.Controls.Add(this.buttonSwitch3);
            this.groupBox1.Controls.Add(this.buttonSwitch2);
            this.groupBox1.Controls.Add(this.buttonSwitch1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox1.Size = new System.Drawing.Size(493, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "作者のつぶやき";
            // 
            // labelWidthInfo
            // 
            this.labelWidthInfo.AutoSize = true;
            this.labelWidthInfo.Location = new System.Drawing.Point(9, 217);
            this.labelWidthInfo.Name = "labelWidthInfo";
            this.labelWidthInfo.Size = new System.Drawing.Size(379, 15);
            this.labelWidthInfo.TabIndex = 6;
            this.labelWidthInfo.Text = "どうでもいいけど↑の幅は {0} ピクセル (※ディスプレイ設定などの環境で変動)";
            // 
            // buttonSwitch3
            // 
            this.buttonSwitch3.Location = new System.Drawing.Point(9, 162);
            this.buttonSwitch3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.buttonSwitch3.Name = "buttonSwitch3";
            this.buttonSwitch3.Size = new System.Drawing.Size(197, 23);
            this.buttonSwitch3.TabIndex = 4;
            this.buttonSwitch3.Text = "有効状態を切り替える 3";
            this.buttonSwitch3.UseVisualStyleBackColor = true;
            this.buttonSwitch3.Click += new System.EventHandler(this.buttonSwitch3_Click);
            // 
            // buttonSwitch2
            // 
            this.buttonSwitch2.Location = new System.Drawing.Point(9, 92);
            this.buttonSwitch2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.buttonSwitch2.Name = "buttonSwitch2";
            this.buttonSwitch2.Size = new System.Drawing.Size(197, 23);
            this.buttonSwitch2.TabIndex = 2;
            this.buttonSwitch2.Text = "有効状態を切り替える 2";
            this.buttonSwitch2.UseVisualStyleBackColor = true;
            this.buttonSwitch2.Click += new System.EventHandler(this.buttonSwitch2_Click);
            // 
            // buttonSwitch1
            // 
            this.buttonSwitch1.Location = new System.Drawing.Point(9, 22);
            this.buttonSwitch1.Name = "buttonSwitch1";
            this.buttonSwitch1.Size = new System.Drawing.Size(197, 23);
            this.buttonSwitch1.TabIndex = 0;
            this.buttonSwitch1.Text = "有効状態を切り替える 1";
            this.buttonSwitch1.UseVisualStyleBackColor = true;
            this.buttonSwitch1.Click += new System.EventHandler(this.buttonSwitch1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(224, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox2.Size = new System.Drawing.Size(255, 163);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "あなたの好きな番号は？";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(88, 122);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            197,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            197,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 23);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            197,
            0,
            0,
            0});
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 97);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(234, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "え？ この世に 197 以外の番号ってあるの？";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(9, 122);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(73, 19);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "自由回答";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(9, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(166, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "むしろ 197 以外考えられない";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "197 に決まってる";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "197 です";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "※これはあくまで、コントロールの有効状態を保持して元に戻す機能のデモです！";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRun);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "コントロールの有効状態を保持して元に戻す";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSwitch1;
        private System.Windows.Forms.Button buttonSwitch2;
        private System.Windows.Forms.Button buttonSwitch3;
        private System.Windows.Forms.Label labelWidthInfo;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

