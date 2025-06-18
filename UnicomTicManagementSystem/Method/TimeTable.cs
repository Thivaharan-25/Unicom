using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicManagementSystem.Method
{
    public class TimeTable
    {
        public int Id { get; set; }
        public int HallNo { get; set; }
        public string DateOfWeek { get; set; }
        public string TimeSlot { get; set; }
        public string Course { get; set; }
        public string Subject { get; set; } 
        public string Lecturer { get; set; }
        public string Hall { get;    set; }
        public string RoomType { get; set; }
       
    }

}
