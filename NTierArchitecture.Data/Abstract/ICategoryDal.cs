﻿using NTierArchitecture.Core.Data;
using NTierArchitecture.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Data.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
    }
}
