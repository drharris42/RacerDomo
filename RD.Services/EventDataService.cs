using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.Repositories;
using RD.Entities;

namespace RD.Services
{
    public class EventDataService
    {
        public FEvent GetAllEvents()
        {
            return new FEvent();
        }

        public FEvent SaveEvent(FEvent fEvent)
        {
            var eventRepository = new EventRepository();
            eventRepository.SaveEvent(fEvent);
            return null;
        }

    }
}
