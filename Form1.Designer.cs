namespace Easy_Scoreboard
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.Score_Left = new System.Windows.Forms.Label();
      this.Score_Right = new System.Windows.Forms.Label();
      this.Colon = new System.Windows.Forms.Label();
      this.Up_Left = new System.Windows.Forms.Button();
      this.Dn_Left = new System.Windows.Forms.Button();
      this.Dn_Right = new System.Windows.Forms.Button();
      this.Up_Right = new System.Windows.Forms.Button();
      this.Team_Left = new System.Windows.Forms.Label();
      this.Team_Right = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Score_Left
      // 
      this.Score_Left.AutoSize = true;
      this.Score_Left.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Score_Left.Location = new System.Drawing.Point(52, 124);
      this.Score_Left.Name = "Score_Left";
      this.Score_Left.Size = new System.Drawing.Size(72, 86);
      this.Score_Left.TabIndex = 0;
      this.Score_Left.Text = "0";
      // 
      // Score_Right
      // 
      this.Score_Right.AutoSize = true;
      this.Score_Right.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Score_Right.Location = new System.Drawing.Point(424, 124);
      this.Score_Right.Name = "Score_Right";
      this.Score_Right.Size = new System.Drawing.Size(72, 86);
      this.Score_Right.TabIndex = 1;
      this.Score_Right.Text = "0";
      // 
      // Colon
      // 
      this.Colon.AutoSize = true;
      this.Colon.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Colon.Location = new System.Drawing.Point(250, 124);
      this.Colon.Name = "Colon";
      this.Colon.Size = new System.Drawing.Size(51, 86);
      this.Colon.TabIndex = 2;
      this.Colon.Text = ":";
      // 
      // Up_Left
      // 
      this.Up_Left.Location = new System.Drawing.Point(41, 251);
      this.Up_Left.Name = "Up_Left";
      this.Up_Left.Size = new System.Drawing.Size(39, 23);
      this.Up_Left.TabIndex = 3;
      this.Up_Left.Text = "Up";
      this.Up_Left.UseVisualStyleBackColor = true;
      this.Up_Left.Click += new System.EventHandler(this.Up_Left_Click);
      // 
      // Dn_Left
      // 
      this.Dn_Left.Location = new System.Drawing.Point(86, 251);
      this.Dn_Left.Name = "Dn_Left";
      this.Dn_Left.Size = new System.Drawing.Size(39, 23);
      this.Dn_Left.TabIndex = 4;
      this.Dn_Left.Text = "Dn";
      this.Dn_Left.UseVisualStyleBackColor = true;
      this.Dn_Left.Click += new System.EventHandler(this.Dn_Left_Click);
      // 
      // Dn_Right
      // 
      this.Dn_Right.Location = new System.Drawing.Point(458, 251);
      this.Dn_Right.Name = "Dn_Right";
      this.Dn_Right.Size = new System.Drawing.Size(39, 23);
      this.Dn_Right.TabIndex = 6;
      this.Dn_Right.Text = "Dn";
      this.Dn_Right.UseVisualStyleBackColor = true;
      this.Dn_Right.Click += new System.EventHandler(this.Dn_Right_Click);
      // 
      // Up_Right
      // 
      this.Up_Right.Location = new System.Drawing.Point(413, 251);
      this.Up_Right.Name = "Up_Right";
      this.Up_Right.Size = new System.Drawing.Size(39, 23);
      this.Up_Right.TabIndex = 5;
      this.Up_Right.Text = "Up";
      this.Up_Right.UseVisualStyleBackColor = true;
      this.Up_Right.Click += new System.EventHandler(this.Up_Right_Click);
      // 
      // Team_Left
      // 
      this.Team_Left.AutoSize = true;
      this.Team_Left.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Team_Left.Location = new System.Drawing.Point(21, 72);
      this.Team_Left.Name = "Team_Left";
      this.Team_Left.Size = new System.Drawing.Size(127, 50);
      this.Team_Left.TabIndex = 7;
      this.Team_Left.Text = "Team1";
      // 
      // Team_Right
      // 
      this.Team_Right.AutoSize = true;
      this.Team_Right.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Team_Right.Location = new System.Drawing.Point(386, 72);
      this.Team_Right.Name = "Team_Right";
      this.Team_Right.Size = new System.Drawing.Size(127, 50);
      this.Team_Right.TabIndex = 8;
      this.Team_Right.Text = "Team2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(544, 372);
      this.Controls.Add(this.Team_Right);
      this.Controls.Add(this.Team_Left);
      this.Controls.Add(this.Dn_Right);
      this.Controls.Add(this.Up_Right);
      this.Controls.Add(this.Dn_Left);
      this.Controls.Add(this.Up_Left);
      this.Controls.Add(this.Colon);
      this.Controls.Add(this.Score_Right);
      this.Controls.Add(this.Score_Left);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Easy-Scoreboard";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label Score_Left;
    private System.Windows.Forms.Label Score_Right;
    private System.Windows.Forms.Label Colon;
    private System.Windows.Forms.Button Up_Left;
    private System.Windows.Forms.Button Dn_Left;
    private System.Windows.Forms.Button Dn_Right;
    private System.Windows.Forms.Button Up_Right;
    private System.Windows.Forms.Label Team_Left;
    private System.Windows.Forms.Label Team_Right;
  }
}

