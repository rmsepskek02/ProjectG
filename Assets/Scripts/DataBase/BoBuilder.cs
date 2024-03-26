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
        /// �ΰ��� ������
        public bool isControl;
        /// SD ������
        public SDBuilder sdBuilder;

        public BoBuilder(SDObject sdObject)
            : base(sdObject)
        {
            sdBuilder = sdObject as SDBuilder;
        }
    }
}