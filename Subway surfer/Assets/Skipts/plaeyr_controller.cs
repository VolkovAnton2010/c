using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaeyr_controller : MonoBehaviour
{
    private Rigidbody Rb;
    private float Speed;
    private bool stay_ground;
    public bool GameOver;
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Speed = 600;
        stay_ground= false;
        GameOver = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) & stay_ground == true & GameOver == false) 
        {
            Rb.AddForce(Vector3.up * Speed, ForceMode.Impulse);
            stay_ground = false;
        }    
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Obstacle")) 
        { 
            GameOver= true;
        }
        if (collision.gameObject.name == "Ground")   
        { 
            stay_ground= true;
        }
    }
}
