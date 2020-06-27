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
using HunterClient.Common;
using Microsoft.AspNetCore.Http;

namespace HunterClient.EntityClass
{
    public class Post 
    {
        //形式为“类名+Id”时，再加注解【key】或【foreignkey】，会报错

        public int PostId { set; get; }
       
        public int UserId { set; get; }
        
        public string Title { set; get; }

        public string BriefDescription { set; get; }

        public Image Image{ set; get; }
        public byte[] imageByte { get; set; }
        public float Price { set; get; }

        public DateTime Time { set; get; }

        //类型分区
        public ItemTypes Type  { set; get; }
        //帖子类型
        public PostTypes PostType { get; set; }
        //状态
        public States State { set; get; }

        public List<string> Comments { set; get; }

        public Collect Collect
        {
            get => default;
            set
            {
            }
        }

        public Comment Comment
        {
            get => default;
            set
            {
            }
        }

        public Services.ManagePostsServices ManagePostsServices
        {
            get => default;
            set
            {
            }
        }

        public Services.PostServices PostServices
        {
            get => default;
            set
            {
            }
        }

        public Post(float price)
        {
            this.Price = price;

        }

        public Post() { }

        public Post(int userId, string title, string briefDescription, 
             float price, DateTime time, ItemTypes type,
            PostTypes postType, States state,byte[]image)
        {
            UserId = userId;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            BriefDescription = briefDescription ?? throw new ArgumentNullException(nameof(briefDescription));
            Price = price;
            Time = time;
            Type = type;
            PostType = postType;
            State = state;
            imageByte = image;
        }
      
    }
}
