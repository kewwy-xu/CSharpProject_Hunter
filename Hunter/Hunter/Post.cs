using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Hunter
{
    class Post : IComparable<Post>
    {
        //形式为“类名+Id”时，再加注解【key】或【foreignkey】，会报错

        public string PostId { set; get; }
       
        public string UserId { set; get; }
        
        public string Title { set; get; }

        public string BriefDescription { set; get; }

        public List<string> Images{ set; get; }

        public float Price { set; get; }

        public string Label { set; get; }

        public DateTime Time { set; get; }

        public enum Types { } //类型分区

        public  Types Type  { set; get; }

        public enum States { }//状态

        public States State { set; get; }

        public List<string> Comments { set; get; }

        public Post()
        {

        }

        public override bool Equals(object obj)
        {
            var order = obj as Post;
            return order != null &&
                   PostId == order.PostId;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"PostId:{PostId}, UserId:{UserId},Title:{Title},Type:{Type}," +
                $"Label:{Label},Time:{Time},BrefDescription：{BriefDescription},State:{State}");
            return strBuilder.ToString();
        }


        public int CompareTo(Post other)
        {
            if (other == null) return 1;
            return this.PostId.CompareTo(other.PostId);
        }
    }
}
