using BookStore.請假系統;
using BookStoreEntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absence
{
    public partial class Absence_Ying : Form
    {
        public Absence_Ying()
        {
            InitializeComponent();
        }
        BookStoreObject_Entities db = new BookStoreObject_Entities();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox_CheckStatus.Image = this.imageList1.Images["-"];
            this.openFileDialog1.Filter = "(*.jpg;*.jpeg;*.bmp;*.png)|*.jpg;*.jpeg;*.bmp;*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.bmp)|*.bmp|(*.png)|*.png";

            //將假別塞入====================
            //var q = from AT in db.Absence_Type
            //        select AT.Absence_Type1;

            var q1 = db.Absence_Type.Select(AT => AT.Absence_Type1);

            this.absence_Type1ComboBox.Items.Clear();
            foreach (var item in q1)
            {
                this.absence_Type1ComboBox.Items.Add(item);
                this.absence_Type1ComboBox2.Items.Add(item);
            }
            //==============================
        }

        private void btn_Browser_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox_Browser.ImageLocation = this.openFileDialog1.FileName;
                this.label_Browser.Text = this.openFileDialog1.SafeFileName;
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                int EmployeeID = 5;
                DateTime S_date = this.dateTimePicker1.Value;
                DateTime E_date = this.dateTimePicker2.Value;

                //圖片轉換===========
                byte[] bytes = null;
                MemoryStream ms = new MemoryStream();
                if (this.pictureBox_Browser.Image != null)
                {
                    pictureBox_Browser.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    bytes = ms.GetBuffer();
                }
                //==================================================


                //找出請假類別ID========
                var AbsenceID = (from AT in db.Absence_Type
                         where AT.Absence_Type1 == this.absence_Type1ComboBox.Text
                         select AT.Absence_ID).FirstOrDefault();
                //==================================================

                //新增資料============
                db.Absence_Table.Add(new Absence_Table
                {
                    EmployeeID = EmployeeID,
                    Absence_ID = AbsenceID,
                    StartDate = S_date,
                    EndDate = E_date,
                    Reason = this.textBox1.Text,
                    Certificate_Doc = bytes,
                    Check_ID = 1
                }
                    );
                if (this.textBox1.Text != "" && this.absence_Type1ComboBox.SelectedIndex != -1)
                {
                    //db.SaveChanges();
                    MessageBox.Show("申請已送出!");
                }
                MessageBox.Show("假單填寫不完整, 無法送出!");
                this.errorProvider1.SetError(this.absence_Type1ComboBox, "Wrong !");
                this.errorProvider1.SetError(this.textBox1, "Wrong");
            }
            catch 
            { }
            //==================================================
            
        }

        private void absence_Type1ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int EmployeeID=5;
            DateTime Today = DateTime.Now;

            //找出請假類別ID========
            var AbsenceID = (from AT in db.Absence_Type
                             where AT.Absence_Type1 == this.absence_Type1ComboBox2.Text
                             select AT.Absence_ID).FirstOrDefault();
            //==================================================


            //根據 請假類別 尋找 請假表===========
            var Search_Absence = (from AT in db.Absence_Table
                                  where AT.EmployeeID == EmployeeID && AT.Absence_ID == AbsenceID //&& AT.StartDate > Today
                                 select new 
                                 {
                                     請假單號 = AT.Absence_No,
                                     請假起始日 = AT.StartDate,
                                     請假結束日 = AT.EndDate,
                                     請假原因 = AT.Reason,
                                     請假證明 = AT.Certificate_Doc,
                                     審核狀態=AT.ChechStatu.Status
                                 }).ToList();

            this.dataGridView1.DataSource = Search_Absence;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //==================================================
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            //根據選的項目輸出對應資料================
            try
            {
                //清空------------------------------------------
                this.emp_NameTextBox.Text = this.absence_NoTextBox.Text = this.startDateTextBox.Text
                    = this.endDateTextBox.Text = this.reasonTextBox.Text = this.label7.Text = this.statusLabel1.Text = "";
                this.certificate_DocPictureBox.Image = null;
                //-----------------------------------------------

                //根據選的項目輸出對應資料================
                DataGridViewCellCollection d = this.dataGridView1.CurrentRow.Cells;
                this.startDateTextBox.Text = Convert.ToString(d["請假起始日"].Value);
                this.endDateTextBox.Text = Convert.ToString(d["請假結束日"].Value);
                this.reasonTextBox.Text = Convert.ToString(d["請假原因"].Value);
                this.absence_NoTextBox.Text = Convert.ToString(d["請假單號"].Value);
                //圖片輸出----------------------------------------
                if (d["請假證明"].Value != null)
                {
                    byte[] bytes = (byte[])d["請假證明"].Value;
                    MemoryStream ms = new MemoryStream(bytes);
                    this.certificate_DocPictureBox.Image = Image.FromStream(ms);
                }
                //-------------------------------------------------

                if (Convert.ToString(d["審核狀態"].Value) == "審核中")
                {
                    this.pictureBox_CheckStatus.Image = this.imageList1.Images["審核中"];
                    this.statusLabel1.Text = "審核中";
                }
                if (Convert.ToString(d["審核狀態"].Value) == "審核通過")
                {
                    this.pictureBox_CheckStatus.Image = this.imageList1.Images["審核通過"];
                    this.statusLabel1.Text = "審核通過";
                }
                if (Convert.ToString(d["審核狀態"].Value) == "審核未通過")
                {
                    this.pictureBox_CheckStatus.Image = this.imageList1.Images["審核未通過"];
                    this.statusLabel1.Text = "審核未通過";
                }
            }
            catch { }
            //==================================================
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int AbsenceNo;
                int.TryParse(this.absence_NoTextBox.Text, out AbsenceNo);

                FrmYesNo f = new FrmYesNo();
                f.ShowDialog();
                if (f.DialogResult == System.Windows.Forms.DialogResult.Yes)
                {   
                    //刪除 審核中+未通過審核 的資料=============
                    //var delete_Absence = (from AT in db.Absence_Table
                    //                      where AT.Absence_No == AbsenceNo
                    //                      select AT).FirstOrDefault();

                    var delete_Absence = db.Absence_Table.Where(AT => AT.Absence_No == AbsenceNo).FirstOrDefault();

                    if (delete_Absence == null)
                    {
                        MessageBox.Show("假單不存在!");
                        return;
                    }

                    db.Absence_Table.Remove(delete_Absence);
                    db.SaveChanges();
                }
            }
            catch { }
            //==================================================
        }

        private void btn_Alter_Click(object sender, EventArgs e)
        {
            try
            {
                int AbsenceNo;
                int.TryParse(this.absence_NoTextBox.Text, out AbsenceNo);

                FrmYesNo f = new FrmYesNo();
                f.label1.Text = "確定修改資料?";
                f.ShowDialog();
                if (f.DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    //圖片轉換===========
                    byte[] bytes = null;
                    if (this.certificate_DocPictureBox.Image != null)
                    {   
                        MemoryStream ms = new MemoryStream();
                        certificate_DocPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                        bytes = ms.GetBuffer();
                    }
                    //==================================================

                    //修改 審核中+未通過審核 的資料=============
                    //var alter_Absence = (from AT in db.Absence_Table
                    //                     where AT.Absence_No == AbsenceNo
                    //                     select AT).FirstOrDefault();

                    var alter_Absence = db.Absence_Table.Where(AT => AT.Absence_No == AbsenceNo).FirstOrDefault();

                    if (alter_Absence == null)
                    {
                        MessageBox.Show("假單不存在!");
                        return;
                    }
                    alter_Absence.Reason = reasonTextBox.Text;
                    alter_Absence.Certificate_Doc = bytes;
                    alter_Absence.ChechStatu.Check_ID = 1;

                    db.SaveChanges();   
                }
            }
            catch { }
             //==================================================  
        }

        private void absence_Type1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.absence_Type1ComboBox, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.textBox1, "");
        }
    }
}
