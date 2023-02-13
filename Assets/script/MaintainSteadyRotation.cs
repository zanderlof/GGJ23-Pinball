using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Use this to keep a child at a constant rotation even when the parent rotates
public class MaintainSteadyRotation : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.rotation = Quaternion.identity;
    }
}
