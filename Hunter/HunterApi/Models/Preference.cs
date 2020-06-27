using HunterApi.Common;
using System;


namespace HunterApi.Models
{
    public class Preference
    {
        public int PreferenceId { get; set; }
        
        public int UserId { get; set; }

        public ItemTypes ItemType { get; set; }   

        public Preference()
        {
        }
    }
   
}
