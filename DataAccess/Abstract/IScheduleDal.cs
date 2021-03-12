using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entity.Concrete;
using Entity.DTOs;

namespace DataAccess.Abstract
{
    public interface IScheduleDal : IEntityRepositoryBase<Schedule>
    {
        List<ScheduleDTO> GetDetails();
    }
}
