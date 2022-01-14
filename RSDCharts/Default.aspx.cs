using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RSDCharts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = DAL.dalViews.FetchList();

            if (list.Count > 0)
            {
                var chartData = "";
                var views = "";
                var labels = "";

                chartData += "<script>";

                foreach (var item in list)
                {
                    views += item.TotalViews + ",";
                    labels += "\"" + item.ViewsMonth + "\",";
                }

                views = views.Substring(0, views.Length - 1);
                labels = labels.Substring(0, labels.Length - 1);

                chartData += " chartLabels = [" + labels + "]; chartData = [" + views + "];";
                chartData += "</script>";
                ltChartData.Text = chartData;
            }
        }
    }
}