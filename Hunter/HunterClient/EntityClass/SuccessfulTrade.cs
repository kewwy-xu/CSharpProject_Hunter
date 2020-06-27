using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterClient.EntityClass
{
    public class SuccessfulTrade
    {
        public int SuccessfulTradeId { get; set; }

        //postId和userId都是外键
        public int PostId { get; set; }

        public int UserId { get; set; }

        public DateTime Time { get; set; }
    }
}
