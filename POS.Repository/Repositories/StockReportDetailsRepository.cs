﻿using POS.Models.EntityModel;
using POS.Repository.Base;
using POS.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository.Repositories
{
    public class StockReportDetailsRepository : Repository<StockReportDetails>
    {
        public StockReportDetailsRepository() : base(new PosManagementDbContext())
        {

        }
    }
}
