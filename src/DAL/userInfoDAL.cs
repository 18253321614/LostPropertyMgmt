/**  版本信息模板在安装目录下，可自行修改。
* userInfoDAL.cs
*
* 功 能： N/A
* 类 名： userInfoDAL
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
	/// 数据访问类:userInfoDAL
	/// </summary>
	public partial class userInfoDAL
	{
		public userInfoDAL()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "userInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from userInfo");
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
		public int Add(lostPropertyMngt.Model.userInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into userInfo(");
			strSql.Append("userName,headImg,relName,gender,stuNum,college,password,contact)");
			strSql.Append(" values (");
			strSql.Append("@userName,@headImg,@relName,@gender,@stuNum,@college,@password,@contact)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,10),
					new SqlParameter("@headImg", SqlDbType.NVarChar,50),
					new SqlParameter("@relName", SqlDbType.NVarChar,5),
					new SqlParameter("@gender", SqlDbType.NVarChar,2),
					new SqlParameter("@stuNum", SqlDbType.NVarChar,10),
					new SqlParameter("@college", SqlDbType.NVarChar,20),
					new SqlParameter("@password", SqlDbType.VarChar,20),
					new SqlParameter("@contact", SqlDbType.VarChar,11)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.headImg;
			parameters[2].Value = model.relName;
			parameters[3].Value = model.gender;
			parameters[4].Value = model.stuNum;
			parameters[5].Value = model.college;
			parameters[6].Value = model.password;
			parameters[7].Value = model.contact;

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
		public bool Update(lostPropertyMngt.Model.userInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update userInfo set ");
			strSql.Append("userName=@userName,");
			strSql.Append("headImg=@headImg,");
			strSql.Append("relName=@relName,");
			strSql.Append("gender=@gender,");
			strSql.Append("stuNum=@stuNum,");
			strSql.Append("college=@college,");
			strSql.Append("password=@password,");
			strSql.Append("contact=@contact");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,10),
					new SqlParameter("@headImg", SqlDbType.NVarChar,50),
					new SqlParameter("@relName", SqlDbType.NVarChar,5),
					new SqlParameter("@gender", SqlDbType.NVarChar,2),
					new SqlParameter("@stuNum", SqlDbType.NVarChar,10),
					new SqlParameter("@college", SqlDbType.NVarChar,20),
					new SqlParameter("@password", SqlDbType.VarChar,20),
					new SqlParameter("@contact", SqlDbType.VarChar,11),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.userName;
			parameters[1].Value = model.headImg;
			parameters[2].Value = model.relName;
			parameters[3].Value = model.gender;
			parameters[4].Value = model.stuNum;
			parameters[5].Value = model.college;
			parameters[6].Value = model.password;
			parameters[7].Value = model.contact;
			parameters[8].Value = model.ID;

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
			strSql.Append("delete from userInfo ");
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
			strSql.Append("delete from userInfo ");
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
		public lostPropertyMngt.Model.userInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,userName,headImg,relName,gender,stuNum,college,password,contact from userInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			lostPropertyMngt.Model.userInfo model=new lostPropertyMngt.Model.userInfo();
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
		public lostPropertyMngt.Model.userInfo DataRowToModel(DataRow row)
		{
			lostPropertyMngt.Model.userInfo model=new lostPropertyMngt.Model.userInfo();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["userName"]!=null)
				{
					model.userName=row["userName"].ToString();
				}
				if(row["headImg"]!=null)
				{
					model.headImg=row["headImg"].ToString();
				}
				if(row["relName"]!=null)
				{
					model.relName=row["relName"].ToString();
				}
				if(row["gender"]!=null)
				{
					model.gender=row["gender"].ToString();
				}
				if(row["stuNum"]!=null)
				{
					model.stuNum=row["stuNum"].ToString();
				}
				if(row["college"]!=null)
				{
					model.college=row["college"].ToString();
				}
				if(row["password"]!=null)
				{
					model.password=row["password"].ToString();
				}
				if(row["contact"]!=null)
				{
					model.contact=row["contact"].ToString();
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
			strSql.Append("select ID,userName,headImg,relName,gender,stuNum,college,password,contact ");
			strSql.Append(" FROM userInfo ");
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
			strSql.Append(" ID,userName,headImg,relName,gender,stuNum,college,password,contact ");
			strSql.Append(" FROM userInfo ");
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
			strSql.Append("select count(1) FROM userInfo ");
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
			strSql.Append(")AS Row, T.*  from userInfo T ");
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
			parameters[0].Value = "userInfo";
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

