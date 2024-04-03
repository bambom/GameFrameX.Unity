
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
    public sealed partial class SimpleParallel : ai.ComposeNode
    {
        public SimpleParallel(JSONNode _buf) : base(_buf) 
        {
            { if(!_buf["finish_mode"].IsNumber) { throw new SerializationException(); }  FinishMode = (ai.EFinishMode)_buf["finish_mode"].AsInt; }
            { if(!_buf["main_task"].IsObject) { throw new SerializationException(); }  MainTask = ai.Task.DeserializeTask(_buf["main_task"]);  }
            { if(!_buf["background_node"].IsObject) { throw new SerializationException(); }  BackgroundNode = ai.FlowNode.DeserializeFlowNode(_buf["background_node"]);  }
            PostInit();
        }

        public static SimpleParallel DeserializeSimpleParallel(JSONNode _buf)
        {
            return new ai.SimpleParallel(_buf);
        }

        public readonly ai.EFinishMode FinishMode;
        public readonly ai.Task MainTask;
        public readonly ai.FlowNode BackgroundNode;
        public const int __ID__ = -1952582529;
        public override int GetTypeId() => __ID__;

        public override void ResolveRef(TablesComponent tables)
        {
            base.ResolveRef(tables);
            
            MainTask?.ResolveRef(tables);
            BackgroundNode?.ResolveRef(tables);
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "nodeName:" + NodeName + ","
            + "decorators:" + StringUtil.CollectionToString(Decorators) + ","
            + "services:" + StringUtil.CollectionToString(Services) + ","
            + "finishMode:" + FinishMode + ","
            + "mainTask:" + MainTask + ","
            + "backgroundNode:" + BackgroundNode + ","
            + "}";
        }

        partial void PostInit();
    }
}
