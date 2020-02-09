using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnknownRealm.Match { 
public class RagDoll : MonoBehaviour
{
        public BodyPart Head, Neck, LeftArm, LeftHand, RightArm, RightHand, Body, Plevis,
            LeftLeg, LeftFoot, RightLeg, RightFoot;
    private uint uuid;
    private float maxHp = 100f;
    private float currentHp;
    private byte flexiblity;

    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
