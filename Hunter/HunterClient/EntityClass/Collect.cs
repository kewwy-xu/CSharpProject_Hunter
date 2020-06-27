using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterClient.EntityClass
{
    public class Collect
    {
        public int CollectId { get; set; }

        //postId和userId都是外键
        public int PostId { get; set; }

        public int UserId { get; set; }

        public DateTime Time { get; set; }

        

        public Collect(int postId, int userId, DateTime time)
        {
            PostId = postId;
            UserId = userId;
            Time = time;
        }
    }
}
