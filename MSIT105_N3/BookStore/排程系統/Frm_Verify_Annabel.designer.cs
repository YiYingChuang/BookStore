namespace Form_Verify
{
    partial class Frm_Verify_Annabel
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.lbl_verify_title = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbl_verify_list = new System.Windows.Forms.Label();
            this.lbl_verify_id = new System.Windows.Forms.Label();
            this.lbl_verify_groupdata = new System.Windows.Forms.Label();
            this.lbl_verify_name = new System.Windows.Forms.Label();
            this.txt_verify_name = new System.Windows.Forms.TextBox();
            this.lbl_verify_applytime = new System.Windows.Forms.Label();
            this.dtp_verify_apply = new System.Windows.Forms.DateTimePicker();
            this.ibl_verify_applyreason = new System.Windows.Forms.Label();
            this.dom_verify_applyreason = new System.Windows.Forms.DomainUpDown();
            this.lbl_verify_location = new System.Windows.Forms.Label();
            this.lbx_verify_location = new System.Windows.Forms.ListBox();
            this.btn_verify_ok = new System.Windows.Forms.Button();
            this.btn_verify_cancel = new System.Windows.Forms.Button();
            this.txt_verify_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_verify_title
            // 
            this.lbl_verify_title.AutoSize = true;
            this.lbl_verify_title.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_title.Location = new System.Drawing.Point(39, 33);
            this.lbl_verify_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_title.Name = "lbl_verify_title";
            this.lbl_verify_title.Size = new System.Drawing.Size(124, 24);
            this.lbl_verify_title.TabIndex = 0;
            this.lbl_verify_title.Text = "打卡申請審核";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 765);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lbl_verify_list
            // 
            this.lbl_verify_list.AutoSize = true;
            this.lbl_verify_list.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_list.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_verify_list.Location = new System.Drawing.Point(88, 86);
            this.lbl_verify_list.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_list.Name = "lbl_verify_list";
            this.lbl_verify_list.Size = new System.Drawing.Size(69, 19);
            this.lbl_verify_list.TabIndex = 2;
            this.lbl_verify_list.Text = "審核清單";
            // 
            // lbl_verify_id
            // 
            this.lbl_verify_id.AutoSize = true;
            this.lbl_verify_id.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_id.Location = new System.Drawing.Point(130, 135);
            this.lbl_verify_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_id.Name = "lbl_verify_id";
            this.lbl_verify_id.Size = new System.Drawing.Size(60, 17);
            this.lbl_verify_id.TabIndex = 3;
            this.lbl_verify_id.Text = "審核編號";
            // 
            // lbl_verify_groupdata
            // 
            this.lbl_verify_groupdata.AutoSize = true;
            this.lbl_verify_groupdata.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_groupdata.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_verify_groupdata.Location = new System.Drawing.Point(88, 179);
            this.lbl_verify_groupdata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_groupdata.Name = "lbl_verify_groupdata";
            this.lbl_verify_groupdata.Size = new System.Drawing.Size(99, 19);
            this.lbl_verify_groupdata.TabIndex = 4;
            this.lbl_verify_groupdata.Text = "申請群組資料";
            // 
            // lbl_verify_name
            // 
            this.lbl_verify_name.AutoSize = true;
            this.lbl_verify_name.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_name.Location = new System.Drawing.Point(136, 224);
            this.lbl_verify_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_name.Name = "lbl_verify_name";
            this.lbl_verify_name.Size = new System.Drawing.Size(34, 17);
            this.lbl_verify_name.TabIndex = 5;
            this.lbl_verify_name.Text = "姓名";
            // 
            // txt_verify_name
            // 
            this.txt_verify_name.Location = new System.Drawing.Point(246, 224);
            this.txt_verify_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_verify_name.Name = "txt_verify_name";
            this.txt_verify_name.Size = new System.Drawing.Size(148, 27);
            this.txt_verify_name.TabIndex = 6;
            // 
            // lbl_verify_applytime
            // 
            this.lbl_verify_applytime.AutoSize = true;
            this.lbl_verify_applytime.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_applytime.Location = new System.Drawing.Point(136, 275);
            this.lbl_verify_applytime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_applytime.Name = "lbl_verify_applytime";
            this.lbl_verify_applytime.Size = new System.Drawing.Size(60, 17);
            this.lbl_verify_applytime.TabIndex = 7;
            this.lbl_verify_applytime.Text = "申請時間";
            this.lbl_verify_applytime.Click += new System.EventHandler(this.lbl_verify_applytime_Click);
            // 
            // dtp_verify_apply
            // 
            this.dtp_verify_apply.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_verify_apply.Location = new System.Drawing.Point(246, 275);
            this.dtp_verify_apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_verify_apply.Name = "dtp_verify_apply";
            this.dtp_verify_apply.Size = new System.Drawing.Size(298, 25);
            this.dtp_verify_apply.TabIndex = 8;
            this.dtp_verify_apply.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ibl_verify_applyreason
            // 
            this.ibl_verify_applyreason.AutoSize = true;
            this.ibl_verify_applyreason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ibl_verify_applyreason.Location = new System.Drawing.Point(136, 328);
            this.ibl_verify_applyreason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ibl_verify_applyreason.Name = "ibl_verify_applyreason";
            this.ibl_verify_applyreason.Size = new System.Drawing.Size(60, 17);
            this.ibl_verify_applyreason.TabIndex = 9;
            this.ibl_verify_applyreason.Text = "申請原因";
            this.ibl_verify_applyreason.Click += new System.EventHandler(this.ibl_verify_applyreason_Click);
            // 
            // dom_verify_applyreason
            // 
            this.dom_verify_applyreason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dom_verify_applyreason.Items.Add("新進員工");
            this.dom_verify_applyreason.Items.Add("主管");
            this.dom_verify_applyreason.Items.Add("老闆");
            this.dom_verify_applyreason.Location = new System.Drawing.Point(246, 328);
            this.dom_verify_applyreason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dom_verify_applyreason.Name = "dom_verify_applyreason";
            this.dom_verify_applyreason.Size = new System.Drawing.Size(180, 25);
            this.dom_verify_applyreason.TabIndex = 11;
            this.dom_verify_applyreason.Text = "新進員工";
            this.dom_verify_applyreason.SelectedItemChanged += new System.EventHandler(this.dom_verify_applyreason_SelectedItemChanged);
            // 
            // lbl_verify_location
            // 
            this.lbl_verify_location.AutoSize = true;
            this.lbl_verify_location.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_location.Location = new System.Drawing.Point(136, 378);
            this.lbl_verify_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_location.Name = "lbl_verify_location";
            this.lbl_verify_location.Size = new System.Drawing.Size(86, 17);
            this.lbl_verify_location.TabIndex = 12;
            this.lbl_verify_location.Text = "申請打卡地點";
            this.lbl_verify_location.Click += new System.EventHandler(this.lbl_verify_location_Click);
            // 
            // lbx_verify_location
            // 
            this.lbx_verify_location.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_verify_location.FormattingEnabled = true;
            this.lbx_verify_location.ItemHeight = 17;
            this.lbx_verify_location.Items.AddRange(new object[] {
            "公司",
            "資策會",
            "台大",
            "政大",
            "交大",
            "清大",
            "中央",
            "成大"});
            this.lbx_verify_location.Location = new System.Drawing.Point(248, 378);
            this.lbx_verify_location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_verify_location.Name = "lbx_verify_location";
            this.lbx_verify_location.Size = new System.Drawing.Size(178, 140);
            this.lbx_verify_location.TabIndex = 13;
            this.lbx_verify_location.SelectedIndexChanged += new System.EventHandler(this.lbx_verify_location_SelectedIndexChanged);
            // 
            // btn_verify_ok
            // 
            this.btn_verify_ok.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_verify_ok.ForeColor = System.Drawing.Color.Transparent;
            this.btn_verify_ok.Location = new System.Drawing.Point(248, 560);
            this.btn_verify_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verify_ok.Name = "btn_verify_ok";
            this.btn_verify_ok.Size = new System.Drawing.Size(109, 31);
            this.btn_verify_ok.TabIndex = 14;
            this.btn_verify_ok.Text = "OK";
            this.btn_verify_ok.UseVisualStyleBackColor = false;
            // 
            // btn_verify_cancel
            // 
            this.btn_verify_cancel.BackColor = System.Drawing.Color.Firebrick;
            this.btn_verify_cancel.ForeColor = System.Drawing.Color.Transparent;
            this.btn_verify_cancel.Location = new System.Drawing.Point(368, 560);
            this.btn_verify_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verify_cancel.Name = "btn_verify_cancel";
            this.btn_verify_cancel.Size = new System.Drawing.Size(109, 31);
            this.btn_verify_cancel.TabIndex = 15;
            this.btn_verify_cancel.Text = "Cancel";
            this.btn_verify_cancel.UseVisualStyleBackColor = false;
            // 
            // txt_verify_id
            // 
            this.txt_verify_id.Location = new System.Drawing.Point(240, 135);
            this.txt_verify_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_verify_id.Name = "txt_verify_id";
            this.txt_verify_id.Size = new System.Drawing.Size(148, 27);
            this.txt_verify_id.TabIndex = 16;
            // 
            // Frm_Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 765);
            this.Controls.Add(this.txt_verify_id);
            this.Controls.Add(this.btn_verify_cancel);
            this.Controls.Add(this.btn_verify_ok);
            this.Controls.Add(this.lbx_verify_location);
            this.Controls.Add(this.lbl_verify_location);
            this.Controls.Add(this.dom_verify_applyreason);
            this.Controls.Add(this.ibl_verify_applyreason);
            this.Controls.Add(this.dtp_verify_apply);
            this.Controls.Add(this.lbl_verify_applytime);
            this.Controls.Add(this.txt_verify_name);
            this.Controls.Add(this.lbl_verify_name);
            this.Controls.Add(this.lbl_verify_groupdata);
            this.Controls.Add(this.lbl_verify_id);
            this.Controls.Add(this.lbl_verify_list);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lbl_verify_title);
            this.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Verify";
            this.Text = "Frm_Verify";
            this.Load += new System.EventHandler(this.Frm_Verify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_verify_title;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbl_verify_list;
        private System.Windows.Forms.Label lbl_verify_id;
        private System.Windows.Forms.Label lbl_verify_groupdata;
        private System.Windows.Forms.Label lbl_verify_name;
        private System.Windows.Forms.TextBox txt_verify_name;
        private System.Windows.Forms.Label lbl_verify_applytime;
        private System.Windows.Forms.DateTimePicker dtp_verify_apply;
        private System.Windows.Forms.Label ibl_verify_applyreason;
        private System.Windows.Forms.DomainUpDown dom_verify_applyreason;
        private System.Windows.Forms.Label lbl_verify_location;
        private System.Windows.Forms.ListBox lbx_verify_location;
        private System.Windows.Forms.Button btn_verify_ok;
        private System.Windows.Forms.Button btn_verify_cancel;
        private System.Windows.Forms.TextBox txt_verify_id;
    }
}

