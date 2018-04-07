namespace BitmapLSB
{
    partial class FormApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAfter = new System.Windows.Forms.GroupBox();
            this.pictureAfter = new System.Windows.Forms.PictureBox();
            this.groupBoxBefore = new System.Windows.Forms.GroupBox();
            this.pictureBefore = new System.Windows.Forms.PictureBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtStPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnChooseDec = new System.Windows.Forms.Button();
            this.groupBoxDecode = new System.Windows.Forms.GroupBox();
            this.pictureBoxDec = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAfter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfter)).BeginInit();
            this.groupBoxBefore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBefore)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 638);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Red;
            this.tabPage1.Controls.Add(this.groupBoxAfter);
            this.tabPage1.Controls.Add(this.groupBoxBefore);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.txtStPath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnChoose);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mã hóa";
            // 
            // groupBoxAfter
            // 
            this.groupBoxAfter.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxAfter.Controls.Add(this.pictureAfter);
            this.groupBoxAfter.ForeColor = System.Drawing.Color.SlateBlue;
            this.groupBoxAfter.Location = new System.Drawing.Point(583, 112);
            this.groupBoxAfter.Name = "groupBoxAfter";
            this.groupBoxAfter.Size = new System.Drawing.Size(512, 487);
            this.groupBoxAfter.TabIndex = 11;
            this.groupBoxAfter.TabStop = false;
            this.groupBoxAfter.Text = "Sau sau khi giấu";
            this.groupBoxAfter.Enter += new System.EventHandler(this.groupBoxAfter_Enter);
            // 
            // pictureAfter
            // 
            this.pictureAfter.BackColor = System.Drawing.Color.White;
            this.pictureAfter.Location = new System.Drawing.Point(0, 25);
            this.pictureAfter.Name = "pictureAfter";
            this.pictureAfter.Size = new System.Drawing.Size(512, 489);
            this.pictureAfter.TabIndex = 1;
            this.pictureAfter.TabStop = false;
            // 
            // groupBoxBefore
            // 
            this.groupBoxBefore.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxBefore.Controls.Add(this.pictureBefore);
            this.groupBoxBefore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBefore.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBoxBefore.Location = new System.Drawing.Point(19, 112);
            this.groupBoxBefore.Name = "groupBoxBefore";
            this.groupBoxBefore.Size = new System.Drawing.Size(512, 477);
            this.groupBoxBefore.TabIndex = 10;
            this.groupBoxBefore.TabStop = false;
            this.groupBoxBefore.Text = "Ảnh ";
            this.groupBoxBefore.Enter += new System.EventHandler(this.groupBoxBefore_Enter);
            // 
            // pictureBefore
            // 
            this.pictureBefore.BackColor = System.Drawing.Color.White;
            this.pictureBefore.Location = new System.Drawing.Point(0, 25);
            this.pictureBefore.Name = "pictureBefore";
            this.pictureBefore.Size = new System.Drawing.Size(512, 489);
            this.pictureBefore.TabIndex = 0;
            this.pictureBefore.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(570, 15);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(383, 26);
            this.txtMessage.TabIndex = 9;
            // 
            // txtStPath
            // 
            this.txtStPath.Location = new System.Drawing.Point(19, 15);
            this.txtStPath.Name = "txtStPath";
            this.txtStPath.ReadOnly = true;
            this.txtStPath.Size = new System.Drawing.Size(365, 26);
            this.txtStPath.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(959, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập nội dung";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Indigo;
            this.btnSave.Location = new System.Drawing.Point(511, 52);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Bắt đầu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.Indigo;
            this.btnChoose.Location = new System.Drawing.Point(432, 15);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(99, 31);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Chọn ảnh";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Red;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtResult);
            this.tabPage2.Controls.Add(this.txtPath);
            this.tabPage2.Controls.Add(this.btnDecode);
            this.tabPage2.Controls.Add(this.btnChooseDec);
            this.tabPage2.Controls.Add(this.groupBoxDecode);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Giải mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(657, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nội dung  cất giấu";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(657, 127);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(425, 484);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(197, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(719, 26);
            this.txtPath.TabIndex = 3;
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDecode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.ForeColor = System.Drawing.Color.Indigo;
            this.btnDecode.Location = new System.Drawing.Point(548, 53);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(112, 37);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "Bắt đầu giải mã";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnChooseDec
            // 
            this.btnChooseDec.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseDec.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseDec.ForeColor = System.Drawing.Color.Indigo;
            this.btnChooseDec.Location = new System.Drawing.Point(922, 15);
            this.btnChooseDec.Name = "btnChooseDec";
            this.btnChooseDec.Size = new System.Drawing.Size(106, 38);
            this.btnChooseDec.TabIndex = 1;
            this.btnChooseDec.Text = "Chọn ảnh";
            this.btnChooseDec.UseVisualStyleBackColor = false;
            this.btnChooseDec.Click += new System.EventHandler(this.btnChooseDec_Click);
            // 
            // groupBoxDecode
            // 
            this.groupBoxDecode.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxDecode.Controls.Add(this.pictureBoxDec);
            this.groupBoxDecode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDecode.Location = new System.Drawing.Point(38, 99);
            this.groupBoxDecode.Name = "groupBoxDecode";
            this.groupBoxDecode.Size = new System.Drawing.Size(512, 512);
            this.groupBoxDecode.TabIndex = 0;
            this.groupBoxDecode.TabStop = false;
            this.groupBoxDecode.Text = "Ảnh đã chọn";
            this.groupBoxDecode.Enter += new System.EventHandler(this.groupBoxDecode_Enter);
            // 
            // pictureBoxDec
            // 
            this.pictureBoxDec.BackColor = System.Drawing.Color.White;
            this.pictureBoxDec.Location = new System.Drawing.Point(6, 25);
            this.pictureBoxDec.Name = "pictureBoxDec";
            this.pictureBoxDec.Size = new System.Drawing.Size(500, 481);
            this.pictureBoxDec.TabIndex = 0;
            this.pictureBoxDec.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(999, 649);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1149, 684);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormApp";
            this.Text = "Bitmap - LSB ";
            this.Load += new System.EventHandler(this.FormApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxAfter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAfter)).EndInit();
            this.groupBoxBefore.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBefore)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBoxDecode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtStPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxBefore;
        private System.Windows.Forms.PictureBox pictureBefore;
        private System.Windows.Forms.GroupBox groupBoxAfter;
        private System.Windows.Forms.PictureBox pictureAfter;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnChooseDec;
        private System.Windows.Forms.GroupBox groupBoxDecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxDec;
        private System.Windows.Forms.Button btnExit;
    }
}

