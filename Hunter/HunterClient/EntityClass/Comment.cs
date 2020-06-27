using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterClient.EntityClass
{
    public class Comment
    {
        public int CommentId { get; set; }

        //postId和userId都是外键
        public int PostId { get; set; }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string CommentContext { get; set; }

        public DateTime Time { get; set; }

        public Post Post
        {
            get => default;
            set
            {
            }
        }

        public Comment(string Context,int postId,int userId,string userName)
        {          
            CommentContext = Context;
            PostId = postId;
            UserId = userId;
            Time = DateTime.Now;
            UserName = userName;
        }

    }
}
