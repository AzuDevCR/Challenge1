using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorRotation : MonoBehaviour
{
    private float propellorSpeed = 2000.0f;
    
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propellorSpeed);
    }
}
