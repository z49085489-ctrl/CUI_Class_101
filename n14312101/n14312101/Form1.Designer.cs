namespace n14312101
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ClickMe = new System.Windows.Forms.Button();
            this.btn_ChangeLabel = new System.Windows.Forms.Button();
            this.lab_ChangeLabel = new System.Windows.Forms.Label();
            this.lab_Counter = new System.Windows.Forms.Label();
            this.btn_Counter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "N14312101-戴廣進";
            // 
            // btn_ClickMe
            // 
            this.btn_ClickMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ClickMe.Font = new System.Drawing.Font("標楷體", 15F);
            this.btn_ClickMe.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_ClickMe.Location = new System.Drawing.Point(40, 111);
            this.btn_ClickMe.Name = "btn_ClickMe";
            this.btn_ClickMe.Size = new System.Drawing.Size(208, 55);
            this.btn_ClickMe.TabIndex = 1;
            this.btn_ClickMe.Text = "按我一下";
            this.btn_ClickMe.UseVisualStyleBackColor = false;
            this.btn_ClickMe.Click += new System.EventHandler(this.bun_ClickMe_Click);
            // 
            // btn_ChangeLabel
            // 
            this.btn_ChangeLabel.Location = new System.Drawing.Point(20, 192);
            this.btn_ChangeLabel.Name = "btn_ChangeLabel";
            this.btn_ChangeLabel.Size = new System.Drawing.Size(117, 45);
            this.btn_ChangeLabel.TabIndex = 2;
            this.btn_ChangeLabel.Text = "按一下切換";
            this.btn_ChangeLabel.UseVisualStyleBackColor = true;
            this.btn_ChangeLabel.Click += new System.EventHandler(this.bun_Label_Click);
            // 
            // lab_ChangeLabel
            // 
            this.lab_ChangeLabel.AutoSize = true;
            this.lab_ChangeLabel.Location = new System.Drawing.Point(175, 208);
            this.lab_ChangeLabel.Name = "lab_ChangeLabel";
            this.lab_ChangeLabel.Size = new System.Drawing.Size(33, 12);
            this.lab_ChangeLabel.TabIndex = 3;
            this.lab_ChangeLabel.Text = "label2";
            this.lab_ChangeLabel.Click += new System.EventHandler(this.lab_ChangeLabel_Click);
            // 
            // lab_Counter
            // 
            this.lab_Counter.AutoSize = true;
            this.lab_Counter.Location = new System.Drawing.Point(175, 286);
            this.lab_Counter.Name = "lab_Counter";
            this.lab_Counter.Size = new System.Drawing.Size(11, 12);
            this.lab_Counter.TabIndex = 5;
            this.lab_Counter.Text = "0";
            // 
            // btn_Counter
            // 
            this.btn_Counter.Location = new System.Drawing.Point(20, 270);
            this.btn_Counter.Name = "btn_Counter";
            this.btn_Counter.Size = new System.Drawing.Size(117, 45);
            this.btn_Counter.TabIndex = 4;
            this.btn_Counter.Text = "按一下+1";
            this.btn_Counter.UseVisualStyleBackColor = true;
            this.btn_Counter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lab_Counter);
            this.Controls.Add(this.btn_Counter);
            this.Controls.Add(this.lab_ChangeLabel);
            this.Controls.Add(this.btn_ChangeLabel);
            this.Controls.Add(this.btn_ClickMe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ClickMe;
        private System.Windows.Forms.Button btn_ChangeLabel;
        private System.Windows.Forms.Label lab_ChangeLabel;
        private System.Windows.Forms.Label lab_Counter;
        private System.Windows.Forms.Button btn_Counter;
    }
}

