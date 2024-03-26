using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectG.StaticData;

namespace ProjectG.DB
{
    [Serializable]
    public class BoActor : BoObject
    {
        /// SD ������
        public SDActor sdActor;

        public BoActor(SDObject sdObject)
            : base(sdObject)
        {
            sdActor = sdObject as SDActor;
        }
    }
}