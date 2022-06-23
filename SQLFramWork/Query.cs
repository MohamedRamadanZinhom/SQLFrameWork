using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFramWork
{
    internal class Query
    {
        private string operation;
        private string table;
        private string where;
        private string like;
        private string groupby;
        private string having;
        private string orderby;

        public string QUERY { get; set; }

        public Query(string operation, string table, string where,string like, string groupby, string having, string orderby)
        {
            this.operation = operation;
            this.table = table;
            this.where = where;
            this.groupby = groupby;
            this.having = having;
            this.orderby = orderby;
            this.like = like;

            QUERY= operation+table+where+like+groupby+having+orderby;

        }

   
    }
}
