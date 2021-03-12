using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfScheduleDal : EfEntityRepository<Schedule, DailyScheduleContext>, IScheduleDal
    {
        public List<ScheduleDTO> GetDetails()
        {
            using (DailyScheduleContext context = new DailyScheduleContext())
            {
                var result = from s in context.Schedules
                       join e in context.Events
                       on s.EventId equals e.Id
                       select new ScheduleDTO
                       {
                           Id = s.Id,
                           Date = s.Date,
                           EventName = e.EventName,
                           Success = s.EventStatus
                       };
                return result.ToList();
            }
        }
    }
}
