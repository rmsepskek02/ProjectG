using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectG.StaticData;

namespace ProjectG.DB
{
    [Serializable]
    public class BoBuilder : BoActor
    {
        /// 인게임 데이터
        public bool isControl;
        /// SD 데이터
        public SDBuilder sdBuilder;

        public BoBuilder(SDObject sdObject)
            : base(sdObject)
        {
            sdBuilder = sdObject as SDBuilder;
        }
    }
}