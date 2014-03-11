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
            var testEvent = new Event();
            testEvent.DateStart = DateTime.UtcNow;
            testEvent.City = "Denver";
            testEvent.Country = "USA";
            testEvent.State = "CO";
            testEvent.Id = Guid.NewGuid();

            var context = new RDDatabaseEntitiesDataContext();
            context.Events.InsertOnSubmit(testEvent);
            context.SubmitChanges();
            return TranslateDBEntityToFrontEndEntity(testEvent);
        }

        private FEvent TranslateDBEntityToFrontEndEntity(Event dbEvent)
        {
            return new FEvent();
        }
    }
}
