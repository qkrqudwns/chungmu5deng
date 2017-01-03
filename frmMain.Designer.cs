namespace signDrivenMenu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLoadSignImage = new System.Windows.Forms.Button();
            this.pbxSign = new System.Windows.Forms.PictureBox();
            this.btnExtractSign = new System.Windows.Forms.Button();
            this.btnSearchKeyword = new System.Windows.Forms.Button();
            this.btnExtractInfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMenuInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxMenu6 = new System.Windows.Forms.PictureBox();
            this.pbxMenu5 = new System.Windows.Forms.PictureBox();
            this.pbxMenu4 = new System.Windows.Forms.PictureBox();
            this.pbxMenu3 = new System.Windows.Forms.PictureBox();
            this.pbxMenu2 = new System.Windows.Forms.PictureBox();
            this.pbxMenu1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMenuData = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSignName = new System.Windows.Forms.RichTextBox();
            this.btnSearchImage = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLoadMenuImage = new System.Windows.Forms.Button();
            this.btnImageProcess = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbxLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSign)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadSignImage
            // 
            this.btnLoadSignImage.Location = new System.Drawing.Point(3, 21);
            this.btnLoadSignImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadSignImage.Name = "btnLoadSignImage";
            this.btnLoadSignImage.Size = new System.Drawing.Size(202, 23);
            this.btnLoadSignImage.TabIndex = 0;
            this.btnLoadSignImage.Text = "간판 사진 불러오기";
            this.btnLoadSignImage.UseVisualStyleBackColor = true;
            this.btnLoadSignImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // pbxSign
            // 
            this.pbxSign.BackColor = System.Drawing.Color.White;
            this.pbxSign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSign.BackgroundImage")));
            this.pbxSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxSign.Location = new System.Drawing.Point(7, 33);
            this.pbxSign.Margin = new System.Windows.Forms.Padding(2);
            this.pbxSign.Name = "pbxSign";
            this.pbxSign.Size = new System.Drawing.Size(160, 153);
            this.pbxSign.TabIndex = 1;
            this.pbxSign.TabStop = false;
            this.pbxSign.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnExtractSign
            // 
            this.btnExtractSign.Location = new System.Drawing.Point(3, 75);
            this.btnExtractSign.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtractSign.Name = "btnExtractSign";
            this.btnExtractSign.Size = new System.Drawing.Size(202, 23);
            this.btnExtractSign.TabIndex = 3;
            this.btnExtractSign.Text = "간판명 추출";
            this.btnExtractSign.UseVisualStyleBackColor = true;
            this.btnExtractSign.Click += new System.EventHandler(this.btnExtractSign_Click);
            // 
            // btnSearchKeyword
            // 
            this.btnSearchKeyword.Enabled = false;
            this.btnSearchKeyword.Location = new System.Drawing.Point(4, 129);
            this.btnSearchKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchKeyword.Name = "btnSearchKeyword";
            this.btnSearchKeyword.Size = new System.Drawing.Size(202, 23);
            this.btnSearchKeyword.TabIndex = 4;
            this.btnSearchKeyword.Text = "키워드로 검색";
            this.btnSearchKeyword.UseVisualStyleBackColor = true;
            this.btnSearchKeyword.Click += new System.EventHandler(this.btnSearchKeyword_Click);
            // 
            // btnExtractInfo
            // 
            this.btnExtractInfo.Location = new System.Drawing.Point(4, 183);
            this.btnExtractInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtractInfo.Name = "btnExtractInfo";
            this.btnExtractInfo.Size = new System.Drawing.Size(202, 23);
            this.btnExtractInfo.TabIndex = 6;
            this.btnExtractInfo.Text = "메뉴 텍스트 추출";
            this.btnExtractInfo.UseVisualStyleBackColor = true;
            this.btnExtractInfo.Click += new System.EventHandler(this.btnExtractInfo_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(4, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "사용자 단말로 전송";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(223, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(612, 409);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업 내용";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbxMenuInfo);
            this.groupBox4.Location = new System.Drawing.Point(417, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(191, 387);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step3. 메뉴 만들기";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "메뉴정보";
            // 
            // tbxMenuInfo
            // 
            this.tbxMenuInfo.BackColor = System.Drawing.Color.White;
            this.tbxMenuInfo.Location = new System.Drawing.Point(4, 33);
            this.tbxMenuInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMenuInfo.Name = "tbxMenuInfo";
            this.tbxMenuInfo.ReadOnly = true;
            this.tbxMenuInfo.Size = new System.Drawing.Size(188, 355);
            this.tbxMenuInfo.TabIndex = 8;
            this.tbxMenuInfo.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pbxMenu6);
            this.groupBox3.Controls.Add(this.pbxMenu5);
            this.groupBox3.Controls.Add(this.pbxMenu4);
            this.groupBox3.Controls.Add(this.pbxMenu3);
            this.groupBox3.Controls.Add(this.pbxMenu2);
            this.groupBox3.Controls.Add(this.pbxMenu1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbxMenuData);
            this.groupBox3.Location = new System.Drawing.Point(184, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(228, 387);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step2. 메뉴 추출";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "추출 텍스트";
            // 
            // pbxMenu6
            // 
            this.pbxMenu6.BackColor = System.Drawing.Color.White;
            this.pbxMenu6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMenu6.BackgroundImage")));
            this.pbxMenu6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxMenu6.Location = new System.Drawing.Point(153, 103);
            this.pbxMenu6.Margin = new System.Windows.Forms.Padding(2);
            this.pbxMenu6.Name = "pbxMenu6";
            this.pbxMenu6.Size = new System.Drawing.Size(70, 67);
            this.pbxMenu6.TabIndex = 7;
            this.pbxMenu6.TabStop = false;
            this.pbxMenu6.Click += new System.EventHandler(this.pbxMenu6_Click);
            // 
            // pbxMenu5
            // 
            this.pbxMenu5.BackColor = System.Drawing.Color.White;
            this.pbxMenu5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMenu5.BackgroundImage")));
            this.pbxMenu5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxMenu5.Location = new System.Drawing.Point(79, 103);
            this.pbxMenu5.Margin = new System.Windows.Forms.Padding(2);
            this.pbxMenu5.Name = "pbxMenu5";
            this.pbxMenu5.Size = new System.Drawing.Size(70, 67);
            this.pbxMenu5.TabIndex = 6;
            this.pbxMenu5.TabStop = false;
            this.pbxMenu5.Click += new System.EventHandler(this.pbxMenu5_Click);
            // 
            // pbxMenu4
            // 
            this.pbxMenu4.BackColor = System.Drawing.Color.White;
            this.pbxMenu4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMenu4.BackgroundImage")));
            this.pbxMenu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxMenu4.Location = new System.Drawing.Point(5, 103);
            this.pbxMenu4.Margin = new System.Windows.Forms.Padding(2);
            this.pbxMenu4.Name = "pbxMenu4";
            this.pbxMenu4.Size = new System.Drawing.Size(70, 67);
            this.pbxMenu4.TabIndex = 5;
            this.pbxMenu4.TabStop = false;
            this.pbxMenu4.Click += new System.EventHandler(this.pbxMenu4_Click);
            // 
            // pbxMenu3
            // 
            this.pbxMenu3.BackColor = System.Drawing.Color.White;
            this.pbxMenu3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMenu3.BackgroundImage")));
            this.pbxMenu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxMenu3.Location = new System.Drawing.Point(153, 33);
            this.pbxMenu3.Margin = new System.Windows.Forms.Padding(2);
            this.pbxMenu3.Name = "pbxMenu3";
            this.pbxMenu3.Size = new System.Drawing.Size(70, 67);
            this.pbxMenu3.TabIndex = 4;
            this.pbxMenu3.TabStop = false;
            this.pbxMenu3.Click += new System.EventHandler(this.pbxMenu3_Click);
            // 
            // pbxMenu2
            // 
            this.pbxMenu2.BackColor = System.Drawing.Color.White;
            this.pbxMenu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMenu2.BackgroundImage")));
            this.pbxMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxMenu2.Location = new System.Drawing.Point(79, 33);
            this.pbxMenu2.Margin = new System.Windows.Forms.Padding(2);
            this.pbxMenu2.Name = "pbxMenu2";
            this.pbxMenu2.Size = new System.Drawing.Size(70, 67);
            this.pbxMenu2.TabIndex = 3;
            this.pbxMenu2.TabStop = false;
            this.pbxMenu2.Click += new System.EventHandler(this.pbxMenu2_Click);
            // 
            // pbxMenu1
            // 
            this.pbxMenu1.BackColor = System.Drawing.Color.White;
            this.pbxMenu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxMenu1.BackgroundImage")));
            this.pbxMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxMenu1.Location = new System.Drawing.Point(5, 33);
            this.pbxMenu1.Margin = new System.Windows.Forms.Padding(2);
            this.pbxMenu1.Name = "pbxMenu1";
            this.pbxMenu1.Size = new System.Drawing.Size(70, 67);
            this.pbxMenu1.TabIndex = 2;
            this.pbxMenu1.TabStop = false;
            this.pbxMenu1.Click += new System.EventHandler(this.pbxMenu1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "메뉴사진";
            // 
            // tbxMenuData
            // 
            this.tbxMenuData.BackColor = System.Drawing.Color.White;
            this.tbxMenuData.Location = new System.Drawing.Point(4, 189);
            this.tbxMenuData.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMenuData.Name = "tbxMenuData";
            this.tbxMenuData.ReadOnly = true;
            this.tbxMenuData.Size = new System.Drawing.Size(220, 195);
            this.tbxMenuData.TabIndex = 0;
            this.tbxMenuData.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxSignName);
            this.groupBox2.Controls.Add(this.pbxSign);
            this.groupBox2.Location = new System.Drawing.Point(5, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(175, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step1. 간판명 추출";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "추출 간판명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "간판 사진";
            // 
            // tbxSignName
            // 
            this.tbxSignName.BackColor = System.Drawing.Color.White;
            this.tbxSignName.Location = new System.Drawing.Point(7, 215);
            this.tbxSignName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSignName.Name = "tbxSignName";
            this.tbxSignName.ReadOnly = true;
            this.tbxSignName.Size = new System.Drawing.Size(161, 169);
            this.tbxSignName.TabIndex = 0;
            this.tbxSignName.Text = "";
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.Enabled = false;
            this.btnSearchImage.Location = new System.Drawing.Point(4, 156);
            this.btnSearchImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchImage.Name = "btnSearchImage";
            this.btnSearchImage.Size = new System.Drawing.Size(202, 23);
            this.btnSearchImage.TabIndex = 5;
            this.btnSearchImage.Text = "이미지로 검색";
            this.btnSearchImage.UseVisualStyleBackColor = true;
            this.btnSearchImage.Click += new System.EventHandler(this.btnSearchImage_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLoadMenuImage);
            this.groupBox5.Controls.Add(this.btnImageProcess);
            this.groupBox5.Controls.Add(this.btnExtractSign);
            this.groupBox5.Controls.Add(this.btnLoadSignImage);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnSearchKeyword);
            this.groupBox5.Controls.Add(this.btnSearchImage);
            this.groupBox5.Controls.Add(this.btnExtractInfo);
            this.groupBox5.Location = new System.Drawing.Point(8, 9);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(210, 239);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "제어부";
            // 
            // btnLoadMenuImage
            // 
            this.btnLoadMenuImage.Location = new System.Drawing.Point(3, 102);
            this.btnLoadMenuImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadMenuImage.Name = "btnLoadMenuImage";
            this.btnLoadMenuImage.Size = new System.Drawing.Size(202, 23);
            this.btnLoadMenuImage.TabIndex = 10;
            this.btnLoadMenuImage.Text = "메뉴 사진 불러오기";
            this.btnLoadMenuImage.UseVisualStyleBackColor = true;
            // 
            // btnImageProcess
            // 
            this.btnImageProcess.Enabled = false;
            this.btnImageProcess.Location = new System.Drawing.Point(3, 48);
            this.btnImageProcess.Margin = new System.Windows.Forms.Padding(2);
            this.btnImageProcess.Name = "btnImageProcess";
            this.btnImageProcess.Size = new System.Drawing.Size(202, 23);
            this.btnImageProcess.TabIndex = 9;
            this.btnImageProcess.Text = "간판 이미지프로세싱";
            this.btnImageProcess.UseVisualStyleBackColor = true;
            this.btnImageProcess.Click += new System.EventHandler(this.btnImageProcess_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbxLog);
            this.groupBox6.Location = new System.Drawing.Point(8, 422);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(827, 197);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "로그";
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.Color.White;
            this.tbxLog.Location = new System.Drawing.Point(4, 18);
            this.tbxLog.Margin = new System.Windows.Forms.Padding(2);
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.Size = new System.Drawing.Size(820, 177);
            this.tbxLog.TabIndex = 4;
            this.tbxLog.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 588);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "여긴 뭐 팔지? ver 1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSign)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadSignImage;
        private System.Windows.Forms.PictureBox pbxSign;
        private System.Windows.Forms.Button btnExtractSign;
        private System.Windows.Forms.Button btnSearchKeyword;
        private System.Windows.Forms.Button btnExtractInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tbxSignName;
        private System.Windows.Forms.Button btnSearchImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbxMenu6;
        private System.Windows.Forms.PictureBox pbxMenu5;
        private System.Windows.Forms.PictureBox pbxMenu4;
        private System.Windows.Forms.PictureBox pbxMenu3;
        private System.Windows.Forms.PictureBox pbxMenu2;
        private System.Windows.Forms.PictureBox pbxMenu1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbxMenuData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbxMenuInfo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox tbxLog;
        private System.Windows.Forms.Button btnImageProcess;
        private System.Windows.Forms.Button btnLoadMenuImage;
    }
}

