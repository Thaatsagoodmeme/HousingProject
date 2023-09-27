using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingProject
{
    class EventTracker
    {
        private List<Events> eventsList;

        public EventTracker()
        {
            eventsList = new List<Events>();
        }

        private bool Check_Index(int index)
        {
            bool selected = false;

            if (index >= 0)
            {
                selected = true;
            }

            return selected;
        }

        public void addEvent(Events events)
        {
            eventsList.Add(events);
        }

        public void deleteEvent(int index)
        {
            if (Check_Index(index))
            {
                eventsList.RemoveAt(index);
            }
        }

        public string getEventInfo(int index)
        {
            string info;

            if (Check_Index(index))
            {
                info = eventsList[index].getDetails();
                return info;
            }
            else
                info = "Error";
            return info;
        }

    }
}
