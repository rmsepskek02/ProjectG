using ProjectG.DB;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.Object
{
    public abstract class Object : MonoBehaviour
    {
        public BoObject boObject;
        public virtual void Execute()
        {

        }
        public void Start()
        {
            Init();
        }

        public abstract void Init();

        public virtual void Initialize(BoObject boObject)
        {
            this.boObject = boObject;
            Debug.Log("Object Initialize");
        }
        public virtual void SetStatsObject()
        {
            Debug.Log("Object SetStats");
            boObject.moveSpeed = boObject.sdObject.moveSpeed;
            boObject.hp = boObject.sdObject.hp;
            boObject.mp = boObject.sdObject.mp;
            boObject.barrior = boObject.sdObject.barrior;
            boObject.armor = boObject.sdObject.armor;
            boObject.visualRange = boObject.sdObject.visualRange;
            boObject.size = boObject.sdObject.size;
            boObject.atrType = boObject.sdObject.atrType;
            boObject.kind = boObject.sdObject.kind;
            boObject.objectType = boObject.sdObject.objectType;
            boObject.isGround = boObject.sdObject.isGround;
            boObject.moveSpeed = boObject.sdObject.moveSpeed;
            boObject.generationRate = boObject.sdObject.generationRate;
        }
    }
}