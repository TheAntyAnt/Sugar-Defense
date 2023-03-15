using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followpath : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private float movespeed = 2f;

     private int waypointIndex = 0;


    //kallas på i början av spelet
     private void Start ()
    {
     transform.position = waypoints[waypointIndex].transform.position;

    }
    //kallas på i varje frame
   private void Update()
    {
       //Metoden Move används i varje frame
        Move();
    }

    //Själva metoden som får fienden att röra sig
    private void Move()
    {  
        //Fiende fortsätter fram tills att den rört den sista waypointen vilket blir tornet
        if (waypointIndex <= waypoints.Length - 1)
        {   
            //Fienden rör sig från waypoint till waypoint genom MoveTowards metod
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, movespeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }

        }



    }
}
