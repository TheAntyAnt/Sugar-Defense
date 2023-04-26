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
        //gives you what number the last item in the waypoints array has
        //Example: your array has 8 items to refer to the last item of the array you will type waypoints[7]
        Debug.Log(waypoints.Length - 1);
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void move()
    {
        
    }
}
