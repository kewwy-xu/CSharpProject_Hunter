using HunterClient.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter.EntityClass
{
    public class Preference
    {
        public int PreferenceId { get; set; }
        public int UserId { get; set; }
        public ItemTypes ItemType { get; set; }

        public Preference(int userId, ItemTypes itemType)
        {
            UserId = userId;
            ItemType = itemType;
        }
    }

    
}
