using Business.Abstract;
using Core.Utilites.Result.Abstract;
using Core.Utilites.Result.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ScheduleManager : IScheduleService
    {
        IScheduleDal _scheduleDal;
        public ScheduleManager(IScheduleDal scheduleDal)
        {
            _scheduleDal = scheduleDal;
        }
        public IResult Add(Schedule entity)
        {
            try
            {
                _scheduleDal.Add(entity);
                return new SuccessResult("İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IResult Delete(Schedule entity)
        {
            try
            {
                _scheduleDal.Delete(entity);
                return new SuccessResult("İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<Schedule>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Schedule>>(_scheduleDal.GetAll(), "İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Schedule>>(e.Message);
            }
        }

        public IDataResult<Schedule> GetById(int id)
        {
            try
            {
                return new SuccessDataResult<Schedule>(_scheduleDal.Get(s=>s.Id == id), "İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<Schedule>(e.Message);
            }
        }

        public IDataResult<List<ScheduleDTO>> GetDetails()
        {
            try
            {
                return new SuccessDataResult<List<ScheduleDTO>>(_scheduleDal.GetDetails(), "İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<ScheduleDTO>>(e.Message);
            }
        }

        public IResult Update(Schedule entity)
        {
            try
            {
                _scheduleDal.Update(entity);
                return new SuccessResult("İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
