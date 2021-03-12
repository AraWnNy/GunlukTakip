using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entity.Concrete
{
    public class Schedule : IEntity
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public DateTime Date { get; set; }
        public bool EventStatus { get; set; }
    }
}
