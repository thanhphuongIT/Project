using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace TuDienOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Data tam = new Data();
        private string DecodeFromUtf8(string utf8_String)
        {
            byte[] bytes = Encoding.Default.GetBytes(utf8_String);
            utf8_String = Encoding.UTF8.GetString(bytes);
            return utf8_String;
        }
        private Field DecodeFieldFromUtf8(Field utf8_String)
        {
            byte[] bytes = Encoding.Default.GetBytes(utf8_String.en);
            utf8_String.en = Encoding.UTF8.GetString(bytes);
            byte[] bytes2 = Encoding.Default.GetBytes(utf8_String.vi);
            utf8_String.vi = Encoding.UTF8.GetString(bytes2);
            return utf8_String;
        }
        private void writetext(Field mess)
        {
            string check = "</em>";
            string check2 = "<em>";
            if (mess.en.Contains(check))
            {
                mess.en = mess.en.Replace(check, "");
                if (mess.en.Contains(check2))
                {
                    mess.en = mess.en.Replace(check2, "");
                }
            }
            textBox2.Text = "  " + mess.vi + "\r\n" + textBox2.Text + "\r\n";
            textBox2.Text = "+ " + mess.en + "\r\n" + textBox2.Text + "\r\n";
            textBox2.Text += "\r\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('#') || textBox1.Text.Contains('?'))
            {
                MessageBox.Show("Vui lòng không nhập ký tự ? và #, hihi", "Lỗi rồi!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                using (var webClient = new WebClient())
                {
                    try
                    {
                        textBox2.Text = "";
                        string rawJSON = webClient.DownloadString("https://api.tracau.vn/WBBcwnwQpV89/s/" + textBox1.Text.Trim() + "/en");
                        tam = JsonConvert.DeserializeObject<Data>(rawJSON);
                        foreach (var i in tam.sentences)
                        {
                            writetext(DecodeFieldFromUtf8(i.fields));
                        }
                        if (tam.tratu.Count > 0) webBrowser1.DocumentText = DecodeFromUtf8(tam.tratu[0].fields.fulltext);
                        else
                        {
                            string error = "<html><head></head><body><div><k>Có biến!!!</k><blockquote><b><cclass> Do câu bạn ghi dài quá nên không thể show danh, động, tính từ được, hihi  </cclass></b></blockquote><blockquote><blockquote>Copyright by @NhanDepTrai</blockquote></blockquote></div></body></html>";
                            webBrowser1.DocumentText = error;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
        }
    }
}

