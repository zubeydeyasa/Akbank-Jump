using MeetingApp.Abstract;
using MeetingApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.Entities
{
    internal class Meeting : Event, INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
                Console.WriteLine($"Davetli kişiler: {guest}");
        }
    }
}
