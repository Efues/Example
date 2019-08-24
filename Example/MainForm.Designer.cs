namespace Example
{
  partial class MainForm
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
      this.buttonOpenSubform = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBoxStatus = new System.Windows.Forms.TextBox();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonOpenSubform
      // 
      this.buttonOpenSubform.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.buttonOpenSubform.Location = new System.Drawing.Point(22, 12);
      this.buttonOpenSubform.Name = "buttonOpenSubform";
      this.buttonOpenSubform.Size = new System.Drawing.Size(332, 95);
      this.buttonOpenSubform.TabIndex = 0;
      this.buttonOpenSubform.Text = "OpenSubForm";
      this.buttonOpenSubform.UseVisualStyleBackColor = true;
      this.buttonOpenSubform.Click += new System.EventHandler(this.buttonOpenSubform_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.textBoxStatus);
      this.groupBox1.Location = new System.Drawing.Point(22, 129);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(525, 239);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Status";
      // 
      // textBoxStatus
      // 
      this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxStatus.Location = new System.Drawing.Point(6, 24);
      this.textBoxStatus.Multiline = true;
      this.textBoxStatus.Name = "textBoxStatus";
      this.textBoxStatus.Size = new System.Drawing.Size(513, 209);
      this.textBoxStatus.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(559, 380);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.buttonOpenSubform);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MainForm";
      this.Text = "Main Form";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button buttonOpenSubform;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBoxStatus;
  }
}

