using Business.Abstract;
using Core.Utilites.Result.Abstract;
using Core.Utilites.Result.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EventManager : IEventService
    {
        IEventDal _eventDal;
        public EventManager(IEventDal eventDal)
        {
            _eventDal = eventDal;
        }

        public IResult Add(Event entity)
        {
            try
            {
                _eventDal.Add(entity);
                return new SuccessResult("İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IResult Delete(Event entity)
        {
            try
            {
                _eventDal.Delete(entity);
                return new SuccessResult("İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IDataResult<List<Event>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Event>>(_eventDal.GetAll(), "İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Event>>(e.Message);
            }
        }

        public IDataResult<Event> GetById(int id)
        {
            try
            {
                return new SuccessDataResult<Event>(_eventDal.Get(e=>e.Id == id), "İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<Event>(e.Message);
            }
        }

        public IDataResult<Event> GetSingleObjectByName(string name)
        {
            try
            {
                return new SuccessDataResult<Event>(_eventDal.Get(e => e.EventName == name), "İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorDataResult<Event>(e.Message);
            }
        }

        public IResult Update(Event entity)
        {
            try
            {
                _eventDal.Update(entity);
                return new SuccessResult("İşlem başarılı");
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
