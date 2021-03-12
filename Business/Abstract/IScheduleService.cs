using Core.Utilites.Result.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IScheduleService
    {
        IResult Add(Schedule entity);
        IResult Delete(Schedule entity);
        IResult Update(Schedule entity);
        IDataResult<List<Schedule>> GetAll();
        IDataResult<Schedule> GetById(int id);
        IDataResult<List<ScheduleDTO>> GetDetails();
    }
}
