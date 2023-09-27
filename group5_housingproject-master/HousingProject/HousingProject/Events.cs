using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingProject
{
    class Events
    {
        private EventsType eventType;
        private string date;
        private string description;

        public Events(EventsType eventType, string date, string description)
        {
            this.eventType = eventType;
            this.date = date;
            this.description = description;
        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public EventsType event_Type
        {
            get { return this.eventType; }

            set
            {
                if (Enum.IsDefined(typeof(EventsType), value))
                {
                    this.eventType = value;
                }
            }
        }

        public string getDetails()
        {
            return $"Event: {eventType}, Due: {date}, Description: {description}.";
        }
    }
}
