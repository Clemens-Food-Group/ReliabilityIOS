using System;
namespace com.clemensfoods.attendance.Models
{
    public class AttendanceModel
    {
        public string TM_Number { get; set; }
        public string TM_Name { get; set; }
        public string TM_DepartmentName { get; set; }
        public string Plant { get; set; }
        public DateTime AttendanceEventDate { get; set; }
        public string AttendanceEventType { get; set; }
        public string RelativityStatus_CurrentMonth { get; set; }
        public string TimeCardID { get; set; }
    }
}
