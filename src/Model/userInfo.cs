/**  版本信息模板在安装目录下，可自行修改。
* userInfo.cs
*
* 功 能： N/A
* 类 名： userInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018-09-17 14:37:37   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace lostPropertyMngt.Model
{
	/// <summary>
	/// userInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class userInfo
	{
		public userInfo()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _headimg;
		private string _relname;
		private string _gender;
		private string _stunum;
		private string _college;
		private string _password;
		private string _contact;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string headImg
		{
			set{ _headimg=value;}
			get{return _headimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string relName
		{
			set{ _relname=value;}
			get{return _relname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gender
		{
			set{ _gender=value;}
			get{return _gender;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stuNum
		{
			set{ _stunum=value;}
			get{return _stunum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string college
		{
			set{ _college=value;}
			get{return _college;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		#endregion Model

	}
}

