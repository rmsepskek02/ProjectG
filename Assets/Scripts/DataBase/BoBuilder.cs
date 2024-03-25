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
        /// SD ตฅภฬลอ
        public SDBuilder sDBuilder;

        public BoBuilder(SDActor sdActor)
            : base(sdActor)
        {
            sDBuilder = sdActor as SDBuilder;
        }
    }
}