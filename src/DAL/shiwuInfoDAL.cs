/**  版本信息模板在安装目录下，可自行修改。
* shiwuInfoDAL.cs
*
* 功 能： N/A
* 类 名： shiwuInfoDAL
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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace lostPropertyMngt.DAL
{
	/// <summary>
	/// 数据访问类:shiwuInfoDAL
	/// </summary>
	public partial class shiwuInfoDAL
	{
		public shiwuInfoDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "shiwuInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from shiwuInfo");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(lostPropertyMngt.Model.shiwuInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into shiwuInfo(");
			strSql.Append("itemName,itemInfo,itemImg,userName,time)");
			strSql.Append(" values (");
			strSql.Append("@itemName,@itemInfo,@itemImg,@userName,@time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@itemName", SqlDbType.NVarChar,20),
					new SqlParameter("@itemInfo", SqlDbType.NVarChar,-1),
					new SqlParameter("@itemImg", SqlDbType.NVarChar,50),
					new SqlParameter("@userName", SqlDbType.Int,4),
					new SqlParameter("@time", SqlDbType.Time,5)};
			parameters[0].Value = model.itemName;
			parameters[1].Value = model.itemInfo;
			parameters[2].Value = model.itemImg;
			parameters[3].Value = model.userName;
			parameters[4].Value = model.time;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(lostPropertyMngt.Model.shiwuInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update shiwuInfo set ");
			strSql.Append("itemName=@itemName,");
			strSql.Append("itemInfo=@itemInfo,");
			strSql.Append("itemImg=@itemImg,");
			strSql.Append("userName=@userName,");
			strSql.Append("time=@time");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@itemName", SqlDbType.NVarChar,20),
					new SqlParameter("@itemInfo", SqlDbType.NVarChar,-1),
					new SqlParameter("@itemImg", SqlDbType.NVarChar,50),
					new SqlParameter("@userName", SqlDbType.Int,4),
					new SqlParameter("@time", SqlDbType.Time,5),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.itemName;
			parameters[1].Value = model.itemInfo;
			parameters[2].Value = model.itemImg;
			parameters[3].Value = model.userName;
			parameters[4].Value = model.time;
			parameters[5].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shiwuInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from shiwuInfo ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public lostPropertyMngt.Model.shiwuInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,itemName,itemInfo,itemImg,userName,time from shiwuInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			lostPropertyMngt.Model.shiwuInfo model=new lostPropertyMngt.Model.shiwuInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public lostPropertyMngt.Model.shiwuInfo DataRowToModel(DataRow row)
		{
			lostPropertyMngt.Model.shiwuInfo model=new lostPropertyMngt.Model.shiwuInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["itemName"]!=null)
				{
					model.itemName=row["itemName"].ToString();
				}
				if(row["itemInfo"]!=null)
				{
					model.itemInfo=row["itemInfo"].ToString();
				}
				if(row["itemImg"]!=null)
				{
					model.itemImg=row["itemImg"].ToString();
				}
				if(row["userName"]!=null && row["userName"].ToString()!="")
				{
					model.userName=int.Parse(row["userName"].ToString());
				}
				if(row["time"]!=null && row["time"].ToString()!="")
				{
					model.time=DateTime.Parse(row["time"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,itemName,itemInfo,itemImg,userName,time ");
			strSql.Append(" FROM shiwuInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,itemName,itemInfo,itemImg,userName,time ");
			strSql.Append(" FROM shiwuInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM shiwuInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from shiwuInfo T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "shiwuInfo";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

