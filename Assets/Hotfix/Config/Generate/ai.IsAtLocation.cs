
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

namespace Hotfix.Config.ai
{
    public sealed partial class IsAtLocation : ai.Decorator
    {
        public IsAtLocation(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["acceptable_radius"].IsNumber) { throw new SerializationException(); }  AcceptableRadius = _buf["acceptable_radius"]; }
            { if(!_buf["keyboard_key"].IsString) { throw new SerializationException(); }  KeyboardKey = _buf["keyboard_key"]; }
            { if(!_buf["inverse_condition"].IsBoolean) { throw new SerializationException(); }  InverseCondition = _buf["inverse_condition"]; }
            PostInit();
        }

        public static IsAtLocation DeserializeIsAtLocation(JSONNode _buf)
        {
            return new ai.IsAtLocation(_buf);
        }

        public readonly float AcceptableRadius;
        public readonly string KeyboardKey;
        public readonly bool InverseCondition;
        public const int __ID__ = 1255972344;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
            
            
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "flowAbortMode:" + FlowAbortMode + ","
            + "acceptableRadius:" + AcceptableRadius + ","
            + "keyboardKey:" + KeyboardKey + ","
            + "inverseCondition:" + InverseCondition + ","
            + "}";
        }

        partial void PostInit();
    }
}
