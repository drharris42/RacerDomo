using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RD.Entities;
using RD.Repositories.Data;

namespace RD.Repositories
{
    public class EventRepository
    {
        public FEvent SaveEvent(FEvent newEvent){
            var eventToSave = TranslateFrontEndEntityToDBEntity(newEvent);

            var context = new RDDatabaseEntitiesDataContext();
            context.Events.InsertOnSubmit(eventToSave);
            context.SubmitChanges();
            return newEvent;
        }

        private FEvent TranslateDBEntityToFrontEndEntity(Event dbEvent)
        {
            return new FEvent();
        }

        private Event TranslateFrontEndEntityToDBEntity(FEvent fEvent){
            var newEvent = new Event();
            newEvent.DateStart = fEvent.DateStart;
            newEvent.City = fEvent.Location.City;
            newEvent.Country = fEvent.Location.Country;
            newEvent.State = fEvent.Location.State;
            newEvent.Id = fEvent.Id;
            newEvent.UserId = fEvent.UserId;
            return newEvent;
        }
    }
}
