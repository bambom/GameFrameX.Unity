
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
    public partial class TbFullTypes : BaseDataTable<test.DemoType2>
    {
        //private readonly System.Collections.Generic.Dictionary<int, test.DemoType2> _dataMap;
        //private readonly System.Collections.Generic.List<test.DemoType2> _dataList;
        private readonly System.Func<System.Threading.Tasks.Task<JSONNode>> _loadFunc;        
        public TbFullTypes(System.Func<System.Threading.Tasks.Task<JSONNode>> loadFunc)
        {
            _loadFunc = loadFunc;
            //_dataMap = new System.Collections.Generic.Dictionary<int, test.DemoType2>();
            //_dataList = new System.Collections.Generic.List<test.DemoType2>();
        }
    
        public override async System.Threading.Tasks.Task LoadAsync()
        {
            JSONNode _json = await _loadFunc();
            //_dataMap.Clear();
            DataList.Clear();
            foreach(JSONNode _ele in _json.Children)
            {
                test.DemoType2 _v;
                { if(!_ele.IsObject) { throw new SerializationException(); }  _v = test.DemoType2.DeserializeDemoType2(_ele);  }
                DataList.Add(_v);                
                LongDataMaps.Add(_v.X4, _v);
                StringDataMaps.Add(_v.X4.ToString(), _v);
            }
            PostInit();
        }
    
        public void ResolveRef(TablesComponent tables)
        {
            foreach(var value in DataList)
            {
                value.ResolveRef(tables);
            }
        }
    
    
        partial void PostInit();
    }
}

