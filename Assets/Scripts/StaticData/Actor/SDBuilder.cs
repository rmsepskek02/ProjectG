using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.StaticData
{
    [CreateAssetMenu(menuName = "ProjectG/SDBuilder")]
    public class SDBuilder : SDActor
    {
        public int[] consume;
        public string[] resourceType;
        public bool isControl;
    }
}
