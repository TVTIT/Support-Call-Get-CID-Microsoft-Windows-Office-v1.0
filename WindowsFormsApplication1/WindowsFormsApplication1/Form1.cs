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
                if (radioButton6.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /ato\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /dti>id.txt\r\nstart id.txt\r\n\r\nOffice:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /ato\r\n\r\nOffice:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /dti>id.txt\r\nstart id.txt\r\n\r\nOffice:\r\nfor %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                        }
                    }
                }


                if (radioButton5.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "cscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /ato\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /dti>id.txt\r\nstart id.txt";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /ato";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "Windows:\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs\" /ipk " + textBox9.Text + "\r\ncscript //nologo \"%windir%\\system32\\slmgr.vbs /dti>id.txt\r\nstart id.txt";
                        }
                    }
                }


                if (radioButton4.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "for %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "for %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "for %v in (4,5,6) do (if exist \"%ProgramFiles%\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office1%v\") & if exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office1%v\"))\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                        }
                    }
                }


                if (radioButton3.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office16)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office16\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                        }
                    }
                }


                if (radioButton2.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office15)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                        }
                    }
                }
                if (radioButton1.Checked)
                {
                    if (checkBox1.Checked && checkBox2.Checked)
                    {
                        textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office15\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "cscript //nologo OSPP.vbs /act";
                        }
                        if (checkBox2.Checked)
                        {
                            textBox12.Text = "if exist \"%ProgramFiles%\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles%\\Microsoft Office\\Office14)\"\r\nif exist \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\\ospp.vbs\" (cd /d \"%ProgramFiles% (x86)\\Microsoft Office\\Office14\")\r\ncscript //nologo OSPP.vbs /inpkey:" + textBox9.Text + "\r\ncscript OSPP.vbs /dinstid>id.txt\r\nstart id.txt";
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
    }
}