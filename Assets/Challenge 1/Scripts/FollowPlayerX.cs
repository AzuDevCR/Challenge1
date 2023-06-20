using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //Follow camera essentials

    //1. What to follow
    public GameObject plane;
    //2. An offset if needed(it can be previewed and established in the editor then here)
    private Vector3 offset = new Vector3(20, 0, 0);
    // Update is called once per frame
    //3. The position of the camera will be the 'what to follow' postion + offset in the LateUpdate method
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
