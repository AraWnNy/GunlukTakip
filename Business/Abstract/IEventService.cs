using Core.Utilites.Result.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEventService
    {
        IResult Add(Event entity);
        IResult Delete(Event entity);
        IResult Update(Event entity);
        IDataResult<List<Event>> GetAll();
        IDataResult<Event> GetById(int id);
        IDataResult<Event> GetSingleObjectByName(string name);
    }
}
