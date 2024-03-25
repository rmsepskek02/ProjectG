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
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public override void Initialize(BoActor boBuilder)
        {
            base.Initialize(boBuilder);
            this.boBuilder = boBuilder as BoBuilder;
        }

        public override void Init()
        {
            throw new System.NotImplementedException();
        }
    }
}
