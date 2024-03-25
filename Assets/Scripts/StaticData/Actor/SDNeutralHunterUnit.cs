using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.StaticData
{
    [CreateAssetMenu(menuName = "ProjectG/SDNeutralHunterUnit")]
    public class SDNeutralHunterUnit : SDNoneBuilder
    {
        public int[] consume;
        public string[] resourceType;
        public bool isHunt;
        public bool isControl;
        public bool isAttack;
    }
}
