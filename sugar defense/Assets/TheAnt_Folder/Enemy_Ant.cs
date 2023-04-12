using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ant : MonoBehaviour
{


    [SerializeField] private int health;
    [SerializeField] private int damage;
    [SerializeField] private int speed;

    
    // Start is called before the first frame update
    void Start()
    {
        //create array named "waypoints"
        GameObject[] waypoints;
        //tells the array to find any gameobjects with the tag "Waypoint"
        waypoints = GameObject.FindGameObjectsWithTag("Waypoint");
        Debug.Log(waypoints.Length - 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
