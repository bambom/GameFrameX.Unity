
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
    public sealed partial class CompositeJsonTable3 : LuBan.Runtime.BeanBase
    {
        public CompositeJsonTable3(JSONNode _buf)
        {
            { if(!_buf["a"].IsNumber) { throw new SerializationException(); }  A = _buf["a"]; }
            { if(!_buf["b"].IsNumber) { throw new SerializationException(); }  B = _buf["b"]; }
            PostInit();
        }

        public static CompositeJsonTable3 DeserializeCompositeJsonTable3(JSONNode _buf)
        {
            return new test.CompositeJsonTable3(_buf);
        }

        public readonly int A;
        public readonly int B;
        public const int __ID__ = 1566207896;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "a:" + A + ","
            + "b:" + B + ","
            + "}";
        }

        partial void PostInit();
    }
}
