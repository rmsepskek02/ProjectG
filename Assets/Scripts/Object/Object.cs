using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectG.Object
{
    public abstract class Obj : MonoBehaviour
    {
        public virtual void Execute()
        {

        }
        public void Start()
        {
            Init();
        }

        public abstract void Init();
    }
}