using ProjectG.DB;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.Object
{
    public abstract class Actor : Object
    {
        public BoActor boActor;
        public override void Initialize(BoObject boActor)
        {
            base.Initialize(boActor);
            this.boActor = boActor as BoActor;
            Debug.Log("Actor Initialize");
            SetStatsActor();
        }

        protected void SetStatsActor()
        {
            //base.SetStatsObject();
            Debug.Log("Actor SetStats");
        }
    }
}