using RecordDealer.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordDealer.DAL.DBInitializers
{
    internal class DBInitializer: CreateDatabaseIfNotExists<RecordDealerEntities>
    {
        protected override void Seed(RecordDealerEntities context)
        {
            base.Seed(context);
        }
    }
}
