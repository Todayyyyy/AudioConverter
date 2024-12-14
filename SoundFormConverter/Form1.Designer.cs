namespace SoundFormConverter
{
    partial class Converter
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.FileDragBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FileDragBox
            // 
            this.FileDragBox.AllowDrop = true;
            this.FileDragBox.BackColor = System.Drawing.Color.White;
            this.FileDragBox.ForeColor = System.Drawing.Color.Black;
            this.FileDragBox.Location = new System.Drawing.Point(12, 12);
            this.FileDragBox.Name = "FileDragBox";
            this.FileDragBox.Size = new System.Drawing.Size(126, 21);
            this.FileDragBox.TabIndex = 0;
            this.FileDragBox.Text = "请将文件拖拽至此";
            this.FileDragBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDragBox_DragDrop);
            this.FileDragBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDragBox_DragEnter);
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.Black;
            this.convertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.convertButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(156, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.convertButton.Size = new System.Drawing.Size(80, 47);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "点击转换";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // formatComboBox
            // 
            this.formatComboBox.BackColor = System.Drawing.Color.White;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "mp3",
            "wav"});
            this.formatComboBox.Location = new System.Drawing.Point(12, 39);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(67, 20);
            this.formatComboBox.TabIndex = 2;
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(249, 73);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.FileDragBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Converter";
            this.Text = "格式转换器";
            this.Load += new System.EventHandler(this.Converter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileDragBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox formatComboBox;
    }
}

