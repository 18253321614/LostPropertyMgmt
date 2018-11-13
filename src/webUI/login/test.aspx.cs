using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lostPropertyMngt.BLL;

namespace webUI.loginAndRegister
{
    public partial class test : System.Web.UI.Page
    {
        lostPropertyMngt.Model.adminInfo model = new lostPropertyMngt.Model.adminInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string action = Request.QueryString["action"].ToString();
            //    if (action=="register")
            //    {
            //        model.adminName = Request.Form["username"];
            //        model.adminPwd = Request.Form["password"];
            //        lostPropertyMngt.BLL.adminInfoBLL bll = new adminInfoBLL();
            //        if (bll.Add(model)!=0)
            //        {
            //            Response.Write("<script>alert('注册成功')</script>");
            //        }
            //        else
            //        {
            //            Response.Write("<script>alert('注册失败')</script>");
            //        }
            //}
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            model.adminName = TextBox1.Text.ToString().Trim();
            lostPropertyMngt.BLL.adminInfoBLL bLL = new adminInfoBLL();
            if (bLL.Add(model)!=0)
            {
                Response.Write("<script>alert('注册成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('注册失败')</script>");
            }
        }
    }
}