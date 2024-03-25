using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.StaticData
{
    [CreateAssetMenu(menuName = "ProjectG/SDDefenseTowerData")]
    public class SDDefenseTower : SDBuilding
    {
        public int atk;
        public int atkRange;
        public int atkSpeed;
        public int detectRange;
        public string atkType;
        public bool isDetect;
        public bool isATG;
        public bool isATA;
    }
}
