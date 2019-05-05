using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Xivid.UtilModule
{
    /// <summary>
    /// Have any questions? Call Anny !
    /// 有问题, 找安妮
    /// </summary>
    public partial class Anny
    {
        public static string ToXml<T>(T obj)
        {
			MemoryStream Stream = new MemoryStream();
            XmlSerializerNamespaces _name = new XmlSerializerNamespaces();
            _name.Add("", "");//这样就 去掉 attribute 里面的 xmlns:xsi 和 xmlns:xsd
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Encoding = new UTF8Encoding(false);//设置编码,不能用Encoding.UTF8,会导致带有BOM标记 
            xmlWriterSettings.Indent = true;//设置自动缩进
                                            //xmlWriterSettings.OmitXmlDeclaration = true;//删除XmlDeclaration：<?xml version="1.0" encoding="utf-16"?>
                                            //xmlWriterSettings.NewLineChars = "\r\n";
                                            //xmlWriterSettings.NewLineHandling = NewLineHandling.None;
            XmlSerializer xml = new XmlSerializer(obj.GetType());
            try
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(Stream, xmlWriterSettings))
                {
                    //序列化对象
                    xml.Serialize(xmlWriter, obj, _name);
                }
            }
            catch (InvalidOperationException ex)
            {
            }
            return Encoding.UTF8.GetString(Stream.ToArray()).Trim();
        }

        public static T FromXml<T>(string xmlString)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            try
            {
                using (TextReader tr = new StringReader(xmlString))
                {
                    return (T)ser.Deserialize(tr);
                }
            }
            catch (Exception)
            {
            }
            return default(T);
        }

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        static IntPtr notepadHandle;
        /// <summary>
        /// 打开notepad 并显示以下Text
        /// </summary>
        /// <param name="Text"></param>
        static public void OpenNotepadAndShow(string Text)
        {

            ////PREPARING...
            //Process notepad = new Process();
            //notepad.StartInfo.FileName = "notepad.exe";
            //notepad.Start();
            //notepad.WaitForInputIdle();
            //notepadHandle = notepad.MainWindowHandle;
            ////YOUR CODE GOES HERE

            ////Example:
            //SetForegroundWindow(notepadHandle); //Make sure Notepad is the top window
            //System.Windows.Forms.SendKeys.SendWait(Text); //And send a keystroke

            //waitABitLonger();
            //notepad.Kill();
        }

		//选择保存路径
		public static string ShowSaveFileDialog()
		{
			string localFilePath = "";
			//string localFilePath, fileNameExt, newFileName, FilePath; 
			SaveFileDialog sfd = new SaveFileDialog();
			//设置文件类型 
			sfd.Filter = "Excel表格（*.csv）|*.csv";

			//设置默认文件类型显示顺序 
			sfd.FilterIndex = 1;
			sfd.RestoreDirectory = true;
			sfd.FileName = "NannSpider_"+ DateTime.Now.ToString("yyyyMMddhhmmss")+".csv";
			//点了保存按钮进入 
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				localFilePath = sfd.FileName.ToString(); //获得文件路径 
				string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

				//获取文件路径，不带文件名 
				var FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));

			}
			return localFilePath;
		} 

        /// <summary>
        /// @Author:      HTL
        /// @Email:       Huangyuan413026@163.com
        /// @DateTime:    2015-06-03 19:54:49
        /// @Description: 获取当前堆栈的上级调用方法列表,直到最终调用者,只会返回调用的各方法,而不会返回具体的出错行数，可参考：微软真是个十足的混蛋啊！让我们跟踪Exception到行把！（不明真相群众请入） 
        /// </summary>
        /// <returns></returns>
        static public string GetStackTraceModelName()
        {
            //当前堆栈信息
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace();
            System.Diagnostics.StackFrame[] sfs = st.GetFrames();
            //过虑的方法名称,以下方法将不会出现在返回的方法调用列表中
            string _filterdName = "ResponseWrite,ResponseWriteError,";
            string _fullName = string.Empty, _methodName = string.Empty;
            for (int i = 1; i < sfs.Length; ++i)
            {
                //非用户代码,系统方法及后面的都是系统调用，不获取用户代码调用结束
                if (System.Diagnostics.StackFrame.OFFSET_UNKNOWN == sfs[i].GetILOffset()) break;
                _methodName = sfs[i].GetMethod().Name;//方法名称
                                                      //sfs[i].GetFileLineNumber();//没有PDB文件的情况下将始终返回0
                if (_filterdName.Contains(_methodName)) continue;
                _fullName = _methodName + "()-" + _fullName;
            }
            st = null;
            sfs = null;
            _filterdName = _methodName = null;
            return _fullName.TrimEnd('-');
        }

		public static string LoadFile(string path)
		{
			try
			{
				using(StreamReader srReadFile = new StreamReader(path))
				{
					// 写入文件的源路径及其写入流
					// 读取流直至文件末尾结束，并逐行写入另一文件内
					string content = srReadFile.ReadToEnd(); //读取每行数据
															 // 关闭流文件
					srReadFile.Close();
					return content;
					;
				}

			}
			catch(DirectoryNotFoundException ex)
			{
				// 没有旧存档
			}
			catch(Exception ex)
			{

			}
			return "";
		}

		public static void SaveToFile(string content, string path)
		{
			//保存文件到本地
			try
			{
				// 写入文件的源路径及其写入流
				using ( Stream _fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write ))
				using(StreamWriter swWriteFile = new StreamWriter(_fileStream, Encoding.Unicode))
				{
					swWriteFile.Write(content); //写入读取的每行数据
					swWriteFile.Close();        // 关闭流文件
				}
			}
			catch(Exception ex)
			{
				Debug.WriteLine(string.Format("写入文件出错：消息={0},堆栈={1}", ex.Message, ex.StackTrace));
			}
		}
	}
}
