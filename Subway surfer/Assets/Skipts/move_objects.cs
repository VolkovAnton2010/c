using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_objects : MonoBehaviour
{
    private float _speed;
    void Start()
    {
        _speed = 10;
    }
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime); 
    }
}
