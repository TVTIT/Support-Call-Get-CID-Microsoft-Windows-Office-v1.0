using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Net.NetworkInformation;
using System.Runtime;
using System.Runtime.InteropServices;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CopyIIDButton_Click(object sender, EventArgs e)
        {
            if (TextBoxIID.Text.Length > 0)
                Clipboard.SetText(TextBoxIID.Text);
        }

        private void CopyIID1Button_Click(object sender, EventArgs e)
        {
            if (IID1TextBox.Text.Length > 0)
                Clipboard.SetText(IID1TextBox.Text);
        }

        private void CopyIID2Button_Click(object sender, EventArgs e)
        {
            if (IID2TextBox.Text.Length > 0)
                Clipboard.SetText(IID2TextBox.Text);
        }

        private void CopyIID3Button_Click(object sender, EventArgs e)
        {
            if (IID3TextBox.Text.Length > 0)
                Clipboard.SetText(IID3TextBox.Text);
        }

        private void CopyIID4Button_Click(object sender, EventArgs e)
        {
            if (IID4TextBox.Text.Length > 0)
                Clipboard.SetText(IID4TextBox.Text);
        }

        private void CopyIID5Button_Click(object sender, EventArgs e)
        {
            if (IID5TextBox.Text.Length > 0)
                Clipboard.SetText(IID5TextBox.Text);
        }

        private void CopyIID6Button_Click(object sender, EventArgs e)
        {
            if (IID6TextBox.Text.Length > 0)
                Clipboard.SetText(IID6TextBox.Text);
        }

        private void CopyIID7Button_Click(object sender, EventArgs e)
        {
            if (IID7TextBox.Text.Length > 0)
                Clipboard.SetText(IID7TextBox.Text);
        }

        private void CopyIID8Button_Click(object sender, EventArgs e)
        {
            if (IID8TextBox.Text.Length > 0)
                Clipboard.SetText(IID8TextBox.Text);
        }

        private void CopyIID9Button_Click(object sender, EventArgs e)
        {
            if (IID9TextBox.Text.Length > 0)
                Clipboard.SetText(IID9TextBox.Text);
        }

        private void XongIIDButton_Click(object sender, EventArgs e)
        {
            //IID:626946109075601237884214342196022762195890655430484409254925283
            //I-I-D:6269461-0907560-1237884-2143421-9602276-2195890-6554304-8440925-4925283
            int index;
            foreach (char c in TextBoxIID.Text)
            {
                if (char.IsDigit(c)) ;
                else
                {
                    index = TextBoxIID.Text.IndexOf(c);
                    TextBoxIID.Text = TextBoxIID.Text.Remove(index, 1);
                }
            }
            if (TextBoxIID.Text.Length == 54 || TextBoxIID.Text.Length == 63)
            {
                for (int i = 1; i < 9; i++)
                {
                    TextBoxIID.Text = TextBoxIID.Text.Insert(TextBoxIID.Text.Length / 9 * i + (i - 1), "-");
                }
                string[] IID = TextBoxIID.Text.Split('-');
                IID1TextBox.Text = IID[0];
                IID2TextBox.Text = IID[1];
                IID3TextBox.Text = IID[2];
                IID4TextBox.Text = IID[3];
                IID5TextBox.Text = IID[4];
                IID6TextBox.Text = IID[5];
                IID7TextBox.Text = IID[6];
                IID8TextBox.Text = IID[7];
                IID9TextBox.Text = IID[8];
            }
            else
            {
                MessageBox.Show("Wrong IID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 6)
            {
                textBox2.Focus();
            }
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6 && textBox4.Text.Length == 6 && textBox5.Text.Length == 6 && textBox6.Text.Length == 6 && textBox7.Text.Length == 6 && textBox8.Text.Length == 6)
                button1.Enabled = true;
            else
                button1.Enabled = false;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 6)
            {
                textBox3.Focus();
            }
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6 && textBox4.Text.Length == 6 && textBox5.Text.Length == 6 && textBox6.Text.Length == 6 && textBox7.Text.Length == 6 && textBox8.Text.Length == 6)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 6)
            {
                textBox4.Focus();
            }
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6 && textBox4.Text.Length == 6 && textBox5.Text.Length == 6 && textBox6.Text.Length == 6 && textBox7.Text.Length == 6 && textBox8.Text.Length == 6)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 6)
            {
                textBox5.Focus();
            }
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6 && textBox4.Text.Length == 6 && textBox5.Text.Length == 6 && textBox6.Text.Length == 6 && textBox7.Text.Length == 6 && textBox8.Text.Length == 6)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 6)
            {
                textBox7.Focus();
            }
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6 && textBox4.Text.Length == 6 && textBox5.Text.Length == 6 && textBox6.Text.Length == 6 && textBox7.Text.Length == 6 && textBox8.Text.Length == 6)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length == 6)
            {
                textBox8.Focus();
            }
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6 && textBox4.Text.Length == 6 && textBox5.Text.Length == 6 && textBox6.Text.Length == 6 && textBox7.Text.Length == 6 && textBox8.Text.Length == 6)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 6 && textBox2.Text.Length == 6 && textBox3.Text.Length == 6 && textBox4.Text.Length == 6 && textBox5.Text.Length == 6 && textBox6.Text.Length == 6 && textBox7.Text.Length == 6 && textBox8.Text.Length == 6)
                button1.Enabled = true;
            else
                button1.Enabled = false;
            if (textBox8.Text.Length == 6)
            {
                button1.Focus();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string IID = IID1TextBox.Text + "-" + IID2TextBox.Text + "-" + IID3TextBox.Text + "-" + IID4TextBox.Text + "-" + IID5TextBox.Text + "-" + IID6TextBox.Text + "-" + IID7TextBox.Text + "-" + IID8TextBox.Text + "-" + IID9TextBox.Text;
            string CID = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text;
            foreach (char c in CID)
            {
                if (char.IsDigit(c))
                { }
                else
                {
                    int index = CID.IndexOf(c);
                    CID = CID.Remove(index, 1);
                }

            }
            if (CID.Length == 48)
            {
                textBox10.Text = CID;
                CID = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text + "-" + textBox5.Text + "-" + textBox6.Text + "-" + textBox7.Text + "-" + textBox8.Text;
                textBox11.Text = CID;
                if (IID.Length == 62 || IID.Length == 71)
                {
                    if (AllRdBtn.Checked)
                    {
                        CID_Cmt.Text = "Installation ID (IID): " + IID + "\r\n\r\nConfirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau\r\nĐối với Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /atp " + textBox10.Text + "\r\n\r\nĐối với Office:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\n\r\n\rNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (WindowsRdBtn.Checked)
                    {
                        CID_Cmt.Text = "Installation ID (IID): " + IID + "\r\n\r\nConfirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /atp " + textBox10.Text + "\n\r\n\rNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (AllOfficeRdBtn.Checked)
                    {
                        CID_Cmt.Text = "Installation ID (IID): " + IID + "\r\n\r\nConfirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (Office2016RdBtn.Checked)
                    {
                        CID_Cmt.Text = "Installation ID (IID): " + IID + "\r\n\r\nConfirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nif exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (Office2013RdBtn.Checked)
                    {
                        CID_Cmt.Text = "Installation ID (IID): " + IID + "\r\n\r\nConfirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nif exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (Office2010RdBtn.Checked)
                    {
                        CID_Cmt.Text = "Installation ID (IID): " + IID + "\r\n\r\nConfirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nif exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                }
                else
                {
                    if (AllRdBtn.Checked)
                    {
                        CID_Cmt.Text = "Confirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau\r\nĐối với Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /atp " + textBox10.Text + "\r\n\r\nĐối với Office:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\n\r\n\rNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (WindowsRdBtn.Checked)
                    {
                        CID_Cmt.Text = "Confirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /atp " + textBox10.Text + "\n\r\n\rNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (AllOfficeRdBtn.Checked)
                    {
                        CID_Cmt.Text = "Confirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (Office2016RdBtn.Checked)
                    {
                        CID_Cmt.Text = "\r\nConfirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nif exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16)\"i\r\nf exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (Office2013RdBtn.Checked)
                    {
                        CID_Cmt.Text = "Confirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nif exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    if (Office2010RdBtn.Checked)
                    {
                        CID_Cmt.Text = "Confirmation ID (CID): " + CID + "\r\n\r\nBạn có thể kích hoạt bằng cách nhập CID vào Activation Windows, MSAct,...\r\nHoặc bạn có thể bật CMD với quyền admin rồi paste đoạn này vào dùng lệnh sau:\r\nif exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /actcid:" + textBox10.Text + "\r\n\r\nNếu thành công bạn nhớ SAO LƯU BẢN QUYỀN LẠI (CỰC KỲ QUAN TRỌNG) theo hướng dẫn: https://docs.google.com/document/d/1epCNte0EFOGm7aZxaXU1RUin-nhhyjxmrzV9n8uanbo/edit \r\nĐÓNG CMT\r\nKHÔNG XÓA BÀI \r\n\r\nSupport Call Get CID Microsoft Windows Office v1.0. Copyright © 2018 TVT. All rights reserved";
                    }
                    Clipboard.SetText(CID_Cmt.Text);
                }
            }
            else
                MessageBox.Show("Wrong CID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            textBox5.MaxLength = 6;
            if (textBox5.Text.Length == 6)
                textBox6.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox10.Text.Length > 0)
                Clipboard.SetText(textBox10.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox11.Text.Length > 0)
                Clipboard.SetText(textBox11.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CID_Cmt.Text.Length > 0)
                Clipboard.SetText(CID_Cmt.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://fb.com/trung.thethis");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping();
                ping.Send("google.com");
                WebClient wc = new WebClient();
                Version newver = new Version(wc.DownloadString("https://raw.githubusercontent.com/TVTIT/TVT/master/ver.JSON"));
                Version currVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                if (currVer < newver)
                {
                    DialogResult result;
                    result = MessageBox.Show(wc.DownloadString("https://raw.githubusercontent.com/TVTIT/TVT/master/New%20ver%20messenger.JSON"), "New updates are available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Process.Start("http://bit.ly/SpCallGetCID");
                    }
                }
            }
            catch
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBoxIID.Text = null;
            IID1TextBox.Text = null;
            IID2TextBox.Text = null;
            IID3TextBox.Text = null;
            IID4TextBox.Text = null;
            IID5TextBox.Text = null;
            IID6TextBox.Text = null;
            IID7TextBox.Text = null;
            IID8TextBox.Text = null;
            IID9TextBox.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
            textBox8.Text = null;
            textBox10.Text = null;
            textBox11.Text = null;
            CID_Cmt.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Ping ping = new Ping();
                ping.Send("google.com");
                WebClient wc = new WebClient();
                Version newver = new Version(wc.DownloadString("https://raw.githubusercontent.com/TVTIT/TVT/master/ver.JSON"));
                Version currVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                if (currVer < newver)
                {
                    DialogResult result;
                    result = MessageBox.Show(wc.DownloadString("https://raw.githubusercontent.com/TVTIT/TVT/master/New%20ver%20messenger.JSON"), "New updates are available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Process.Start(wc.DownloadString("https://raw.githubusercontent.com/TVTIT/TVT/master/Link.JSON"));
                    }
                }
                else
                {
                    MessageBox.Show("No updates are available", null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("No internet connection\r\nPlease connect to the internet to Check for updates", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://facebook.com/trung.thethis");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Please choose an Option", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox9.Text.Length == 29)
            {
                textBox9.Text = textBox9.Text.ToUpper();
                if (radioButton6.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ato\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /dti>id.txt\r\nstart id.txt\r\n\r\nOffice:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))&cls\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /ato\r\n\r\nOffice:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))&cls\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /dti>id.txt\r\nstart id.txt\r\n\r\nOffice:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))&cls\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                        }
                    }
                }

                if (radioButton5.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "cscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ato\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /dti>id.txt\r\nstart id.txt\r\n";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "cscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ato\r\n";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "cscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /dti>id.txt\r\nstart id.txt\r\n";
                        }
                    }
                }


                if (radioButton4.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "for %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))&cls\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "for %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))&cls\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\n";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "for %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))&cls\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                        }
                    }
                }


                if (radioButton3.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\n";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                        }
                    }
                }


                if (radioButton2.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\n";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                        }
                    }
                }
                if (radioButton1.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript //nologo OSPP.vbs /act\r\n";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt\r\n";
                        }
                    }
                }
            }
            else
                MessageBox.Show("Wrong Key", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.Length > 0)
                Clipboard.SetText(textBox9.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox12.Text.Length > 0)
                Clipboard.SetText(textBox12.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox9.Text = null;
            textBox12.Text = null;
            radioButton6.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox15.Text.Length > 0)
                Clipboard.SetText(textBox15.Text);
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
                textBox13.Visible = true;
            else
                textBox13.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox14.Text.Length > 0)
                Clipboard.SetText(textBox14.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string KMSSV;
            //Windows
            if (radioButton7.Checked)
            {
                //KMS Ssrver: kms.digiboy.ir
                if (radioButton9.Checked)
                {
                    KMSSV = "kms.digiboy.ir";
                    switch (comboBox1.SelectedIndex)
                    {
                        case -1:
                            MessageBox.Show("Please choose a version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        //Windows 10 Home
                        case 0:
                            textBox14.Text = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home N
                        case 1:
                            textBox14.Text = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home SL
                        case 2:
                            textBox14.Text = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home China
                        case 3:
                            textBox14.Text = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro
                        case 4:
                            textBox14.Text = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro N
                        case 5:
                            textBox14.Text = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Edu
                        case 6:
                            textBox14.Text = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Edu N
                        case 7:
                            textBox14.Text = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation
                        case 8:
                            textBox14.Text = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation N
                        case 9:
                            textBox14.Text = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu
                        case 10:
                            textBox14.Text = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu N
                        case 11:
                            textBox14.Text = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter
                        case 12:
                            textBox14.Text = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter N
                        case 13:
                            textBox14.Text = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter G
                        case 14:
                            textBox14.Text = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter GN
                        case 15:
                            textBox14.Text = "44RPN-FTY23-9VTTB-MP9BX-T84FV";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015
                        case 16:
                            textBox14.Text = "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015 N
                        case 17:
                            textBox14.Text = "2F77B-TNFGY-69QQF-B8YKP-D69TJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016
                        case 18:
                            textBox14.Text = "DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016 N
                        case 19:
                            textBox14.Text = "QFFDN-GRT3P-VKWWX-X7T3R-8B639";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019
                        case 20:
                            textBox14.Text = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019 N
                        case 21:
                            textBox14.Text = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter for Virtual Desktops
                        case 22:
                            textBox14.Text = "CPWHC-NT2C7-VYW78-DHDB2-PG3GK";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Remote Server
                        case 23:
                            textBox14.Text = "7NBT4-WGBQX-MP4H7-QXFF8-YP3KX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Lean
                        case 24:
                            textBox14.Text = "NBTWJ-3DR69-3C4V8-C26MC-GQ9M6";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 8.1 Core (Home)
                        case 25:
                            textBox14.Text = "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core N (Home N)
                        case 26:
                            textBox14.Text = "7B9N3-D94CG-YTVHR-QBPX3-RJP64";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core SL
                        case 27:
                            textBox14.Text = "BB6NG-PQ82V-VRDPW-8XVD2-V8P66";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core China
                        case 28:
                            textBox14.Text = "NCTT7-2RGK8-WMHRF-RY7YQ-JTXG3";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core ARM
                        case 29:
                            textBox14.Text = "XYTND-K6QKT-K2MRH-66RTM-43JKP";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro
                        case 30:
                            textBox14.Text = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro N
                        case 31:
                            textBox14.Text = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro with Media Center
                        case 32:
                            textBox14.Text = "789NJ-TQK6T-6XTH8-J39CJ-J8D3P";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Enter
                        case 33:
                            textBox14.Text = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Enter N
                        case 34:
                            textBox14.Text = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Pro
                        case 35:
                            textBox14.Text = "NMMPB-38DD4-R2823-62W8D-VXKJB";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Enterprise
                        case 36:
                            textBox14.Text = "FNFKF-PWTVT-9RC8H-32HB2-JB34X";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Automotive
                        case 37:
                            textBox14.Text = "VHXM3-NR6FT-RY6RT-CK882-KW2CJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing N
                        case 38:
                            textBox14.Text = "Q6HTR-N24GM-PMJFP-69CD8-2GXKR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing SL
                        case 39:
                            textBox14.Text = "KF37N-VDV38-GRRTV-XH8X6-6F3BB";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing China
                        case 40:
                            textBox14.Text = "R962J-37N87-9VVK2-WJ74P-XTMHR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro for Students
                        case 41:
                            textBox14.Text = "MX3RK-9HNGX-K3QKC-6PJ3F-W8D7B";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro for Students N
                        case 42:
                            textBox14.Text = "TNFGH-2R6PB-8XM3K-QYHX2-J4296";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 8 Core
                        case 43:
                            textBox14.Text = "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core N
                        case 44:
                            textBox14.Text = "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core SL
                        case 45:
                            textBox14.Text = "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core China
                        case 46:
                            textBox14.Text = "4K36P-JN4VD-GDC6V-KDT89-DYFKP";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core ARM
                        case 47:
                            textBox14.Text = "DXHJF-N9KQX-MFPVR-GHGQK-Y7RKV";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro
                        case 48:
                            textBox14.Text = "NG4HW-VH26C-733KW-K6F98-J8CK4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro N
                        case 49:
                            textBox14.Text = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro with Media Center
                        case 50:
                            textBox14.Text = "GNBB8-YVD74-QJHX6-27H4K-8QHDG";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro Enter
                        case 51:
                            textBox14.Text = "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro Enter N
                        case 52:
                            textBox14.Text = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Embedded Industry Pro
                        case 53:
                            textBox14.Text = "RYXVT-BNQG7-VD29F-DBMRY-HT73M";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Embedded Industry Enter
                        case 54:
                            textBox14.Text = "NKB3R-R2F8T-3XCDP-7Q2KW-XWYQ2";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 7 Pro
                        case 55:
                            textBox14.Text = "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Pro N
                        case 56:
                            textBox14.Text = "MRPKT-YTG23-K7D7T-X2JMM-QY7MG";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Pro E
                        case 57:
                            textBox14.Text = "W82YF-2Q76Y-63HXB-FGJG9-GF7QX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter
                        case 58:
                            textBox14.Text = "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter N
                        case 59:
                            textBox14.Text = "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter E
                        case 60:
                            textBox14.Text = "C29WB-22CC8-VJ326-GHFJW-H9DH4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded POSReady 7
                        case 61:
                            textBox14.Text = "YBYF6-BHCR3-JPKRB-CDW7B-F9BK4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded Standard
                        case 62:
                            textBox14.Text = "XGY72-BRBBT-FF8MH-2GG8H-W7KCW";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded ThinPC
                        case 63:
                            textBox14.Text = "73KQT-CD9G6-K7TQG-66MRP-CQ22C";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                    }
                }
                //KMS Server: kms.loto.cc
                if (radioButton10.Checked)
                {
                    KMSSV = "kms.loto.cc";
                    switch (comboBox1.SelectedIndex)
                    {
                        case -1:
                            MessageBox.Show("Please choose a version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        //Windows 10 Home
                        case 0:
                            textBox14.Text = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home N
                        case 1:
                            textBox14.Text = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home SL
                        case 2:
                            textBox14.Text = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home China
                        case 3:
                            textBox14.Text = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro
                        case 4:
                            textBox14.Text = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro N
                        case 5:
                            textBox14.Text = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Edu
                        case 6:
                            textBox14.Text = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Edu N
                        case 7:
                            textBox14.Text = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation
                        case 8:
                            textBox14.Text = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation N
                        case 9:
                            textBox14.Text = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu
                        case 10:
                            textBox14.Text = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu N
                        case 11:
                            textBox14.Text = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter
                        case 12:
                            textBox14.Text = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter N
                        case 13:
                            textBox14.Text = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter G
                        case 14:
                            textBox14.Text = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter GN
                        case 15:
                            textBox14.Text = "44RPN-FTY23-9VTTB-MP9BX-T84FV";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015
                        case 16:
                            textBox14.Text = "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015 N
                        case 17:
                            textBox14.Text = "2F77B-TNFGY-69QQF-B8YKP-D69TJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016
                        case 18:
                            textBox14.Text = "DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016 N
                        case 19:
                            textBox14.Text = "QFFDN-GRT3P-VKWWX-X7T3R-8B639";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019
                        case 20:
                            textBox14.Text = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019 N
                        case 21:
                            textBox14.Text = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter for Virtual Desktops
                        case 22:
                            textBox14.Text = "CPWHC-NT2C7-VYW78-DHDB2-PG3GK";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Remote Server
                        case 23:
                            textBox14.Text = "7NBT4-WGBQX-MP4H7-QXFF8-YP3KX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Lean
                        case 24:
                            textBox14.Text = "NBTWJ-3DR69-3C4V8-C26MC-GQ9M6";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 8.1 Core (Home)
                        case 25:
                            textBox14.Text = "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core N (Home N)
                        case 26:
                            textBox14.Text = "7B9N3-D94CG-YTVHR-QBPX3-RJP64";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core SL
                        case 27:
                            textBox14.Text = "BB6NG-PQ82V-VRDPW-8XVD2-V8P66";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core China
                        case 28:
                            textBox14.Text = "NCTT7-2RGK8-WMHRF-RY7YQ-JTXG3";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core ARM
                        case 29:
                            textBox14.Text = "XYTND-K6QKT-K2MRH-66RTM-43JKP";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro
                        case 30:
                            textBox14.Text = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro N
                        case 31:
                            textBox14.Text = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro with Media Center
                        case 32:
                            textBox14.Text = "789NJ-TQK6T-6XTH8-J39CJ-J8D3P";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Enter
                        case 33:
                            textBox14.Text = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Enter N
                        case 34:
                            textBox14.Text = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Pro
                        case 35:
                            textBox14.Text = "NMMPB-38DD4-R2823-62W8D-VXKJB";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Enterprise
                        case 36:
                            textBox14.Text = "FNFKF-PWTVT-9RC8H-32HB2-JB34X";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Automotive
                        case 37:
                            textBox14.Text = "VHXM3-NR6FT-RY6RT-CK882-KW2CJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing N
                        case 38:
                            textBox14.Text = "Q6HTR-N24GM-PMJFP-69CD8-2GXKR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing SL
                        case 39:
                            textBox14.Text = "KF37N-VDV38-GRRTV-XH8X6-6F3BB";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing China
                        case 40:
                            textBox14.Text = "R962J-37N87-9VVK2-WJ74P-XTMHR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro for Students
                        case 41:
                            textBox14.Text = "MX3RK-9HNGX-K3QKC-6PJ3F-W8D7B";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro for Students N
                        case 42:
                            textBox14.Text = "TNFGH-2R6PB-8XM3K-QYHX2-J4296";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 8 Core
                        case 43:
                            textBox14.Text = "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core N
                        case 44:
                            textBox14.Text = "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core SL
                        case 45:
                            textBox14.Text = "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core China
                        case 46:
                            textBox14.Text = "4K36P-JN4VD-GDC6V-KDT89-DYFKP";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core ARM
                        case 47:
                            textBox14.Text = "DXHJF-N9KQX-MFPVR-GHGQK-Y7RKV";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro
                        case 48:
                            textBox14.Text = "NG4HW-VH26C-733KW-K6F98-J8CK4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro N
                        case 49:
                            textBox14.Text = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro with Media Center
                        case 50:
                            textBox14.Text = "GNBB8-YVD74-QJHX6-27H4K-8QHDG";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro Enter
                        case 51:
                            textBox14.Text = "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro Enter N
                        case 52:
                            textBox14.Text = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Embedded Industry Pro
                        case 53:
                            textBox14.Text = "RYXVT-BNQG7-VD29F-DBMRY-HT73M";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Embedded Industry Enter
                        case 54:
                            textBox14.Text = "NKB3R-R2F8T-3XCDP-7Q2KW-XWYQ2";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 7 Pro
                        case 55:
                            textBox14.Text = "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Pro N
                        case 56:
                            textBox14.Text = "MRPKT-YTG23-K7D7T-X2JMM-QY7MG";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Pro E
                        case 57:
                            textBox14.Text = "W82YF-2Q76Y-63HXB-FGJG9-GF7QX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter
                        case 58:
                            textBox14.Text = "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter N
                        case 59:
                            textBox14.Text = "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter E
                        case 60:
                            textBox14.Text = "C29WB-22CC8-VJ326-GHFJW-H9DH4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded POSReady 7
                        case 61:
                            textBox14.Text = "YBYF6-BHCR3-JPKRB-CDW7B-F9BK4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded Standard
                        case 62:
                            textBox14.Text = "XGY72-BRBBT-FF8MH-2GG8H-W7KCW";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded ThinPC
                        case 63:
                            textBox14.Text = "73KQT-CD9G6-K7TQG-66MRP-CQ22C";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                    }
                }

                //KMS Server: Custom
                if (radioButton11.Checked)
                {
                    if (textBox13.Text.Length == 0)
                    {
                        MessageBox.Show("Please type the KMS Server or chosse other option", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        KMSSV = textBox13.Text;
                    }
                    switch (comboBox1.SelectedIndex)
                    {
                        case -1:
                            MessageBox.Show("Please choose a version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        //Windows 10 Home
                        case 0:
                            textBox14.Text = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home N
                        case 1:
                            textBox14.Text = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home SL
                        case 2:
                            textBox14.Text = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home China
                        case 3:
                            textBox14.Text = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro
                        case 4:
                            textBox14.Text = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro N
                        case 5:
                            textBox14.Text = "MH37W-N47XK-V7XM9-C7227-GCQG9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Edu
                        case 6:
                            textBox14.Text = "6TP4R-GNPTD-KYYHQ-7B7DP-J447Y";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Edu N
                        case 7:
                            textBox14.Text = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation
                        case 8:
                            textBox14.Text = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation N
                        case 9:
                            textBox14.Text = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu
                        case 10:
                            textBox14.Text = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu N
                        case 11:
                            textBox14.Text = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter
                        case 12:
                            textBox14.Text = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter N
                        case 13:
                            textBox14.Text = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter G
                        case 14:
                            textBox14.Text = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter GN
                        case 15:
                            textBox14.Text = "44RPN-FTY23-9VTTB-MP9BX-T84FV";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015
                        case 16:
                            textBox14.Text = "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015 N
                        case 17:
                            textBox14.Text = "2F77B-TNFGY-69QQF-B8YKP-D69TJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016
                        case 18:
                            textBox14.Text = "DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016 N
                        case 19:
                            textBox14.Text = "QFFDN-GRT3P-VKWWX-X7T3R-8B639";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019
                        case 20:
                            textBox14.Text = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019 N
                        case 21:
                            textBox14.Text = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter for Virtual Desktops
                        case 22:
                            textBox14.Text = "CPWHC-NT2C7-VYW78-DHDB2-PG3GK";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Remote Server
                        case 23:
                            textBox14.Text = "7NBT4-WGBQX-MP4H7-QXFF8-YP3KX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Lean
                        case 24:
                            textBox14.Text = "NBTWJ-3DR69-3C4V8-C26MC-GQ9M6";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 8.1 Core (Home)
                        case 25:
                            textBox14.Text = "M9Q9P-WNJJT-6PXPY-DWX8H-6XWKK";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core N (Home N)
                        case 26:
                            textBox14.Text = "7B9N3-D94CG-YTVHR-QBPX3-RJP64";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core SL
                        case 27:
                            textBox14.Text = "BB6NG-PQ82V-VRDPW-8XVD2-V8P66";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core China
                        case 28:
                            textBox14.Text = "NCTT7-2RGK8-WMHRF-RY7YQ-JTXG3";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Core ARM
                        case 29:
                            textBox14.Text = "XYTND-K6QKT-K2MRH-66RTM-43JKP";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro
                        case 30:
                            textBox14.Text = "GCRJD-8NW9H-F2CDX-CCM8D-9D6T9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro N
                        case 31:
                            textBox14.Text = "HMCNV-VVBFX-7HMBH-CTY9B-B4FXY";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro with Media Center
                        case 32:
                            textBox14.Text = "789NJ-TQK6T-6XTH8-J39CJ-J8D3P";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Enter
                        case 33:
                            textBox14.Text = "MHF9N-XY6XB-WVXMC-BTDCT-MKKG7";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Enter N
                        case 34:
                            textBox14.Text = "TT4HM-HN7YT-62K67-RGRQJ-JFFXW";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Pro
                        case 35:
                            textBox14.Text = "NMMPB-38DD4-R2823-62W8D-VXKJB";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Enterprise
                        case 36:
                            textBox14.Text = "FNFKF-PWTVT-9RC8H-32HB2-JB34X";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Embedded Industry Automotive
                        case 37:
                            textBox14.Text = "VHXM3-NR6FT-RY6RT-CK882-KW2CJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing N
                        case 38:
                            textBox14.Text = "Q6HTR-N24GM-PMJFP-69CD8-2GXKR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing SL
                        case 39:
                            textBox14.Text = "KF37N-VDV38-GRRTV-XH8X6-6F3BB";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 with Bing China
                        case 40:
                            textBox14.Text = "R962J-37N87-9VVK2-WJ74P-XTMHR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro for Students
                        case 41:
                            textBox14.Text = "MX3RK-9HNGX-K3QKC-6PJ3F-W8D7B";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8.1 Pro for Students N
                        case 42:
                            textBox14.Text = "TNFGH-2R6PB-8XM3K-QYHX2-J4296";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 8 Core
                        case 43:
                            textBox14.Text = "BN3D2-R7TKB-3YPBD-8DRP2-27GG4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core N
                        case 44:
                            textBox14.Text = "8N2M2-HWPGY-7PGT9-HGDD8-GVGGY";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core SL
                        case 45:
                            textBox14.Text = "2WN2H-YGCQR-KFX6K-CD6TF-84YXQ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core China
                        case 46:
                            textBox14.Text = "4K36P-JN4VD-GDC6V-KDT89-DYFKP";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Core ARM
                        case 47:
                            textBox14.Text = "DXHJF-N9KQX-MFPVR-GHGQK-Y7RKV";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro
                        case 48:
                            textBox14.Text = "NG4HW-VH26C-733KW-K6F98-J8CK4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro N
                        case 49:
                            textBox14.Text = "XCVCF-2NXM9-723PB-MHCB7-2RYQQ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro with Media Center
                        case 50:
                            textBox14.Text = "GNBB8-YVD74-QJHX6-27H4K-8QHDG";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro Enter
                        case 51:
                            textBox14.Text = "32JNW-9KQ84-P47T8-D8GGY-CWCK7";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Pro Enter N
                        case 52:
                            textBox14.Text = "JMNMF-RHW7P-DMY6X-RF3DR-X2BQT";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Embedded Industry Pro
                        case 53:
                            textBox14.Text = "RYXVT-BNQG7-VD29F-DBMRY-HT73M";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 8 Embedded Industry Enter
                        case 54:
                            textBox14.Text = "NKB3R-R2F8T-3XCDP-7Q2KW-XWYQ2";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;


                        //Windows 7 Pro
                        case 55:
                            textBox14.Text = "FJ82H-XT6CR-J8D7P-XQJJ2-GPDD4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Pro N
                        case 56:
                            textBox14.Text = "MRPKT-YTG23-K7D7T-X2JMM-QY7MG";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Pro E
                        case 57:
                            textBox14.Text = "W82YF-2Q76Y-63HXB-FGJG9-GF7QX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter
                        case 58:
                            textBox14.Text = "33PXH-7Y6KF-2VJC9-XBBR8-HVTHH";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter N
                        case 59:
                            textBox14.Text = "YDRBP-3D83W-TY26F-D46B2-XCKRJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Enter E
                        case 60:
                            textBox14.Text = "C29WB-22CC8-VJ326-GHFJW-H9DH4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded POSReady 7
                        case 61:
                            textBox14.Text = "YBYF6-BHCR3-JPKRB-CDW7B-F9BK4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded Standard
                        case 62:
                            textBox14.Text = "XGY72-BRBBT-FF8MH-2GG8H-W7KCW";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 7 Embedded ThinPC
                        case 63:
                            textBox14.Text = "73KQT-CD9G6-K7TQG-66MRP-CQ22C";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms " + KMSSV + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                    }
                }
            }
            //Server
            if (radioButton12.Checked)
            {
                //KMS Ssrver: kms.digiboy.ir
                if (radioButton9.Checked)
                {
                    KMSSV = "kms.digiboy.ir";
                    switch (comboBox2.SelectedIndex)
                    {
                        case -1:
                            MessageBox.Show("Please choose a version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        //Server 2019 Standard
                        case 0:
                            AddKeyWin("N69G4-B89J2-4G8F4-WWYCC-J464C", KMSSV);
                            break;
                        //Server 2019 datacenter
                        case 1:
                            AddKeyWin("WMDGN-G9PQG-XVVXX-R3X43-63DFG", KMSSV);
                            break;
                        //Server 2019 Essential
                        case 2:
                            AddKeyWin("WVDHN-86M7X-466P6-VHXV7-YY726", KMSSV);
                            break;
                        //Server 2019 Essential
                        case 3:
                            AddKeyWin("WVDHN-86M7X-466P6-VHXV7-YY726", KMSSV);
                            break;
                        //Server 2019 Azure core
                        case 4:
                            AddKeyWin("FDNH6-VW9RW-BXPJ7-4XTYG-239TB", KMSSV);
                            break;
                        //sv 2019 stan acor
                        case 5:
                            AddKeyWin("N2KJX-J94YW-TQVFB-DG9YT-724CC", KMSSV);
                            break;
                        //sv 2019 data acor
                        case 6:
                            AddKeyWin("6NMRW-2C8FM-D24W7-TQWMY-CWH2D", KMSSV);
                            break;
                        //arm64
                        case 7:
                            AddKeyWin("GRFBW-QNDC4-6QBHG-CCK3B-2PR88", KMSSV);
                            break;


                        //sv 2016
                        //stan
                        case 8:
                            AddKeyWin("WC2BQ-8NRM3-FDDYY-2BFGV-KHKQY", KMSSV);
                            break;
                        //data
                        case 9:
                            AddKeyWin("CB7KF-BWN84-R7R2Y-793K2-8XDDG", KMSSV);
                            break;
                        //essen
                        case 10:
                            AddKeyWin("JCKRF-N37P4-C2D82-9YXRT-4M63B", KMSSV);
                            break;
                        //cloud storage
                        case 11:
                            AddKeyWin("QN4C6-GBJD2-FB422-GHWJK-GJG2R", KMSSV);
                            break;
                        //azure core
                        case 12:
                            AddKeyWin("VP34G-4NPPG-79JTQ-864T4-R3MQX", KMSSV);
                            break;
                        //stan acor
                        case 13:
                            AddKeyWin("PTXN8-JFHJM-4WC78-MPCBR-9W4KR", KMSSV);
                            break;
                        //data acor
                        case 14:
                            AddKeyWin("2HXDN-KRXHB-GPYC7-YCKFJ-7FVDG", KMSSV);
                            break;
                        //arm64
                        case 15:
                            AddKeyWin("K9FYF-G6NCK-73M32-XMVPY-F9DRR", KMSSV);
                            break;


                        //sv 2012 r2
                        //stan
                        case 16:
                            AddKeyWin("D2N9P-3P6X9-2R39C-7RTCD-MDVJX", KMSSV);
                            break;
                        //data
                        case 17:
                            AddKeyWin("W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9", KMSSV);
                            break;
                        //essen
                        case 18:
                            AddKeyWin("KNC87-3J2TX-XB4WP-VCPJV-M4FWM", KMSSV);
                            break;
                        //cloud storage
                        case 19:
                            AddKeyWin("3NPTF-33KPT-GGBPR-YX76B-39KDD", KMSSV);
                            break;


                        //sv 2013
                        //stan
                        case 20:
                            AddKeyWin("XC9B7-NBPP2-83J2H-RHMBY-92BT4", KMSSV);
                            break;
                        //data
                        case 21:
                            AddKeyWin("48HP8-DN98B-MYWDG-T2DCC-8W83P", KMSSV);
                            break;
                        //Multipoint stan
                        case 22:
                            AddKeyWin("HM7DN-YVMH3-46JC3-XYTG7-CYQJJ", KMSSV);
                            break;
                        //multipoint pre
                        case 23:
                            AddKeyWin("XNH6W-2V9GX-RGJ4K-Y8X6F-QGJ2G", KMSSV);
                            break;


                        //sv 2008 r2
                        //web
                        case 24:
                            AddKeyWin("6TPJF-RBVHG-WBW2R-86QPH-6RTM4", KMSSV);
                            break;
                        //hpc
                        case 25:
                            AddKeyWin("TT8MH-CG224-D3D7Q-498W2-9QCTX", KMSSV);
                            break;
                        //stan
                        case 26:
                            AddKeyWin("YC6KT-GKW9T-YTKYR-T4X34-R7VHC", KMSSV);
                            break;
                        //data
                        case 27:
                            AddKeyWin("74YFP-3QFB3-KQT8W-PMXWJ-7M648", KMSSV);
                            break;
                        //enter
                        case 28:
                            AddKeyWin("489J6-VHDMP-X63PK-3K798-CPX3Y", KMSSV);
                            break;
                        //itanium
                        case 29:
                            AddKeyWin("GT63C-RJFQ3-4GMB6-BRFB9-CB83V", KMSSV);
                            break;
                        //multi point sv
                        case 30:
                            AddKeyWin("736RG-XDKJK-V34PF-BHK87-J6X3K", KMSSV);
                            break;


                        //sv2008
                        //web
                        case 31:
                            AddKeyWin("WYR28-R7TFJ-3X2YQ-YCY4H-M249D", KMSSV);
                            break;
                        //stan
                        case 32:
                            AddKeyWin("TM24T-X9RMF-VWXK6-X8JC9-BFGM2", KMSSV);
                            break;
                        //stan without hyper-v
                        case 33:
                            AddKeyWin("W7VD6-7JFBR-RX26B-YKQ3Y-6FFFJ", KMSSV);
                            break;
                        //enter
                        case 34:
                            AddKeyWin("YQGMW-MPWTJ-34KDK-48M3W-X4Q6V", KMSSV);
                            break;
                        //enter without hyper-v
                        case 35:
                            AddKeyWin("39BXF-X8Q23-P2WWT-38T2F-G3FPG", KMSSV);
                            break;
                        //hpc
                        case 36:
                            AddKeyWin("RCTX3-KWVHP-BR6TB-RB6DM-6X7HP", KMSSV);
                            break;
                        //data
                        case 37:
                            AddKeyWin("7M67G-PC374-GR742-YH8V4-TCBY3", KMSSV);
                            break;
                        //data without hyper-v
                        case 38:
                            AddKeyWin("22XQ2-VRXRG-P8D42-K34TD-G3QQC", KMSSV);
                            break;
                        //for Itanium-Based Systems
                        case 39:
                            AddKeyWin("4DWFP-JF3DJ-B7DTH-78FJB-PDRHK", KMSSV);
                            break;
                    }
                }
                //KMS Server: kms.loto.cc
                if (radioButton10.Checked)
                {
                    KMSSV = "kms.loto.cc";
                    switch (comboBox2.SelectedIndex)
                    {
                        case -1:
                            MessageBox.Show("Please choose a version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        //Server 2019 Standard
                        case 0:
                            AddKeyWin("N69G4-B89J2-4G8F4-WWYCC-J464C", KMSSV);
                            break;
                        //Server 2019 datacenter
                        case 1:
                            AddKeyWin("WMDGN-G9PQG-XVVXX-R3X43-63DFG", KMSSV);
                            break;
                        //Server 2019 Essential
                        case 2:
                            AddKeyWin("WVDHN-86M7X-466P6-VHXV7-YY726", KMSSV);
                            break;
                        //Server 2019 Essential
                        case 3:
                            AddKeyWin("WVDHN-86M7X-466P6-VHXV7-YY726", KMSSV);
                            break;
                        //Server 2019 Azure core
                        case 4:
                            AddKeyWin("FDNH6-VW9RW-BXPJ7-4XTYG-239TB", KMSSV);
                            break;
                        //sv 2019 stan acor
                        case 5:
                            AddKeyWin("N2KJX-J94YW-TQVFB-DG9YT-724CC", KMSSV);
                            break;
                        //sv 2019 data acor
                        case 6:
                            AddKeyWin("6NMRW-2C8FM-D24W7-TQWMY-CWH2D", KMSSV);
                            break;
                        //arm64
                        case 7:
                            AddKeyWin("GRFBW-QNDC4-6QBHG-CCK3B-2PR88", KMSSV);
                            break;


                        //sv 2016
                        //stan
                        case 8:
                            AddKeyWin("WC2BQ-8NRM3-FDDYY-2BFGV-KHKQY", KMSSV);
                            break;
                        //data
                        case 9:
                            AddKeyWin("CB7KF-BWN84-R7R2Y-793K2-8XDDG", KMSSV);
                            break;
                        //essen
                        case 10:
                            AddKeyWin("JCKRF-N37P4-C2D82-9YXRT-4M63B", KMSSV);
                            break;
                        //cloud storage
                        case 11:
                            AddKeyWin("QN4C6-GBJD2-FB422-GHWJK-GJG2R", KMSSV);
                            break;
                        //azure core
                        case 12:
                            AddKeyWin("VP34G-4NPPG-79JTQ-864T4-R3MQX", KMSSV);
                            break;
                        //stan acor
                        case 13:
                            AddKeyWin("PTXN8-JFHJM-4WC78-MPCBR-9W4KR", KMSSV);
                            break;
                        //data acor
                        case 14:
                            AddKeyWin("2HXDN-KRXHB-GPYC7-YCKFJ-7FVDG", KMSSV);
                            break;
                        //arm64
                        case 15:
                            AddKeyWin("K9FYF-G6NCK-73M32-XMVPY-F9DRR", KMSSV);
                            break;


                        //sv 2012 r2
                        //stan
                        case 16:
                            AddKeyWin("D2N9P-3P6X9-2R39C-7RTCD-MDVJX", KMSSV);
                            break;
                        //data
                        case 17:
                            AddKeyWin("W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9", KMSSV);
                            break;
                        //essen
                        case 18:
                            AddKeyWin("KNC87-3J2TX-XB4WP-VCPJV-M4FWM", KMSSV);
                            break;
                        //cloud storage
                        case 19:
                            AddKeyWin("3NPTF-33KPT-GGBPR-YX76B-39KDD", KMSSV);
                            break;


                        //sv 2013
                        //stan
                        case 20:
                            AddKeyWin("XC9B7-NBPP2-83J2H-RHMBY-92BT4", KMSSV);
                            break;
                        //data
                        case 21:
                            AddKeyWin("48HP8-DN98B-MYWDG-T2DCC-8W83P", KMSSV);
                            break;
                        //Multipoint stan
                        case 22:
                            AddKeyWin("HM7DN-YVMH3-46JC3-XYTG7-CYQJJ", KMSSV);
                            break;
                        //multipoint pre
                        case 23:
                            AddKeyWin("XNH6W-2V9GX-RGJ4K-Y8X6F-QGJ2G", KMSSV);
                            break;


                        //sv 2008 r2
                        //web
                        case 24:
                            AddKeyWin("6TPJF-RBVHG-WBW2R-86QPH-6RTM4", KMSSV);
                            break;
                        //hpc
                        case 25:
                            AddKeyWin("TT8MH-CG224-D3D7Q-498W2-9QCTX", KMSSV);
                            break;
                        //stan
                        case 26:
                            AddKeyWin("YC6KT-GKW9T-YTKYR-T4X34-R7VHC", KMSSV);
                            break;
                        //data
                        case 27:
                            AddKeyWin("74YFP-3QFB3-KQT8W-PMXWJ-7M648", KMSSV);
                            break;
                        //enter
                        case 28:
                            AddKeyWin("489J6-VHDMP-X63PK-3K798-CPX3Y", KMSSV);
                            break;
                        //itanium
                        case 29:
                            AddKeyWin("GT63C-RJFQ3-4GMB6-BRFB9-CB83V", KMSSV);
                            break;
                        //multi point sv
                        case 30:
                            AddKeyWin("736RG-XDKJK-V34PF-BHK87-J6X3K", KMSSV);
                            break;


                        //sv2008
                        //web
                        case 31:
                            AddKeyWin("WYR28-R7TFJ-3X2YQ-YCY4H-M249D", KMSSV);
                            break;
                        //stan
                        case 32:
                            AddKeyWin("TM24T-X9RMF-VWXK6-X8JC9-BFGM2", KMSSV);
                            break;
                        //stan without hyper-v
                        case 33:
                            AddKeyWin("W7VD6-7JFBR-RX26B-YKQ3Y-6FFFJ", KMSSV);
                            break;
                        //enter
                        case 34:
                            AddKeyWin("YQGMW-MPWTJ-34KDK-48M3W-X4Q6V", KMSSV);
                            break;
                        //enter without hyper-v
                        case 35:
                            AddKeyWin("39BXF-X8Q23-P2WWT-38T2F-G3FPG", KMSSV);
                            break;
                        //hpc
                        case 36:
                            AddKeyWin("RCTX3-KWVHP-BR6TB-RB6DM-6X7HP", KMSSV);
                            break;
                        //data
                        case 37:
                            AddKeyWin("7M67G-PC374-GR742-YH8V4-TCBY3", KMSSV);
                            break;
                        //data without hyper-v
                        case 38:
                            AddKeyWin("22XQ2-VRXRG-P8D42-K34TD-G3QQC", KMSSV);
                            break;
                        //for Itanium-Based Systems
                        case 39:
                            AddKeyWin("4DWFP-JF3DJ-B7DTH-78FJB-PDRHK", KMSSV);
                            break;

                    }
                    //KMS Server: Custom
                    if (textBox13.Text.Length == 0)
                    {
                        MessageBox.Show("Please type the KMS Server or chosse other option", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        KMSSV = textBox13.Text;
                        switch (comboBox2.SelectedIndex)
                        {
                            case -1:
                                MessageBox.Show("Please choose a version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            //Server 2019 Standard
                            case 0:
                                AddKeyWin("N69G4-B89J2-4G8F4-WWYCC-J464C", KMSSV);
                                break;
                            //Server 2019 datacenter
                            case 1:
                                AddKeyWin("WMDGN-G9PQG-XVVXX-R3X43-63DFG", KMSSV);
                                break;
                            //Server 2019 Essential
                            case 2:
                                AddKeyWin("WVDHN-86M7X-466P6-VHXV7-YY726", KMSSV);
                                break;
                            //Server 2019 Essential
                            case 3:
                                AddKeyWin("WVDHN-86M7X-466P6-VHXV7-YY726", KMSSV);
                                break;
                            //Server 2019 Azure core
                            case 4:
                                AddKeyWin("FDNH6-VW9RW-BXPJ7-4XTYG-239TB", KMSSV);
                                break;
                            //sv 2019 stan acor
                            case 5:
                                AddKeyWin("N2KJX-J94YW-TQVFB-DG9YT-724CC", KMSSV);
                                break;
                            //sv 2019 data acor
                            case 6:
                                AddKeyWin("6NMRW-2C8FM-D24W7-TQWMY-CWH2D", KMSSV);
                                break;
                            //arm64
                            case 7:
                                AddKeyWin("GRFBW-QNDC4-6QBHG-CCK3B-2PR88", KMSSV);
                                break;


                            //sv 2016
                            //stan
                            case 8:
                                AddKeyWin("WC2BQ-8NRM3-FDDYY-2BFGV-KHKQY", KMSSV);
                                break;
                            //data
                            case 9:
                                AddKeyWin("CB7KF-BWN84-R7R2Y-793K2-8XDDG", KMSSV);
                                break;
                            //essen
                            case 10:
                                AddKeyWin("JCKRF-N37P4-C2D82-9YXRT-4M63B", KMSSV);
                                break;
                            //cloud storage
                            case 11:
                                AddKeyWin("QN4C6-GBJD2-FB422-GHWJK-GJG2R", KMSSV);
                                break;
                            //azure core
                            case 12:
                                AddKeyWin("VP34G-4NPPG-79JTQ-864T4-R3MQX", KMSSV);
                                break;
                            //stan acor
                            case 13:
                                AddKeyWin("PTXN8-JFHJM-4WC78-MPCBR-9W4KR", KMSSV);
                                break;
                            //data acor
                            case 14:
                                AddKeyWin("2HXDN-KRXHB-GPYC7-YCKFJ-7FVDG", KMSSV);
                                break;
                            //arm64
                            case 15:
                                AddKeyWin("K9FYF-G6NCK-73M32-XMVPY-F9DRR", KMSSV);
                                break;


                            //sv 2012 r2
                            //stan
                            case 16:
                                AddKeyWin("D2N9P-3P6X9-2R39C-7RTCD-MDVJX", KMSSV);
                                break;
                            //data
                            case 17:
                                AddKeyWin("W3GGN-FT8W3-Y4M27-J84CP-Q3VJ9", KMSSV);
                                break;
                            //essen
                            case 18:
                                AddKeyWin("KNC87-3J2TX-XB4WP-VCPJV-M4FWM", KMSSV);
                                break;
                            //cloud storage
                            case 19:
                                AddKeyWin("3NPTF-33KPT-GGBPR-YX76B-39KDD", KMSSV);
                                break;


                            //sv 2013
                            //stan
                            case 20:
                                AddKeyWin("XC9B7-NBPP2-83J2H-RHMBY-92BT4", KMSSV);
                                break;
                            //data
                            case 21:
                                AddKeyWin("48HP8-DN98B-MYWDG-T2DCC-8W83P", KMSSV);
                                break;
                            //Multipoint stan
                            case 22:
                                AddKeyWin("HM7DN-YVMH3-46JC3-XYTG7-CYQJJ", KMSSV);
                                break;
                            //multipoint pre
                            case 23:
                                AddKeyWin("XNH6W-2V9GX-RGJ4K-Y8X6F-QGJ2G", KMSSV);
                                break;


                            //sv 2008 r2
                            //web
                            case 24:
                                AddKeyWin("6TPJF-RBVHG-WBW2R-86QPH-6RTM4", KMSSV);
                                break;
                            //hpc
                            case 25:
                                AddKeyWin("TT8MH-CG224-D3D7Q-498W2-9QCTX", KMSSV);
                                break;
                            //stan
                            case 26:
                                AddKeyWin("YC6KT-GKW9T-YTKYR-T4X34-R7VHC", KMSSV);
                                break;
                            //data
                            case 27:
                                AddKeyWin("74YFP-3QFB3-KQT8W-PMXWJ-7M648", KMSSV);
                                break;
                            //enter
                            case 28:
                                AddKeyWin("489J6-VHDMP-X63PK-3K798-CPX3Y", KMSSV);
                                break;
                            //itanium
                            case 29:
                                AddKeyWin("GT63C-RJFQ3-4GMB6-BRFB9-CB83V", KMSSV);
                                break;
                            //multi point sv
                            case 30:
                                AddKeyWin("736RG-XDKJK-V34PF-BHK87-J6X3K", KMSSV);
                                break;


                            //sv2008
                            //web
                            case 31:
                                AddKeyWin("WYR28-R7TFJ-3X2YQ-YCY4H-M249D", KMSSV);
                                break;
                            //stan
                            case 32:
                                AddKeyWin("TM24T-X9RMF-VWXK6-X8JC9-BFGM2", KMSSV);
                                break;
                            //stan without hyper-v
                            case 33:
                                AddKeyWin("W7VD6-7JFBR-RX26B-YKQ3Y-6FFFJ", KMSSV);
                                break;
                            //enter
                            case 34:
                                AddKeyWin("YQGMW-MPWTJ-34KDK-48M3W-X4Q6V", KMSSV);
                                break;
                            //enter without hyper-v
                            case 35:
                                AddKeyWin("39BXF-X8Q23-P2WWT-38T2F-G3FPG", KMSSV);
                                break;
                            //hpc
                            case 36:
                                AddKeyWin("RCTX3-KWVHP-BR6TB-RB6DM-6X7HP", KMSSV);
                                break;
                            //data
                            case 37:
                                AddKeyWin("7M67G-PC374-GR742-YH8V4-TCBY3", KMSSV);
                                break;
                            //data without hyper-v
                            case 38:
                                AddKeyWin("22XQ2-VRXRG-P8D42-K34TD-G3QQC", KMSSV);
                                break;
                            //for Itanium-Based Systems
                            case 39:
                                AddKeyWin("4DWFP-JF3DJ-B7DTH-78FJB-PDRHK", KMSSV);
                                break;
                        }
                    }
                    //Office
                    if (radioButton8.Checked)
                    {
                        //KMS Ssrver: kms.digiboy.ir
                        if (radioButton9.Checked)
                        {
                            switch (comboBox3.SelectedIndex)
                            {
                                case -1:
                                    MessageBox.Show("Please choose a version", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                //Office 2019 Professional Plus CR2-P
                                case 0:
                                    AddKeyOffice2016("VQ9DP-NVHPH-T9HJC-J9PDT-KTQRG", KMSSV);
                                    break;
                                //Project 2019 Professional CR2-P
                                case 1:
                                    AddKeyOffice2016("XM2V9-DN9HH-QB449-XDGKC-W2RMW", KMSSV);
                                    break;
                                //Visio 2019 Professional CR2-P
                                case 2:
                                    AddKeyOffice2016("N2CG9-YD3YK-936X4-3WR82-Q3X4H", KMSSV);
                                    break;
                                //Office 2019 Professional Plus
                                case 3:
                                    AddKeyOffice2016("NMMKJ-6RK4F-KMJVX-8D9MJ-6MWKP", KMSSV);
                                    break;
                                //Office 2019 Standard
                                case 4:
                                    AddKeyOffice2016("6NWWJ-YQWMR-QKGCB-6TMB3-9D9HK", KMSSV);
                                    break;
                                //Project 2019 Professional
                                case 5:
                                    AddKeyOffice2016("B4NPR-3FKK7-T2MBV-FRQ4W-PKD2B", KMSSV);
                                    break;
                                //Project 2019 Standard
                                case 6:
                                    AddKeyOffice2016("C4F7P-NCP8C-6CQPT-MQHV9-JXD2M", KMSSV);
                                    break;
                                //Visio 2019 Professional
                                case 7:
                                    AddKeyOffice2016("9BGNQ-K37YR-RQHF2-38RQ3-7VCBB", KMSSV);
                                    break;
                                //Visio 2019 Standard
                                case 8:
                                    AddKeyOffice2016("7TQNQ-K3YQQ-3PFH7-CCPPM-X4VQ2", KMSSV);
                                    break;
                                //Access 2019
                                case 9:
                                    AddKeyOffice2016("9N9PT-27V4Y-VJ2PD-YXFMF-YTFQT", KMSSV);
                                    break;
                                //Excel 2019
                                case 10:
                                    AddKeyOffice2016("TMJWT-YYNMB-3BKTF-644FC-RVXBD", KMSSV);
                                    break;
                                //Outlook 2019
                                case 11:
                                    AddKeyOffice2016("7HD7K-N4PVK-BHBCQ-YWQRW-XW4VK", KMSSV);
                                    break;
                                //PowerPoint 2019
                                case 12:
                                    AddKeyOffice2016("RRNCX-C64HY-W2MM7-MCH9G-TJHMQ", KMSSV);
                                    break;
                                //Publisher 2019
                                //Skype for Business 2019
                                //Word 2019
                                //Project 2016 Professional C2R-P
                                //Project 2016 Standard C2R-P
                                //Visio 2016 Professional C2R-P
                                //Visio 2016 Standard C2R-P
                                //Office 2016 MondoR
                                //Office 2016 Mondo
                                //Office 2016 Professional Plus
                                //Office 2016 Standard
                                //Project 2016 Professional
                                //Project 2016 Standard
                                //Visio 2016 Professional
                                //Visio 2016 Standard
                                //Access 2016
                                //Excel 2016
                                //OneNote 2016
                                //Outlook 2016
                                //Powerpoint 2016
                                //Publisher 2016
                                //Skype for Business 2016
                                //Word 2016
                                //Office 2013 Mondo
                                //Office 2013 Professional Plus
                                //Office 2013 Standard
                                //Project 2013 Professional
                                //Project 2013 Standard
                                //Visio 2013 Professional
                                //Visio 2013 Standard
                                //Access 2013
                                //Excel 2013
                                //Groove 2013
                                //InfoPath 2013
                                //Lync 2013
                                //OneNote 2013
                                //Outlook 2013
                                //Powerpoint 2013
                                //Publisher 2013
                                //Word 2013
                                //Office 2010 Mondo
                                //Office 2010 Mondo2
                                //Office 2010 Professional Plus
                                //Office 2010 Standard
                                //Project 2010 Professional
                                //Project 2010 Standard
                                //Visio 2010 Premium
                                //Visio 2010 Professional
                                //Visio 2010 Standard
                                //Access 2010
                                //Excel 2010
                                //Groove (SharePoint Workspace) 2010
                                //InfoPath 2010
                                //OneNote 2010
                                //Outlook 2010
                                //Powerpoint 2010
                                //Publisher 2010
                                //Word 2010
                                //Office Home and Business

                            }
                            //KMS Server: kms.loto.cc
                            if (radioButton10.Checked)
                            {

                            }
                            //KMS Server: Custom
                            if (radioButton11.Checked)
                            {

                            }
                        }
                        if (radioButton7.Checked == false && radioButton12.Checked == false && radioButton8.Checked == false)
                        {
                            MessageBox.Show("Please type the KMS Server or chosse other option", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            radioButton7.Checked = false;
            radioButton12.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            textBox13.Text = null;
            textBox14.Text = null;
            textBox15.Text = null;
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                comboBox1.Visible = true;
                comboBox2.Visible = false;
                comboBox3.Visible = false;
            }
            if (radioButton12.Checked)
            {
                comboBox1.Visible = false;
                comboBox2.Visible = true;
                comboBox3.Visible = false;
            }
            if (radioButton8.Checked)
            {
                comboBox1.Visible = false;
                comboBox2.Visible = false;
                comboBox3.Visible = true;
            }
        }

        void AddKeyWin(string Key, string KMSSV)
        {
            textBox14.Text = Key;
            textBox15.Text = "cscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + Key + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /skms " + KMSSV + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ato";
        }

        void AddKeyOffice2016(string Key, string KMSSV)
        {
            textBox14.Text = Key;
            textBox15.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /inpkey:" + Key + "\r\ncscript //nologo OSPP.vbs /sethst:" + KMSSV + "cscript //nologo OSPP.vbs /act\r\n";
        }

        void AddKeyOffice2013(string Key, string KMSSV)
        {
            textBox14.Text = Key;
            textBox15.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /inpkey:" + Key + "\r\ncscript //nologo OSPP.vbs /sethst:" + KMSSV + "cscript //nologo OSPP.vbs /act\r\n";
        }

        void AddKeyOffice2010(string Key, string KMSSV)
        {
            textBox14.Text = Key;
            textBox15.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14\")\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /inpkey:" + Key + "\r\ncscript //nologo OSPP.vbs /sethst:" + KMSSV + "cscript //nologo OSPP.vbs /act\r\n";
        }

    }
}