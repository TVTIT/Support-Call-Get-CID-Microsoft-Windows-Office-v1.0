
// ____                __             __      __                          _____           __  __  ____    ____    ______        _____             
// /\  _`\             /\ \           /\ \    /\ \                        /\  __`\        /\ \/\ \/\  _`\ /\  _`\ /\__  _\      /\  __`\           
// \ \ \/\_\    ___    \_\ \     __   \_\ \   \ \ \____  __  __        ___\ \ \/\ \    ___\ \ \_\ \ \ \L\ \ \ \/\ \/_/\ \/   ___\ \ \/\ \    ___   
// \ \ \/_/_  / __`\  /'_` \  /'__`\ /'_` \   \ \ '__`\/\ \/\ \      / __`\ \ \ \ \  / __`\ \  _  \ \ ,__/\ \ \ \ \ \ \ \  / __`\ \ \ \ \  / __`\ 
// \ \ \L\ \/\ \L\ \/\ \L\ \/\  __//\ \L\ \   \ \ \L\ \ \ \_\ \    /\ \L\ \ \ \_\ \/\ \L\ \ \ \ \ \ \ \/  \ \ \_\ \ \ \ \/\ \L\ \ \ \_\ \/\ \L\ \
// \ \____/\ \____/\ \___,_\ \____\ \___,_\   \ \_,__/\/`____ \   \ \____/\ \_____\ \____/\ \_\ \_\ \_\   \ \____/  \ \_\ \____/\ \_____\ \____/
// \/___/  \/___/  \/__,_ /\/____/\/__,_ /    \/___/  `/___/> \   \/___/  \/_____/\/___/  \/_/\/_/\/_/    \/___/    \/_/\/___/  \/_____/\/___/ 
// /\___/                                                                                
// \/__/                                                                                 
// 
// Project: Windows7Activator
// ===== Code info ======================
// > File name     : Updater.vb
// > File path     : C:\Users\oOoHPDToOo\source\repos\Windows7Activator\Classes\Updater.vb
// > Date created  : 9/11/2018, 12:55 AM
// > Date modified : 3/12/2018, 05:17 PM
// ======================================
// Copyright (c) 2018 - 2018 oOoHPDToOo
// 
//using System.Drawing;
//using System.Data;
//using System.Diagnostics;
//using System.Windows.Forms;
//using Microsoft.VisualBasic;
//using System.Collections.Generic;
//using System.Collections;
//using System;
//using System.Net;
//using fastJSON;

//namespace W7Act
//{
//    public class Updater
//    {
//        private readonly string _svr = "http://tools.truonghuynhit.com/W7Act/UpdateCheck/";
//        private string _json = "";

//        public void Check(bool noUpdateNotify = false)
//        {
//            try
//            {
//                _json = new WebClient().DownloadString(_svr);

//                var jo = JSON.Parse(_json);

//                Version chkVer = new Version(jo("Version").ToString());
//                Version myVer = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

//                if (chkVer > myVer)
//                {
//                    using (frmUpdate f = new frmUpdate(myVer.ToString(), chkVer.ToString(), GetChangelog, jo("Link").ToString()))
//                    {
//                        if (f.ShowDialog() == DialogResult.Yes)
//                            Process.Start(jo("Link").ToString());
//                    }
//                }
//                else if (!noUpdateNotify)
//                    Interaction.MsgBox("No update found :D", MsgBoxStyle.Information, "Latest version");
//            }
//            catch (Exception ex)
//            {
//                Interaction.MsgBox("Error when checking for new version" + Constants.vbCrLf + "> Reason: " + ex.Message, MsgBoxStyle.Critical, "Error");
//            }
//        }

//        public string GetChangelog(bool RefreshNew = false)
//        {
//            try
//            {
//                object jo = null;
//                if (_json != "")
//                {
//                    if (RefreshNew)
//                        _json = new WebClient().DownloadString(_svr);
//                }
//                else
//                    _json = new WebClient().DownloadString(_svr);
//                jo = JSON.Parse(_json);

//                Dictionary<string, List<string>> dict = JSON.ToObject<Dictionary<string, List<string>>>(JSON.ToJSON(jo("Changelog")));

//                string str = "";
//                foreach (KeyValuePair<string, List<string>> v in dict)
//                {
//                    str += "> " + v.Key + Constants.vbCrLf;
//                    foreach (var c in v.Value)
//                        str += "+ " + c.ToString() + Constants.vbCrLf;
//                    str += Constants.vbCrLf;
//                }
//                return str.TrimEnd();
//            }
//            catch (Exception ex)
//            {
//            }

//            return null;
//        }
//    }
//}