using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.StaticData
{
    [CreateAssetMenu(menuName = "ProjectG/SDResourceBuilding")]
    public class SDResourceBuilding : SDBuilding
    {
        public string supplyType;
        public int supplyRate;
    }
}
