using ProjectG.StaticData;
using ProjectG.Util;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.Managers
{
    public class GameManager : Singleton<GameManager>
    {

        [SerializeField]
        private StaticDataModule sd = new StaticDataModule();
        public static StaticDataModule SD { get { return Instance.sd; } }

    }
}
