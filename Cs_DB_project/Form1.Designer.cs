﻿namespace Cs_DB_project
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
            this.Revise = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SearchOption = new System.Windows.Forms.ComboBox();
            this.SearchKey = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.reply = new System.Windows.Forms.Label();
            this.TBreply = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTReply = new System.Windows.Forms.Button();
            this.ReplyList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Bulletin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReplyList)).BeginInit();
            this.SuspendLayout();
            // 
            // Bulletin
            // 
            this.Bulletin.AllowUserToAddRows = false;
            this.Bulletin.AllowUserToDeleteRows = false;
            this.Bulletin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bulletin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bulletin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bulletin.Location = new System.Drawing.Point(12, 580);
            this.Bulletin.Name = "Bulletin";
            this.Bulletin.ReadOnly = true;
            this.Bulletin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Bulletin.RowTemplate.Height = 23;
            this.Bulletin.Size = new System.Drawing.Size(803, 170);
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
            this.showall.Location = new System.Drawing.Point(25, 551);
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
            this.l1.Location = new System.Drawing.Point(21, 85);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(57, 19);
            this.l1.TabIndex = 30;
            this.l1.Text = "글제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("이순신 돋움체 B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "내용";
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("이순신 돋움체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(84, 83);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(637, 24);
            this.Title.TabIndex = 32;
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("이순신 돋움체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Content.Location = new System.Drawing.Point(84, 117);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(637, 228);
            this.Content.TabIndex = 34;
            this.Content.Text = "";
            // 
            // Registration
            // 
            this.Registration.Location = new System.Drawing.Point(727, 84);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(75, 23);
            this.Registration.TabIndex = 35;
            this.Registration.Text = "등록";
            this.Registration.UseVisualStyleBackColor = true;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Revise
            // 
            this.Revise.Location = new System.Drawing.Point(727, 113);
            this.Revise.Name = "Revise";
            this.Revise.Size = new System.Drawing.Size(75, 23);
            this.Revise.TabIndex = 36;
            this.Revise.Text = "수정";
            this.Revise.UseVisualStyleBackColor = true;
            this.Revise.Click += new System.EventHandler(this.Revise_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(727, 142);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 37;
            this.Delete.Text = "삭제";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SearchOption
            // 
            this.SearchOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchOption.FormattingEnabled = true;
            this.SearchOption.Location = new System.Drawing.Point(504, 554);
            this.SearchOption.Name = "SearchOption";
            this.SearchOption.Size = new System.Drawing.Size(89, 20);
            this.SearchOption.TabIndex = 38;
            // 
            // SearchKey
            // 
            this.SearchKey.Location = new System.Drawing.Point(599, 553);
            this.SearchKey.Name = "SearchKey";
            this.SearchKey.Size = new System.Drawing.Size(135, 21);
            this.SearchKey.TabIndex = 39;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(740, 551);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 40;
            this.Search.Text = "검색";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // reply
            // 
            this.reply.AutoSize = true;
            this.reply.Font = new System.Drawing.Font("이순신 돋움체 B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reply.Location = new System.Drawing.Point(21, 351);
            this.reply.Name = "reply";
            this.reply.Size = new System.Drawing.Size(41, 19);
            this.reply.TabIndex = 42;
            this.reply.Text = "댓글";
            // 
            // TBreply
            // 
            this.TBreply.Font = new System.Drawing.Font("이순신 돋움체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TBreply.Location = new System.Drawing.Point(84, 488);
            this.TBreply.Name = "TBreply";
            this.TBreply.Size = new System.Drawing.Size(574, 57);
            this.TBreply.TabIndex = 43;
            this.TBreply.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("이순신 돋움체 B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(11, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "댓글작성";
            // 
            // BTReply
            // 
            this.BTReply.Location = new System.Drawing.Point(659, 488);
            this.BTReply.Name = "BTReply";
            this.BTReply.Size = new System.Drawing.Size(62, 57);
            this.BTReply.TabIndex = 45;
            this.BTReply.Text = "댓글작성";
            this.BTReply.UseVisualStyleBackColor = true;
            this.BTReply.Click += new System.EventHandler(this.BTReply_Click);
            // 
            // ReplyList
            // 
            this.ReplyList.AllowUserToAddRows = false;
            this.ReplyList.AllowUserToDeleteRows = false;
            this.ReplyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReplyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReplyList.Location = new System.Drawing.Point(84, 351);
            this.ReplyList.Name = "ReplyList";
            this.ReplyList.ReadOnly = true;
            this.ReplyList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ReplyList.RowTemplate.Height = 23;
            this.ReplyList.Size = new System.Drawing.Size(637, 131);
            this.ReplyList.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 762);
            this.Controls.Add(this.ReplyList);
            this.Controls.Add(this.BTReply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBreply);
            this.Controls.Add(this.reply);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchKey);
            this.Controls.Add(this.SearchOption);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Revise);
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
            ((System.ComponentModel.ISupportInitialize)(this.ReplyList)).EndInit();
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
        private System.Windows.Forms.Button Revise;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ComboBox SearchOption;
        private System.Windows.Forms.TextBox SearchKey;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label reply;
        private System.Windows.Forms.RichTextBox TBreply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTReply;
        private System.Windows.Forms.DataGridView ReplyList;
    }
}

