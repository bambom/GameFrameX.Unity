
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
    public sealed partial class DemoD2 : test.DemoDynamic
    {
        public DemoD2(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["x2"].IsNumber) { throw new SerializationException(); }  X2 = _buf["x2"]; }
            PostInit();
        }

        public static DemoD2 DeserializeDemoD2(JSONNode _buf)
        {
            return new test.DemoD2(_buf);
        }

        public readonly int X2;
        public const int __ID__ = -2138341747;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
        }

        public override string ToString()
        {
            return "{ "
            + "x1:" + X1 + ","
            + "x2:" + X2 + ","
            + "}";
        }

        partial void PostInit();
    }
}
