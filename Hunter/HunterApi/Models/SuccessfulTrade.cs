using System;


namespace HunterApi.Models
{
    public class SuccessfulTrade
    {
        public int SuccessfulTradeId { get; set; }

        //postId和userId都是外键
        public int PostId { get; set; }

        public int UserId { get; set; }

        public DateTime Time { get; set; }

        public SuccessfulTrade()
        {
        }
    }
}
