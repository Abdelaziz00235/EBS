﻿using EBS.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBS.DataAccess.Abstract
{

    public interface IRequestPurchaseOrExecutionWorkRepository : IRepository<RequestPurchaseOrExecutionWork>
    {
        List<RequestPurchaseOrExecutionWork> GetRequestPurchaseOrExecutionWorkAll();
        List<RequestPurchaseOrExecutionWork> GetPurchaseOrExecutionWorkCreatedByEmployee(int id);
        List<RequestPurchaseOrExecutionWork> GetPurchaseOrExecutionWorkValidatedByIdEmployee(int id);

        


    }
}
