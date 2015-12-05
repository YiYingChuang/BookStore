namespace Form_Verify
{
    partial class Frm_Verify_Process_Annabel
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
            this.lbl_verify_process = new System.Windows.Forms.Label();
            this.lbl_verify_pro = new System.Windows.Forms.Label();
            this.lbx_verify_pro_location = new System.Windows.Forms.ListBox();
            this.lbl_verify_pro_location = new System.Windows.Forms.Label();
            this.dom_verify_pro_reason = new System.Windows.Forms.DomainUpDown();
            this.ibl_verify_pro_applyreason = new System.Windows.Forms.Label();
            this.dtp_verify_pro_apply = new System.Windows.Forms.DateTimePicker();
            this.lbl_verify_pro_apply = new System.Windows.Forms.Label();
            this.lbl_verify_manager1 = new System.Windows.Forms.Label();
            this.lbl_verify_manager2 = new System.Windows.Forms.Label();
            this.lbl_verify_pro_data = new System.Windows.Forms.Label();
            this.dgv_verify_pro_data = new System.Windows.Forms.DataGridView();
            this.lbl_verify_pro_YesNo = new System.Windows.Forms.Label();
            this.btn_verify_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verify_pro_data)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_verify_process
            // 
            this.lbl_verify_process.AutoSize = true;
            this.lbl_verify_process.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_process.Location = new System.Drawing.Point(39, 33);
            this.lbl_verify_process.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_process.Name = "lbl_verify_process";
            this.lbl_verify_process.Size = new System.Drawing.Size(124, 24);
            this.lbl_verify_process.TabIndex = 1;
            this.lbl_verify_process.Text = "申請進度查詢";
            // 
            // lbl_verify_pro
            // 
            this.lbl_verify_pro.AutoSize = true;
            this.lbl_verify_pro.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_pro.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_verify_pro.Location = new System.Drawing.Point(88, 86);
            this.lbl_verify_pro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_pro.Name = "lbl_verify_pro";
            this.lbl_verify_pro.Size = new System.Drawing.Size(99, 19);
            this.lbl_verify_pro.TabIndex = 3;
            this.lbl_verify_pro.Text = "個人審核進度";
            // 
            // lbx_verify_pro_location
            // 
            this.lbx_verify_pro_location.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_verify_pro_location.FormattingEnabled = true;
            this.lbx_verify_pro_location.ItemHeight = 17;
            this.lbx_verify_pro_location.Items.AddRange(new object[] {
            "公司",
            "資策會",
            "台大",
            "政大",
            "交大",
            "清大",
            "中央",
            "成大"});
            this.lbx_verify_pro_location.Location = new System.Drawing.Point(231, 223);
            this.lbx_verify_pro_location.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_verify_pro_location.Name = "lbx_verify_pro_location";
            this.lbx_verify_pro_location.Size = new System.Drawing.Size(178, 140);
            this.lbx_verify_pro_location.TabIndex = 19;
            // 
            // lbl_verify_pro_location
            // 
            this.lbl_verify_pro_location.AutoSize = true;
            this.lbl_verify_pro_location.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_pro_location.Location = new System.Drawing.Point(121, 223);
            this.lbl_verify_pro_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_pro_location.Name = "lbl_verify_pro_location";
            this.lbl_verify_pro_location.Size = new System.Drawing.Size(86, 17);
            this.lbl_verify_pro_location.TabIndex = 18;
            this.lbl_verify_pro_location.Text = "申請打卡地點";
            // 
            // dom_verify_pro_reason
            // 
            this.dom_verify_pro_reason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dom_verify_pro_reason.Items.Add("新進員工");
            this.dom_verify_pro_reason.Items.Add("主管");
            this.dom_verify_pro_reason.Items.Add("老闆");
            this.dom_verify_pro_reason.Location = new System.Drawing.Point(231, 177);
            this.dom_verify_pro_reason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dom_verify_pro_reason.Name = "dom_verify_pro_reason";
            this.dom_verify_pro_reason.Size = new System.Drawing.Size(180, 25);
            this.dom_verify_pro_reason.TabIndex = 17;
            this.dom_verify_pro_reason.Text = "新進員工";
            // 
            // ibl_verify_pro_applyreason
            // 
            this.ibl_verify_pro_applyreason.AutoSize = true;
            this.ibl_verify_pro_applyreason.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ibl_verify_pro_applyreason.Location = new System.Drawing.Point(121, 177);
            this.ibl_verify_pro_applyreason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ibl_verify_pro_applyreason.Name = "ibl_verify_pro_applyreason";
            this.ibl_verify_pro_applyreason.Size = new System.Drawing.Size(60, 17);
            this.ibl_verify_pro_applyreason.TabIndex = 16;
            this.ibl_verify_pro_applyreason.Text = "申請原因";
            // 
            // dtp_verify_pro_apply
            // 
            this.dtp_verify_pro_apply.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_verify_pro_apply.Location = new System.Drawing.Point(231, 131);
            this.dtp_verify_pro_apply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_verify_pro_apply.Name = "dtp_verify_pro_apply";
            this.dtp_verify_pro_apply.Size = new System.Drawing.Size(298, 25);
            this.dtp_verify_pro_apply.TabIndex = 15;
            // 
            // lbl_verify_pro_apply
            // 
            this.lbl_verify_pro_apply.AutoSize = true;
            this.lbl_verify_pro_apply.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_pro_apply.Location = new System.Drawing.Point(121, 131);
            this.lbl_verify_pro_apply.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_pro_apply.Name = "lbl_verify_pro_apply";
            this.lbl_verify_pro_apply.Size = new System.Drawing.Size(60, 17);
            this.lbl_verify_pro_apply.TabIndex = 14;
            this.lbl_verify_pro_apply.Text = "申請時間";
            // 
            // lbl_verify_manager1
            // 
            this.lbl_verify_manager1.AutoSize = true;
            this.lbl_verify_manager1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_manager1.Location = new System.Drawing.Point(613, 136);
            this.lbl_verify_manager1.Name = "lbl_verify_manager1";
            this.lbl_verify_manager1.Size = new System.Drawing.Size(41, 19);
            this.lbl_verify_manager1.TabIndex = 20;
            this.lbl_verify_manager1.Text = "Amy";
            // 
            // lbl_verify_manager2
            // 
            this.lbl_verify_manager2.AutoSize = true;
            this.lbl_verify_manager2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_manager2.Location = new System.Drawing.Point(615, 223);
            this.lbl_verify_manager2.Name = "lbl_verify_manager2";
            this.lbl_verify_manager2.Size = new System.Drawing.Size(40, 19);
            this.lbl_verify_manager2.TabIndex = 21;
            this.lbl_verify_manager2.Text = "Tom";
            // 
            // lbl_verify_pro_data
            // 
            this.lbl_verify_pro_data.AutoSize = true;
            this.lbl_verify_pro_data.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_pro_data.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_verify_pro_data.Location = new System.Drawing.Point(88, 384);
            this.lbl_verify_pro_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_pro_data.Name = "lbl_verify_pro_data";
            this.lbl_verify_pro_data.Size = new System.Drawing.Size(99, 19);
            this.lbl_verify_pro_data.TabIndex = 22;
            this.lbl_verify_pro_data.Text = "審核進度資料";
            // 
            // dgv_verify_pro_data
            // 
            this.dgv_verify_pro_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_verify_pro_data.Location = new System.Drawing.Point(231, 384);
            this.dgv_verify_pro_data.Name = "dgv_verify_pro_data";
            this.dgv_verify_pro_data.RowTemplate.Height = 24;
            this.dgv_verify_pro_data.Size = new System.Drawing.Size(298, 196);
            this.dgv_verify_pro_data.TabIndex = 23;
            // 
            // lbl_verify_pro_YesNo
            // 
            this.lbl_verify_pro_YesNo.AutoSize = true;
            this.lbl_verify_pro_YesNo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_pro_YesNo.ForeColor = System.Drawing.Color.Red;
            this.lbl_verify_pro_YesNo.Location = new System.Drawing.Point(358, 600);
            this.lbl_verify_pro_YesNo.Name = "lbl_verify_pro_YesNo";
            this.lbl_verify_pro_YesNo.Size = new System.Drawing.Size(60, 17);
            this.lbl_verify_pro_YesNo.TabIndex = 24;
            this.lbl_verify_pro_YesNo.Text = "申請駁回";
            // 
            // btn_verify_ok
            // 
            this.btn_verify_ok.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_verify_ok.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_verify_ok.ForeColor = System.Drawing.Color.Transparent;
            this.btn_verify_ok.Location = new System.Drawing.Point(334, 640);
            this.btn_verify_ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_verify_ok.Name = "btn_verify_ok";
            this.btn_verify_ok.Size = new System.Drawing.Size(109, 31);
            this.btn_verify_ok.TabIndex = 25;
            this.btn_verify_ok.Text = "重新送出";
            this.btn_verify_ok.UseVisualStyleBackColor = false;
            // 
            // Frm_Verify_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 765);
            this.Controls.Add(this.btn_verify_ok);
            this.Controls.Add(this.lbl_verify_pro_YesNo);
            this.Controls.Add(this.dgv_verify_pro_data);
            this.Controls.Add(this.lbl_verify_pro_data);
            this.Controls.Add(this.lbl_verify_manager2);
            this.Controls.Add(this.lbl_verify_manager1);
            this.Controls.Add(this.lbx_verify_pro_location);
            this.Controls.Add(this.lbl_verify_pro_location);
            this.Controls.Add(this.dom_verify_pro_reason);
            this.Controls.Add(this.ibl_verify_pro_applyreason);
            this.Controls.Add(this.dtp_verify_pro_apply);
            this.Controls.Add(this.lbl_verify_pro_apply);
            this.Controls.Add(this.lbl_verify_pro);
            this.Controls.Add(this.lbl_verify_process);
            this.Name = "Frm_Verify_Process";
            this.Text = "Frm_Verify_Process";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verify_pro_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_verify_process;
        private System.Windows.Forms.Label lbl_verify_pro;
        private System.Windows.Forms.ListBox lbx_verify_pro_location;
        private System.Windows.Forms.Label lbl_verify_pro_location;
        private System.Windows.Forms.DomainUpDown dom_verify_pro_reason;
        private System.Windows.Forms.Label ibl_verify_pro_applyreason;
        private System.Windows.Forms.DateTimePicker dtp_verify_pro_apply;
        private System.Windows.Forms.Label lbl_verify_pro_apply;
        private System.Windows.Forms.Label lbl_verify_manager1;
        private System.Windows.Forms.Label lbl_verify_manager2;
        private System.Windows.Forms.Label lbl_verify_pro_data;
        private System.Windows.Forms.DataGridView dgv_verify_pro_data;
        private System.Windows.Forms.Label lbl_verify_pro_YesNo;
        private System.Windows.Forms.Button btn_verify_ok;
    }
}