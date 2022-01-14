using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using RSDCharts.Domain;

namespace RSDCharts.DAL
{
    public class dalViews
    {
        public static List<clsViews> FetchList()
        {
            var sql = "SELECT * FROM YoutubeViews";
            using (var con = ConnectionUtil.GetConnection())
            {
                return con.Query<clsViews>(sql).ToList();
            }
        }
    }
}