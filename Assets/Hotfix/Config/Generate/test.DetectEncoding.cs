
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
    public sealed partial class DetectEncoding : LuBan.Runtime.BeanBase
    {
        public DetectEncoding(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            { if(!_buf["name"].IsString) { throw new SerializationException(); }  Name = _buf["name"]; }
            PostInit();
        }

        public static DetectEncoding DeserializeDetectEncoding(JSONNode _buf)
        {
            return new test.DetectEncoding(_buf);
        }

        public readonly int Id;
        public readonly string Name;
        public const int __ID__ = -1154609646;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "}";
        }

        partial void PostInit();
    }
}
