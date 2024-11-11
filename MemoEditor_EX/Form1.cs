using Microsoft.JScript;
using System;
using System.IO;
using System.Windows.Forms;

namespace MemoEditor_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSaveFileName.Text))
            {
                MessageBox.Show("파일 이름을 입력하세요"); // 텍스트 박스가 비어있으면
                return;
            }
            else
            {
                MessageBox.Show("파일이 저장 되었습니다");
            }
            StreamWriter wFile = new StreamWriter(new FileStream(txtSaveFileName.Text, FileMode.Create));
            wFile.Write(txtMemo.Text); // 텍스트 박스 내용을 파일에 저장한다
            wFile.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            txtMemo.Text = "";
            StreamReader rFile = new StreamReader(new FileStream(txtOpenFileName.Text, FileMode.Open));
            while (rFile.EndOfStream == false)
            {
                if (string.IsNullOrEmpty(txtOpenFileName.Text)) // 텍스트 박스가 비어있으면
                {
                    MessageBox.Show("불러올 파일명을 입력하세요");
                    return;
                }
                else
                {
                    MessageBox.Show("파일을 불러왔습니다");
                }

                txtMemo.Text += rFile.ReadLine();
                txtMemo.Text += "\r\n";
            }
            rFile.Close();
        }
    }
}
