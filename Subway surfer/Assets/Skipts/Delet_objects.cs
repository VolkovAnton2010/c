using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delet_objects : MonoBehaviour
{
  
    void Update()
    {
        if(transform.position.x <= -7) 
        { 
            Destroy(gameObject);
        }
    }
}
