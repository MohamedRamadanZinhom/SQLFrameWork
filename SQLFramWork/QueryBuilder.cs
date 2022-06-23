using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLFramWork
{
    internal class QueryBuilder
    {

        private string operation;
        private string table;
        private string where;
        private string like;
        private string groupby;
        private string having;
        private string orderby;


        public QueryBuilder Operation(string op)
        {
            this.operation = op;
            return this;
        }


        public QueryBuilder Table(string tablename)
        {
            this.table = "FROM " + tablename;
            return this;
        }


        public QueryBuilder Where(string condition)
        {
            this.where = "WHERE " + condition;
            return this;
        }


        public QueryBuilder Like(string likecondition)
        {
            this.like = "LIKE  " + likecondition;
            return this;
        }

        public QueryBuilder GroupBy(string g)
        {
            this.groupby = "GROUP BY " + g;
            return this;
        }


        public QueryBuilder Having(string h)
        {
            this.having ="Having "+ h;
            return this;
        }


        public QueryBuilder OrderdBy(string o)
        {
            this.orderby = "Order By "+o;
            return this;
        }

        public Query Build()
        {
            return new Query(this.operation,this.table,this.where,this.like,this.groupby,this.having,this.orderby);
        }




    }
}
