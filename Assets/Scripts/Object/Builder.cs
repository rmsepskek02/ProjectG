using ProjectG.DB;
using ProjectG.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.Object
{
    public class Builder : Actor
    {
        public BoBuilder boBuilder;

        public override void Initialize(BoObject boBuilder)
        {
            base.Initialize(boBuilder);
            this.boBuilder = boBuilder as BoBuilder;
            Debug.Log("Builder Initialize");
            SetStatsBuilder();
        }

        public override void Init()
        {

        }

        protected void SetStatsBuilder()
        {
            base.SetStatsObject();
            Debug.Log("Builder SetStats");
            if (boBuilder != null && boBuilder.sdBuilder != null)
            {
                Debug.Log("NOT NULL" + boBuilder.sdBuilder);
                boBuilder.isControl = boBuilder.sdBuilder.isControl;
            }
        }
    }
}
