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


    //kallas p� i b�rjan av spelet
     private void Start ()
    {
     transform.position = waypoints[waypointIndex].transform.position;

    }
    //kallas p� i varje frame
   private void Update()
    {
       //Metoden Move anv�nds i varje frame
        Move();
    }

    //Sj�lva metoden som f�r fienden att r�ra sig
    private void Move()
    {  
        //Fiende forts�tter fram tills att den r�rt den sista waypointen vilket blir tornet
        if (waypointIndex <= waypoints.Length - 1)
        {   
            //Fienden r�r sig fr�n waypoint till waypoint genom MoveTowards metod
            transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, movespeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }

        }



    }
}
