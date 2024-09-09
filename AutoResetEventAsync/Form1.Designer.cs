namespace AutoResetEventAsync
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.btn_Set = new System.Windows.Forms.Button();
            this.btn_Await = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.chk_KeepOrder = new System.Windows.Forms.CheckBox();
            this.chk_InitSet = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(388, 27);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(104, 40);
            this.btn_Set.TabIndex = 0;
            this.btn_Set.Text = "Set";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // btn_Await
            // 
            this.btn_Await.Location = new System.Drawing.Point(388, 73);
            this.btn_Await.Name = "btn_Await";
            this.btn_Await.Size = new System.Drawing.Size(104, 40);
            this.btn_Await.TabIndex = 1;
            this.btn_Await.Text = "Await";
            this.btn_Await.UseVisualStyleBackColor = true;
            this.btn_Await.Click += new System.EventHandler(this.btn_Await_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(388, 119);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(104, 40);
            this.btn_Reset.TabIndex = 2;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 31);
            this.textBox1.TabIndex = 3;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(388, 165);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 40);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // chk_KeepOrder
            // 
            this.chk_KeepOrder.AutoSize = true;
            this.chk_KeepOrder.Location = new System.Drawing.Point(27, 85);
            this.chk_KeepOrder.Name = "chk_KeepOrder";
            this.chk_KeepOrder.Size = new System.Drawing.Size(149, 28);
            this.chk_KeepOrder.TabIndex = 5;
            this.chk_KeepOrder.Text = "KeepOrder";
            this.chk_KeepOrder.UseVisualStyleBackColor = true;
            // 
            // chk_InitSet
            // 
            this.chk_InitSet.AutoSize = true;
            this.chk_InitSet.Location = new System.Drawing.Point(27, 131);
            this.chk_InitSet.Name = "chk_InitSet";
            this.chk_InitSet.Size = new System.Drawing.Size(107, 28);
            this.chk_InitSet.TabIndex = 6;
            this.chk_InitSet.Text = "InitSet";
            this.chk_InitSet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 259);
            this.Controls.Add(this.chk_InitSet);
            this.Controls.Add(this.chk_KeepOrder);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Await);
            this.Controls.Add(this.btn_Set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Button btn_Await;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckBox chk_KeepOrder;
        private System.Windows.Forms.CheckBox chk_InitSet;
    }
}

