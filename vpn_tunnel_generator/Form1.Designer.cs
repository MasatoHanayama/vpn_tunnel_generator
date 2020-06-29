namespace vpn_tunnel_generator
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tunnel_name = new System.Windows.Forms.TextBox();
            this.nat_chk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.server_address = new System.Windows.Forms.TextBox();
            this.pre_shared_key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recordUser_chk = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "トンネル名";
            // 
            // tunnel_name
            // 
            this.tunnel_name.Location = new System.Drawing.Point(73, 10);
            this.tunnel_name.Name = "tunnel_name";
            this.tunnel_name.Size = new System.Drawing.Size(214, 19);
            this.tunnel_name.TabIndex = 1;
            // 
            // nat_chk
            // 
            this.nat_chk.AutoSize = true;
            this.nat_chk.Location = new System.Drawing.Point(15, 85);
            this.nat_chk.Name = "nat_chk";
            this.nat_chk.Size = new System.Drawing.Size(217, 16);
            this.nat_chk.TabIndex = 4;
            this.nat_chk.Text = "NATトラバーサル有効化(再起動が必要)";
            this.nat_chk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "サーバアドレス";
            // 
            // server_address
            // 
            this.server_address.Location = new System.Drawing.Point(89, 35);
            this.server_address.Name = "server_address";
            this.server_address.Size = new System.Drawing.Size(198, 19);
            this.server_address.TabIndex = 2;
            // 
            // pre_shared_key
            // 
            this.pre_shared_key.Location = new System.Drawing.Point(83, 60);
            this.pre_shared_key.Name = "pre_shared_key";
            this.pre_shared_key.Size = new System.Drawing.Size(204, 19);
            this.pre_shared_key.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "事前共有鍵";
            // 
            // recordUser_chk
            // 
            this.recordUser_chk.AutoSize = true;
            this.recordUser_chk.Location = new System.Drawing.Point(15, 107);
            this.recordUser_chk.Name = "recordUser_chk";
            this.recordUser_chk.Size = new System.Drawing.Size(116, 16);
            this.recordUser_chk.TabIndex = 5;
            this.recordUser_chk.Text = "ユーザーを記憶する";
            this.recordUser_chk.UseVisualStyleBackColor = true;
            this.recordUser_chk.CheckedChanged += new System.EventHandler(this.recordUser_chk_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "ユーザ名";
            // 
            // user_name
            // 
            this.user_name.Enabled = false;
            this.user_name.Location = new System.Drawing.Point(65, 129);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(222, 19);
            this.user_name.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "パスワード";
            // 
            // user_password
            // 
            this.user_password.Enabled = false;
            this.user_password.Location = new System.Drawing.Point(65, 154);
            this.user_password.Name = "user_password";
            this.user_password.PasswordChar = '*';
            this.user_password.Size = new System.Drawing.Size(222, 19);
            this.user_password.TabIndex = 7;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(212, 179);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 8;
            this.acceptButton.Text = "設定";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // mainForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 211);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.pre_shared_key);
            this.Controls.Add(this.server_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordUser_chk);
            this.Controls.Add(this.nat_chk);
            this.Controls.Add(this.tunnel_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "VPN TUNNEL GENERATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tunnel_name;
        private System.Windows.Forms.CheckBox nat_chk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox server_address;
        private System.Windows.Forms.TextBox pre_shared_key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox recordUser_chk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button acceptButton;
    }
}

