using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitmapLSB
{
    public partial class FormApp : Form
    {
        String stPath, ndPath, decPath;
        public FormApp()
        {
            InitializeComponent();
        }

        private void FixPicture(Image picImage, PictureBox picBox)
        {
            picBox.Image = picImage;
            if (picImage.Width < 512 && picImage.Height < 512)
            {
                picBox.Location = new Point((picBox.Parent.ClientSize.Width / 2) - (picImage.Width / 2),
                                            (picBox.Parent.ClientSize.Height / 2) - (picImage.Height / 2));
                picBox.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                picBox.Location = new Point(0, 25);
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh giấu tin";
            openFile.Filter = "Bitmap Image(*.bmp)|*.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                stPath = openFile.FileName;
                Bitmap bitmap = new Bitmap(stPath);
                FixPicture(bitmap, pictureBefore);
                pictureBefore.Image = bitmap;
                txtStPath.Text = stPath;
                txtMessage.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStPath.Text == "")
                MessageBox.Show("Vui lòng chọn ảnh để giấu tin!", "Thông báo");
            else
            {
                if (txtMessage.Text != "")
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Title = "Chọn nơi lưu ảnh";
                    saveDialog.Filter = "Bitmap (*.bmp)|*.bmp";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        ndPath = saveDialog.FileName;
                        if (ndPath == stPath)
                            MessageBox.Show("Tập tinh trung nhau!");
                        else
                        {
                            CreateFile(stPath, ndPath, txtMessage.Text);
                            Bitmap bitmap = new Bitmap(ndPath);
                            FixPicture(bitmap, pictureAfter);
                            pictureAfter.Image = bitmap;
                            saveDialog.Dispose();
                            MessageBox.Show("Đã giấu tin thành công!", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tin nhắn!", "Thông báo");
                }
            }
        }

        private byte[] AddMessage(byte[] message)
        {
            int mes = message.Length;
            byte[] byteMes = BitConverter.GetBytes(mes);
            byte[] newMes = new byte[mes + byteMes.Length];
            for (int i = 0; i < byteMes.Length; i++)
                newMes[i] = byteMes[i];
            for (int i = 0; i < mes; i++)
                newMes[i + byteMes.Length] = message[i];
            return newMes;
        }

        public void CreateFile(string stPath, string ndPath, string message)
        {
            FileStream inStream = new FileStream(stPath, FileMode.Open, FileAccess.Read);
            int offset = 54;
            inStream.Seek(0, 0);
            byte[] header = new byte[offset];
            inStream.Read(header, 0, offset);
            FileStream outStream = new FileStream(ndPath, FileMode.Create, FileAccess.Write);
            outStream.Write(header, 0, offset);
            UnicodeEncoding unicode = new UnicodeEncoding();
            byte[] newMessageByte = AddMessage(unicode.GetBytes(message));
            inStream.Seek(offset, 0);
            LSB.Encode(inStream, newMessageByte, outStream);
            inStream.Close();
            outStream.Close();
        }

        private void btnChooseDec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh để giải mã";
            openFile.Filter = "Bitmap (*.bmp)|*.bmp";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                decPath = openFile.FileName;
                Bitmap bitmap = new Bitmap(decPath);
                FixPicture(bitmap, pictureBoxDec);
                txtPath.Text = decPath;
                txtResult.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void groupBoxBefore_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxAfter_Enter(object sender, EventArgs e)
        {

        }

        private void FormApp_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxDecode_Enter(object sender, EventArgs e)
        {

        }
        //bat dau giai ma
        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                FileStream inStream = new FileStream(decPath, FileMode.Open, FileAccess.Read);
                int offset = 54;
                inStream.Seek(offset, 0);
                byte[] byteLength = new byte[4];
                byteLength = LSB.Decode(inStream, 4);
                int length = BitConverter.ToInt32(byteLength, 0);
                inStream.Seek(offset + 4 * 8, 0);
                byte[] buffer = new byte[length];
                while (true)
                {
                    try
                    {
                        buffer = LSB.Decode(inStream, length);
                    }
                    catch
                    {
                        MessageBox.Show("Ảnh này không chứa thông tin!", "Thông báo");
                        break;
                    }
                    byte[] hidenMessage = new byte[4 + buffer.Length];
                    hidenMessage = ByteArray(byteLength, buffer);
                    byte[] byteMessage = new byte[length];
                    for (int i = 0; i < length; i++)
                        byteMessage[i] = hidenMessage[i + 4];
                    UnicodeEncoding unicode = new UnicodeEncoding();
                    string result = unicode.GetString(byteMessage);
                    txtResult.Text = result;
                    MessageBox.Show("Giải mã thành công!", "Thông báo");
                    break;
                }
                inStream.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh để giải mã!", "Thông báo");
            }
        }

        private byte[] ByteArray(byte[] stArr, byte[] ndArr)
        {
            byte[] resultArr = new byte[stArr.Length + ndArr.Length];
            for (int i = 0; i < stArr.Length; i++)
                resultArr[i] = stArr[i];
            for (int i = 0; i < ndArr.Length; i++)
                resultArr[i + stArr.Length] = ndArr[i];
            return resultArr;
        }
    }
}
