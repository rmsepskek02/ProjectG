using ProjectG.DB;
using ProjectG.Object;
using ProjectG.Util;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ProjectG.Managers
{
    public class InGameManager : Singleton<InGameManager>
    {

        public List<Actor> charactors = new List<Actor>();

        void Start()
        {
            GeneratorCharactor();
        }

        void Update()
        {

        }

        public void GeneratorCharactor()
        {
            var sdBuilder = GameManager.SD.sdBuilder.Where(_ => _.index == 1001).SingleOrDefault();
            var player = Instantiate(Resources.Load<GameObject>(sdBuilder.resourcePath)).GetComponent<Builder>();
            player.Initialize(new BoBuilder(sdBuilder));
            // 생성한 캐릭터가 업데이트 될 수 있도록 전체 캐릭터 목록에 넣어줌
            charactors.Add(player);
        }
    }
}