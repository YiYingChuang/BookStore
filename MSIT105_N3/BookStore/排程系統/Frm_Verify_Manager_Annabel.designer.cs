namespace Form_Verify
{
    partial class Frm_Verify_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_verify_man_notification = new System.Windows.Forms.ListBox();
            this.lbl_verify_man_title = new System.Windows.Forms.Label();
            this.lbx_verify_man_location = new System.Windows.Forms.ListBox();
            this.lbl_verify_man_location = new System.Windows.Forms.Label();
            this.dom_verify_man_applyreason = new System.Windows.Forms.DomainUpDown();
            this.ibl_verify_man_applyreason = new System.Windows.Forms.Label();
            this.dtp_verify_man_apply = new System.Windows.Forms.DateTimePicker();
            this.lbl_verify_man_applytime = new System.Windows.Forms.Label();
            this.txt_verify_man_name = new System.Windows.Forms.TextBox();
            this.lbl_verify_man_name = new System.Windows.Forms.Label();
            this.btn_verify_cancel = new System.Windows.Forms.Button();
            this.btn_verify_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_verify_man_notification
            // 
            this.lbx_verify_man_notification.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_verify_man_notification.FormattingEnabled = true;
            this.lbx_verify_man_notification.ItemHeight = 17;
            this.lbx_verify_man_notification.Items.AddRange(new object[] {
            "無未審核之申請",
            "有未審核之申請:1筆"});
            this.lbx_verify_man_notification.Location = new System.Drawing.Point(41, 72);
            this.lbx_verify_man_notification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_verify_man_notification.Name = "lbx_verify_man_notification";
            this.lbx_verify_man_notification.Size = new System.Drawing.Size(299, 140);
            this.lbx_verify_man_notification.TabIndex = 15;
            // 
            // lbl_verify_man_title
            // 
            this.lbl_verify_man_title.AutoSize = true;
            this.lbl_verify_man_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_man_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_verify_man_title.Location = new System.Drawing.Point(37, 30);
            this.lbl_verify_man_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_man_title.Name = "lbl_verify_man_title";
            this.lbl_verify_man_title.Size = new System.Drawing.Size(124, 24);
            this.lbl_verify_man_title.TabIndex = 16;
            this.lbl_verify_man_title.Text = "打卡功能審核";
            // 
            // lbx_verify_man_location
            // 
            this.lbx_verify_man_location.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_verify_man_location.FormattingEnabled = true;
            this.lbx_verify_man_location.ItemHeight = 17;
            this.lbx_verify_man_location.Items.AddRange(new object[] {
            "公司",
            "資策會",
            "台大",
            "政大",
            "交大",
            "清大",
            "中央",
            "成大"});
            this.lbx_verify_man_location.Location = new System.Drawing.Point(229, 389);
            this.lbx_verify_man_location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_verify_man_location.Name = "lbx_verify_man_location";
            this.lbx_verify_man_location.Size = new System.Drawing.Size(178, 140);
            this.lbx_verify_man_location.TabIndex = 24;
            // 
            // lbl_verify_man_location
            // 
            this.lbl_verify_man_location.AutoSize = true;
            this.lbl_verify_man_location.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_man_location.ForeColor = System.Drawing.Color.Black;
            this.lbl_verify_man_location.Location = new System.Drawing.Point(117, 389);
            this.lbl_verify_man_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_man_location.Name = "lbl_verify_man_location";
            this.lbl_verify_man_location.Size = new System.Drawing.Size(86, 17);
            this.lbl_verify_man_location.TabIndex = 23;
            this.lbl_verify_man_location.Text = "申請打卡地點";
            // 
            // dom_verify_man_applyreason
            // 
            this.dom_verify_man_applyreason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dom_verify_man_applyreason.Items.Add("新進員工");
            this.dom_verify_man_applyreason.Items.Add("主管");
            this.dom_verify_man_applyreason.Items.Add("老闆");
            this.dom_verify_man_applyreason.Location = new System.Drawing.Point(227, 339);
            this.dom_verify_man_applyreason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dom_verify_man_applyreason.Name = "dom_verify_man_applyreason";
            this.dom_verify_man_applyreason.Size = new System.Drawing.Size(180, 25);
            this.dom_verify_man_applyreason.TabIndex = 22;
            this.dom_verify_man_applyreason.Text = "新進員工";
            // 
            // ibl_verify_man_applyreason
            // 
            this.ibl_verify_man_applyreason.AutoSize = true;
            this.ibl_verify_man_applyreason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ibl_verify_man_applyreason.ForeColor = System.Drawing.Color.Black;
            this.ibl_verify_man_applyreason.Location = new System.Drawing.Point(117, 339);
            this.ibl_verify_man_applyreason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ibl_verify_man_applyreason.Name = "ibl_verify_man_applyreason";
            this.ibl_verify_man_applyreason.Size = new System.Drawing.Size(60, 17);
            this.ibl_verify_man_applyreason.TabIndex = 21;
            this.ibl_verify_man_applyreason.Text = "申請原因";
            // 
            // dtp_verify_man_apply
            // 
            this.dtp_verify_man_apply.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_verify_man_apply.Location = new System.Drawing.Point(227, 286);
            this.dtp_verify_man_apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_verify_man_apply.Name = "dtp_verify_man_apply";
            this.dtp_verify_man_apply.Size = new System.Drawing.Size(298, 25);
            this.dtp_verify_man_apply.TabIndex = 20;
            // 
            // lbl_verify_man_applytime
            // 
            this.lbl_verify_man_applytime.AutoSize = true;
            this.lbl_verify_man_applytime.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_man_applytime.ForeColor = System.Drawing.Color.Black;
            this.lbl_verify_man_applytime.Location = new System.Drawing.Point(117, 286);
            this.lbl_verify_man_applytime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_man_applytime.Name = "lbl_verify_man_applytime";
            this.lbl_verify_man_applytime.Size = new System.Drawing.Size(60, 17);
            this.lbl_verify_man_applytime.TabIndex = 19;
            this.lbl_verify_man_applytime.Text = "申請時間";
            // 
            // txt_verify_man_name
            // 
            this.txt_verify_man_name.Location = new System.Drawing.Point(227, 235);
            this.txt_verify_man_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_verify_man_name.Name = "txt_verify_man_name";
            this.txt_verify_man_name.Size = new System.Drawing.Size(148, 22);
            this.txt_verify_man_name.TabIndex = 18;
            // 
            // lbl_verify_man_name
            // 
            this.lbl_verify_man_name.AutoSize = true;
            this.lbl_verify_man_name.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_man_name.ForeColor = System.Drawing.Color.Black;
            this.lbl_verify_man_name.Location = new System.Drawing.Point(117, 235);
            this.lbl_verify_man_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_man_name.Name = "lbl_verify_man_name";
            this.lbl_verify_man_name.Size = new System.Drawing.Size(34, 17);
            this.lbl_verify_man_name.TabIndex = 17;
            this.lbl_verify_man_name.Text = "姓名";
            // 
            // btn_verify_cancel
            // 
            this.btn_verify_cancel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_verify_cancel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_verify_cancel.ForeColor = System.Drawing.Color.Transparent;
            this.btn_verify_cancel.Location = new System.Drawing.Point(357, 558);
            this.btn_verify_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verify_cancel.Name = "btn_verify_cancel";
            this.btn_verify_cancel.Size = new System.Drawing.Size(109, 31);
            this.btn_verify_cancel.TabIndex = 26;
            this.btn_verify_cancel.Text = "退件";
            this.btn_verify_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_verify_ok
            // 
            this.btn_verify_ok.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_verify_ok.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_verify_ok.ForeColor = System.Drawing.Color.Transparent;
            this.btn_verify_ok.Location = new System.Drawing.Point(227, 558);
            this.btn_verify_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verify_ok.Name = "btn_verify_ok";
            this.btn_verify_ok.Size = new System.Drawing.Size(109, 31);
            this.btn_verify_ok.TabIndex = 25;
            this.btn_verify_ok.Text = "通過";
            this.btn_verify_ok.UseVisualStyleBackColor = false;
            // 
            // Frm_Verify_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 765);
            this.Controls.Add(this.btn_verify_cancel);
            this.Controls.Add(this.btn_verify_ok);
            this.Controls.Add(this.lbx_verify_man_location);
            this.Controls.Add(this.lbl_verify_man_location);
            this.Controls.Add(this.dom_verify_man_applyreason);
            this.Controls.Add(this.ibl_verify_man_applyreason);
            this.Controls.Add(this.dtp_verify_man_apply);
            this.Controls.Add(this.lbl_verify_man_applytime);
            this.Controls.Add(this.txt_verify_man_name);
            this.Controls.Add(this.lbl_verify_man_name);
            this.Controls.Add(this.lbl_verify_man_title);
            this.Controls.Add(this.lbx_verify_man_notification);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Frm_Verify_Manager";
            this.Text = "Frm_Verify_Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_verify_man_notification;
        private System.Windows.Forms.Label lbl_verify_man_title;
        private System.Windows.Forms.ListBox lbx_verify_man_location;
        private System.Windows.Forms.Label lbl_verify_man_location;
        private System.Windows.Forms.DomainUpDown dom_verify_man_applyreason;
        private System.Windows.Forms.Label ibl_verify_man_applyreason;
        private System.Windows.Forms.DateTimePicker dtp_verify_man_apply;
        private System.Windows.Forms.Label lbl_verify_man_applytime;
        private System.Windows.Forms.TextBox txt_verify_man_name;
        private System.Windows.Forms.Label lbl_verify_man_name;
        private System.Windows.Forms.Button btn_verify_cancel;
        private System.Windows.Forms.Button btn_verify_ok;
    }
}