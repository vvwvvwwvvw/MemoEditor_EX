namespace MemoEditor_EX
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
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveFileName = new System.Windows.Forms.TextBox();
            this.txtOpenFileName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(12, 12);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(557, 666);
            this.txtMemo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "저장 파일 이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "불러오기 파일 이름 :";
            // 
            // txtSaveFileName
            // 
            this.txtSaveFileName.Location = new System.Drawing.Point(774, 15);
            this.txtSaveFileName.Name = "txtSaveFileName";
            this.txtSaveFileName.Size = new System.Drawing.Size(250, 25);
            this.txtSaveFileName.TabIndex = 3;
            // 
            // txtOpenFileName
            // 
            this.txtOpenFileName.Location = new System.Drawing.Point(774, 179);
            this.txtOpenFileName.Name = "txtOpenFileName";
            this.txtOpenFileName.Size = new System.Drawing.Size(250, 25);
            this.txtOpenFileName.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(611, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "파일 저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(611, 259);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(157, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "파일 불러오기";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 690);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOpenFileName);
            this.Controls.Add(this.txtSaveFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveFileName;
        private System.Windows.Forms.TextBox txtOpenFileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

