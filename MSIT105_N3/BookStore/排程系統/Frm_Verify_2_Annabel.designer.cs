namespace Form_Verify
{
    partial class Frm_Verify_2_Annabel
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
            this.lbl_verify_title2 = new System.Windows.Forms.Label();
            this.lbl_verify_list2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_verify_notification = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_verify_title2
            // 
            this.lbl_verify_title2.AutoSize = true;
            this.lbl_verify_title2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_title2.Location = new System.Drawing.Point(39, 33);
            this.lbl_verify_title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_title2.Name = "lbl_verify_title2";
            this.lbl_verify_title2.Size = new System.Drawing.Size(124, 24);
            this.lbl_verify_title2.TabIndex = 1;
            this.lbl_verify_title2.Text = "打卡申請審核";
            // 
            // lbl_verify_list2
            // 
            this.lbl_verify_list2.AutoSize = true;
            this.lbl_verify_list2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_verify_list2.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_verify_list2.Location = new System.Drawing.Point(88, 86);
            this.lbl_verify_list2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_verify_list2.Name = "lbl_verify_list2";
            this.lbl_verify_list2.Size = new System.Drawing.Size(69, 19);
            this.lbl_verify_list2.TabIndex = 3;
            this.lbl_verify_list2.Text = "審核清單";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // lbx_verify_notification
            // 
            this.lbx_verify_notification.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbx_verify_notification.FormattingEnabled = true;
            this.lbx_verify_notification.ItemHeight = 17;
            this.lbx_verify_notification.Items.AddRange(new object[] {
            "無未審核之申請",
            "有未審核之申請:1筆"});
            this.lbx_verify_notification.Location = new System.Drawing.Point(197, 86);
            this.lbx_verify_notification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbx_verify_notification.Name = "lbx_verify_notification";
            this.lbx_verify_notification.Size = new System.Drawing.Size(299, 140);
            this.lbx_verify_notification.TabIndex = 14;
            // 
            // Frm_Verify_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 765);
            this.Controls.Add(this.lbx_verify_notification);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_verify_list2);
            this.Controls.Add(this.lbl_verify_title2);
            this.Name = "Frm_Verify_2";
            this.Text = "Frm_Verify_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_verify_title2;
        private System.Windows.Forms.Label lbl_verify_list2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_verify_notification;
    }
}