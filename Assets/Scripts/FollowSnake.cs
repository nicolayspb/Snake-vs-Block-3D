using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSnake : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, target.position.y + offset.y, target.position.z + offset.z); ;
    }
}
