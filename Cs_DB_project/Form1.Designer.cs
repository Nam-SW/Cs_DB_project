namespace Cs_DB_project
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
            this.Bulletin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.login_status = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.TBID = new System.Windows.Forms.TextBox();
            this.LID = new System.Windows.Forms.Label();
            this.LPW = new System.Windows.Forms.Label();
            this.TBPW = new System.Windows.Forms.TextBox();
            this.MyBulletin = new System.Windows.Forms.Button();
            this.LogIn = new System.Windows.Forms.Button();
            this.showall = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.Registration = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bulletin)).BeginInit();
            this.SuspendLayout();
            // 
            // Bulletin
            // 
            this.Bulletin.AllowUserToAddRows = false;
            this.Bulletin.AllowUserToDeleteRows = false;
            this.Bulletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bulletin.Location = new System.Drawing.Point(12, 380);
            this.Bulletin.Name = "Bulletin";
            this.Bulletin.ReadOnly = true;
            this.Bulletin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Bulletin.RowTemplate.Height = 23;
            this.Bulletin.Size = new System.Drawing.Size(776, 207);
            this.Bulletin.TabIndex = 0;
            this.Bulletin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Bulletin_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("이순신 돋움체 B", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "한빛마트 게시판";
            // 
            // login_status
            // 
            this.login_status.AutoSize = true;
            this.login_status.Font = new System.Drawing.Font("이순신 돋움체 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_status.Location = new System.Drawing.Point(269, 19);
            this.login_status.Name = "login_status";
            this.login_status.Size = new System.Drawing.Size(163, 13);
            this.login_status.TabIndex = 21;
            this.login_status.Text = "로그인해야 이용할 수 있습니다.";
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(544, 9);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 22;
            this.LogOut.Text = "로그아웃";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(296, 33);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(100, 21);
            this.TBID.TabIndex = 23;
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Font = new System.Drawing.Font("이순신 돋움체 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LID.Location = new System.Drawing.Point(271, 37);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(19, 13);
            this.LID.TabIndex = 24;
            this.LID.Text = "ID";
            // 
            // LPW
            // 
            this.LPW.AutoSize = true;
            this.LPW.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.LPW.Font = new System.Drawing.Font("이순신 돋움체 B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LPW.Location = new System.Drawing.Point(404, 36);
            this.LPW.Name = "LPW";
            this.LPW.Size = new System.Drawing.Size(28, 13);
            this.LPW.TabIndex = 26;
            this.LPW.Text = "PW";
            // 
            // TBPW
            // 
            this.TBPW.Location = new System.Drawing.Point(438, 33);
            this.TBPW.Name = "TBPW";
            this.TBPW.PasswordChar = '*';
            this.TBPW.Size = new System.Drawing.Size(100, 21);
            this.TBPW.TabIndex = 25;
            // 
            // MyBulletin
            // 
            this.MyBulletin.Location = new System.Drawing.Point(463, 9);
            this.MyBulletin.Name = "MyBulletin";
            this.MyBulletin.Size = new System.Drawing.Size(75, 23);
            this.MyBulletin.TabIndex = 27;
            this.MyBulletin.Text = "내가쓴글";
            this.MyBulletin.UseVisualStyleBackColor = true;
            this.MyBulletin.Click += new System.EventHandler(this.MyBulletin_Click);
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(544, 33);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 28;
            this.LogIn.Text = "로그인";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // showall
            // 
            this.showall.Location = new System.Drawing.Point(42, 351);
            this.showall.Name = "showall";
            this.showall.Size = new System.Drawing.Size(91, 23);
            this.showall.TabIndex = 29;
            this.showall.Text = "전체 글목록";
            this.showall.UseVisualStyleBackColor = true;
            this.showall.Click += new System.EventHandler(this.showall_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("이순신 돋움체 B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.l1.Location = new System.Drawing.Point(38, 85);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(57, 19);
            this.l1.TabIndex = 30;
            this.l1.Text = "글제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("이순신 돋움체 B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "내용";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("이순신 돋움체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(101, 83);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(637, 24);
            this.Title.TabIndex = 32;
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("이순신 돋움체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Content.Location = new System.Drawing.Point(101, 117);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(637, 228);
            this.Content.TabIndex = 34;
            this.Content.Text = "";
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(663, 351);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(75, 23);
            this.Registration.TabIndex = 35;
            this.Registration.Text = "등록";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(582, 351);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 36;
            this.Update.Text = "수정";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(501, 351);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.showall);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.MyBulletin);
            this.Controls.Add(this.LPW);
            this.Controls.Add(this.TBPW);
            this.Controls.Add(this.LID);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.login_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bulletin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Bulletin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Bulletin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_status;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Label LPW;
        private System.Windows.Forms.TextBox TBPW;
        private System.Windows.Forms.Button MyBulletin;
        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button showall;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}

