using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectG.StaticData;

namespace ProjectG.DB
{
    [Serializable]
    public class BoObject
    {
        /// 인게임 데이터
        public string nickName;
        public string resourcePath;
        public int hp;
        public int mp;
        public int barrior;
        public int armor;
        public int visualRange;
        public int size;
        public string atrType;
        public int kind;
        public string objectType;
        public bool isGround;
        public int moveSpeed;
        public int generationRate;
        /// SD 데이터
        public SDObject sdObject;

        public BoObject(SDObject sdObject)
        {
            this.sdObject = sdObject;
        }
    }
}