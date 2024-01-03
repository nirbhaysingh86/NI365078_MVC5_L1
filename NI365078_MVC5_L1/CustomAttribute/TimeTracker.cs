using System;
 
namespace NI365078_MVC5_L1.CustomAttribute
{
     
    public class TimeTrackerAttribute : Attribute
    {
        public string TimeTracker { get; set; }
    }
}