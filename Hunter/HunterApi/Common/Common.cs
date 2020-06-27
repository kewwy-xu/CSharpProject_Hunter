using System;


namespace HunterApi.Common
{
    public enum ItemTypes
    {
        数码产品, 家用电器, 运动户外, 衣帽鞋伞,
        书籍教材, 游戏装备, 健身器材, 日常用品, 
        乐器, 代写代做代跑, 其他
    }

    public enum PostTypes { 出售, 求购 }

    public enum States { 待交易, 交易中, 交易成功 }
}
