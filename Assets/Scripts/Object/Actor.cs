using ProjectG.DB;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.Object
{
    public abstract class Actor : Obj
    {
        public BoActor boActor;
        public virtual void Initialize(BoActor boActor)
        {
            this.boActor = boActor;
        }
    }
}