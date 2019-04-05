using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEchart
{
    public partial class theSeventhLesson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //如何向数据库中插入数据
            //isleapyear(y)
        }
            private bool isLeapYear(double a)
            {
               double year=double.Parse(txtYear.Text);
               if (year % 4 == 0&&year%100 != 0|| year % 400 == 0)
               {
                   a = 1;
                   bool b = true;
                   Response.Write("是闰年");
                   return b;
               }
               else
               {
                   a = 0;
                   bool b = false;
                   Response.Write("不是闰年");
                   return b;
               }
            }
        protected void btnCheckYear_Click(object sender, EventArgs e)
        {
            try
            {
                double y = double.Parse(txtYear.Text);
                bool c = isLeapYear(y);
            }
            catch
            {
                Response.Write("请输入阿拉伯数字格式的年份");
            }
        }
    }
}