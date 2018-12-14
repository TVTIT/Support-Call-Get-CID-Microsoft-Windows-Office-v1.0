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
                if (char.IsDigit(c));
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
                MessageBox.Show("Wrong IID", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string IID = IID1TextBox.Text + "-" + IID2TextBox.Text + "-" + IID3TextBox.Text + "-" + IID4TextBox.Text + "-" + IID5TextBox.Text + "-" + IID6TextBox.Text+ "-" + IID7TextBox.Text + "-" + IID8TextBox.Text + "-" + IID9TextBox.Text;
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
                        //Windows 10 Home
                        case 0:
                            textBox14.Text = "TX9XD-98N7V-6WMQ6-BX7FG-H8Q99";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                         //Windows 10 Home N
                        case 1:
                            textBox14.Text = "3KHY7-WNT83-DGQKR-F7HPR-844BM";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home SL
                        case 2:
                            textBox14.Text = "7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Home China
                        case 3:
                            textBox14.Text = "PVMJN-6DFY6-9CCP6-7BKTT-D3WVR";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro
                        case 4:
                            textBox14.Text = "W269N-WFGWX-YVC9B-4J6C9-T83GX";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
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
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation
                        case 8:
                            textBox14.Text = "YVWGF-BXNMC-HTQYQ-CPQ99-66QFC";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Pro Workstation N
                        case 9:
                            textBox14.Text = "NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu
                        case 10:
                            textBox14.Text = "NW6C2-QMPVW-D7KKK-3GKT6-VCFB2";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Edu N
                        case 11:
                            textBox14.Text = "2WH4N-8QGBV-H22JP-CT43Q-MDWWJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter
                        case 12:
                            textBox14.Text = "NPPR9-FWDCX-D2C8J-H872K-2YT43";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter N
                        case 13:
                            textBox14.Text = "DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter G
                        case 14:
                            textBox14.Text = "YYVX9-NTFWV-6MDM3-9PT4T-4M68B";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter GN
                        case 15:
                            textBox14.Text = "44RPN-FTY23-9VTTB-MP9BX-T84FV";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015
                        case 16:
                            textBox14.Text = "WNMTR-4C88C-JK8YV-HQ7T2-76DF9";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2015 N
                        case 17:
                            textBox14.Text = "2F77B-TNFGY-69QQF-B8YKP-D69TJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016
                        case 18:
                            textBox14.Text = "DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSB 2016 N
                        case 19:
                            textBox14.Text = "QFFDN-GRT3P-VKWWX-X7T3R-8B639";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019
                        case 20:
                            textBox14.Text = "M7XTQ-FN8P6-TTKYV-9D4CC-J462D";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter LTSC 2019 N
                        case 21:
                            textBox14.Text = "92NFX-8DJQP-P6BBQ-THF9C-7CG2H";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
                            break;
                        //Windows 10 Enter for Virtual Desktops
                        case 22:
                            textBox14.Text = "CPWHC-NT2C7-VYW78-DHDB2-PG3GK";
                            textBox15.Text = "cscript //nologo %windir%\\system32\\slmgr.vbs /ipk" + textBox14.Text + "\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /skms "+KMSSV+"\r\ncscript //nologo %windir%\\system32\\slmgr.vbs /ato";
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
                    }

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
            //Server
            if (radioButton12.Checked)
            {
                //KMS Ssrver: kms.digiboy.ir
                if (radioButton9.Checked)
                {

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
            //Office
            if (radioButton8.Checked)
            {
                //KMS Ssrver: kms.digiboy.ir
                if (radioButton9.Checked)
                {

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
    }
}