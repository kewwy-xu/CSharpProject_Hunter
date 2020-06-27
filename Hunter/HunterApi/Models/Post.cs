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
using HunterApi.Common;
using Microsoft.AspNetCore.Http;
using System.Reflection.Metadata;

namespace HunterApi.Models
{
    public class Post : IComparable<Post>
    {
        //形式为“类名+Id”时，再加注解【key】或【foreignkey】，会报错

        public int PostId { set; get; }
       
        public int UserId { set; get; }
        
        public string Title { set; get; }

        public string BriefDescription { set; get; }
        
        public byte[] ImageByte{ set; get; }

        public float Price { set; get; }

        public DateTime Time { set; get; }

        //类型分区
        
        public ItemTypes Type { set; get; }
        //帖子类型
        
        public PostTypes PostType { get; set; }
        
        public enum States { }//状态
        
        public States State { set; get; }
        
       // public List<string> Comments { set; get; }
       
        public Post()
        {

        }

        public override bool Equals(object obj)
        {
            var order = obj as Post;
            return order != null &&
                   PostId == order.PostId;
        }
        /*
        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"PostId:{PostId}, UserId:{UserId},Title:{Title},Type:{Type}," +
                $"Label:{Label},Time:{Time},BrefDescription：{BriefDescription},State:{State}");
            return strBuilder.ToString();
        }
        */
    
        public int CompareTo(Post other)
        {
            if (other == null) return 1;
            return this.PostId.CompareTo(other.PostId);
        }
        
    }
}
