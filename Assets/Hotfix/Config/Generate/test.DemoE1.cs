
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
    public sealed partial class DemoE1 : test.DemoD3
    {
        public DemoE1(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["x4"].IsNumber) { throw new SerializationException(); }  X4 = _buf["x4"]; }
            PostInit();
        }

        public static DemoE1 DeserializeDemoE1(JSONNode _buf)
        {
            return new test.DemoE1(_buf);
        }

        public readonly int X4;
        public const int __ID__ = -2138341717;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
        }

        public override string ToString()
        {
            return "{ "
            + "x1:" + X1 + ","
            + "x3:" + X3 + ","
            + "x4:" + X4 + ","
            + "}";
        }

        partial void PostInit();
    }
}
