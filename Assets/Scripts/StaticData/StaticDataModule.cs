using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.StaticData
{
    [Serializable]
    public class StaticDataModule
    {
        public List<SDBuilder> sdBuilder;
        public List<SDGeneralUnit> sdGeneralUnit;
        public List<SDNeutralHunterUnit> sdNeutralHunterUnit;
        public List<SDNeutralUnit> sdNeutralUnit;
        public List<SDDefenseTower> sdDefenseTower;
        public List<SDNexus> sdNexus;
        public List<SDResourceBuilding> sdResourceBuilding;
        public List<SDTechBuilding> sdTechBuilding;
        public List<SDUnitBuilding> sdUnitBuilding;
    }
}