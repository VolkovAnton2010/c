using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spame_menager : MonoBehaviour
{
    public GameObject[] objects;
    private Vector3 position;
    private int indecs;
    private plaeyr_controller plaeyr;
    void Start()
    {
        plaeyr= GetComponent<plaeyr_controller>();
        position = new Vector3(40,0,0);
        InvokeRepeating("spame_obstacle", 1, 1.5f);
        Debug.Log(plaeyr.GameOver);
    }
    void spame_obstacle()
    {
        indecs = Random.Range(0, objects.Length);
        Instantiate(objects[indecs], position, objects[indecs].transform.rotation);
    }
}
