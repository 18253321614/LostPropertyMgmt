/**  版本信息模板在安装目录下，可自行修改。
* shiwuInfo.cs
*
* 功 能： N/A
* 类 名： shiwuInfo
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
	/// shiwuInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class shiwuInfo
	{
		public shiwuInfo()
		{}
		#region Model
		private int _id;
		private string _itemname;
		private string _iteminfo;
		private string _itemimg;
		private int? _username;
		private DateTime? _time;
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
		public string itemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemInfo
		{
			set{ _iteminfo=value;}
			get{return _iteminfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemImg
		{
			set{ _itemimg=value;}
			get{return _itemimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? userName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? time
		{
			set{ _time=value;}
			get{return _time;}
		}
		#endregion Model

	}
}

