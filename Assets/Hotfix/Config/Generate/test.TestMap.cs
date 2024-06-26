
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
    public sealed partial class TestMap : LuBan.Runtime.BeanBase
    {
        public TestMap(JSONNode _buf)
        {
            { if(!_buf["id"].IsNumber) { throw new SerializationException(); }  Id = _buf["id"]; }
            Id_Ref = null;
            { var __json0 = _buf["x1"]; if(!__json0.IsArray) { throw new SerializationException(); } X1 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  X1.Add(_k0, _v0); }   }
            { var __json0 = _buf["x2"]; if(!__json0.IsArray) { throw new SerializationException(); } X2 = new System.Collections.Generic.Dictionary<long, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { long _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  X2.Add(_k0, _v0); }   }
            { var __json0 = _buf["x3"]; if(!__json0.IsArray) { throw new SerializationException(); } X3 = new System.Collections.Generic.Dictionary<string, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { string _k0;  { if(!__e0[0].IsString) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  X3.Add(_k0, _v0); }   }
            { var __json0 = _buf["x4"]; if(!__json0.IsArray) { throw new SerializationException(); } X4 = new System.Collections.Generic.Dictionary<test.DemoEnum, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { test.DemoEnum _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = (test.DemoEnum)__e0[0].AsInt; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  X4.Add(_k0, _v0); }   }
            PostInit();
        }

        public static TestMap DeserializeTestMap(JSONNode _buf)
        {
            return new test.TestMap(_buf);
        }

        public readonly int Id;
        public test.TestIndex Id_Ref { private set; get; }
        public readonly System.Collections.Generic.Dictionary<int, int> X1;
        public readonly System.Collections.Generic.Dictionary<long, int> X2;
        public readonly System.Collections.Generic.Dictionary<string, int> X3;
        public readonly System.Collections.Generic.Dictionary<test.DemoEnum, int> X4;
        public const int __ID__ = -543227410;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef(TablesComponent tables)
        {
            Id_Ref = tables.TbTestIndex.Get(Id);
            
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "x1:" + StringUtil.CollectionToString(X1) + ","
            + "x2:" + StringUtil.CollectionToString(X2) + ","
            + "x3:" + StringUtil.CollectionToString(X3) + ","
            + "x4:" + StringUtil.CollectionToString(X4) + ","
            + "}";
        }

        partial void PostInit();
    }
}
