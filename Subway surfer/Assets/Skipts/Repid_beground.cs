using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repid_beground : MonoBehaviour
{
    private float width;
    private Vector3 start_position;

    void Start()
    {
        width = GetComponent<BoxCollider>().size.x /2;
        start_position = transform.position;
    }

    void Update()
    {
        if(transform.position.x < start_position.x - width)
        {
            transform.position=start_position;
        }
    }
}
