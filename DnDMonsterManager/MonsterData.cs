using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DnDMonsterManager
{
    public class MonsterData
    {
        public string _name { get; set; }
        public int _maxHp { get; set; }
        public bool _hpVar { get; set; }
        public EType _type { get; set; }
        public ESize _size { get; set; }
        public string _link { get; set; }

        public MonsterData(string name, int maxHp, bool hpVar, ESize size, EType type, string link) 
        {
            _name = name;
            _maxHp = maxHp;
            _hpVar = hpVar;
            _size = size;
            _type = type;
            _link = link;
        }
        public bool SaveAsJSON()
        {
            // return success state
            string filePath = "MonsterData.json";
            try
            {
                string JSONData = File.ReadAllText(filePath);
                var monsterList = JsonConvert.DeserializeObject<List<MonsterData>>(JSONData) ?? new List<MonsterData>();
                MonsterData? oldCopy = null;
                foreach (MonsterData monster in monsterList)
                {
                    if(this._name == monster._name)
                    {
                        oldCopy = monster;
                        break;
                    }
                }
                if (oldCopy != null)
                {
                    monsterList.Remove(oldCopy);
                }
                monsterList.Add(this);
                JSONData = JsonConvert.SerializeObject(monsterList);
                File.WriteAllText(filePath, JSONData);

                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
    }
}
