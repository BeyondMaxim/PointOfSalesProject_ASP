﻿using POS.BLL.BaseManager;
using POS.Models.EntityModel;
using POS.Repository.Base;
using POS.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BLL.ManagerRepositories
{
    public class ItemCategoryManager : Manager<ItemCategory>
    {
        public ItemCategoryManager() : base(new ItemCategoryRepository())
        {
        }
    }
}
