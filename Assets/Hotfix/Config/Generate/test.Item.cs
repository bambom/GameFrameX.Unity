
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LuBan.Runtime;
using GameFrameX.Config;
using SimpleJSON;

namespace Hotfix.Config.test
{
    public sealed partial class Item : test.ItemBase
    {
        public Item(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["num"].IsNumber) { throw new SerializationException(); }  Num = _buf["num"]; }
            { if(!_buf["price"].IsNumber) { throw new SerializationException(); }  Price = _buf["price"]; }
            PostInit();
        }

        public static Item DeserializeItem(JSONNode _buf)
        {
            return new test.Item(_buf);
        }

        public readonly int Num;
        public readonly int Price;
        public const int __ID__ = -1226641649;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "desc:" + Desc + ","
            + "num:" + Num + ","
            + "price:" + Price + ","
            + "}";
        }

        partial void PostInit();
    }
}
