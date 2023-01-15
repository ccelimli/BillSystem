using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityRepository
{
    public class BillImageDal : EntityRepositoryBase<BillImage, BillSystemContext>, IBillImageDal
    {
    }
}
