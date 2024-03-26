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
            // ������ ĳ���Ͱ� ������Ʈ �� �� �ֵ��� ��ü ĳ���� ��Ͽ� �־���
            charactors.Add(player);
        }
    }
}