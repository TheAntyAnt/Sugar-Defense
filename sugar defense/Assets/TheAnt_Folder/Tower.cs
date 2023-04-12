using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Tower : MonoBehaviour
{

    private Transform target;
    //define the range of the tower
    public float range = 15f;


    //what part of the tower should spin?
    public Transform baset;
    public float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //this starts the method "UpdateTarget" at the start and then repeats that every 2 seconds
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    //the method for finding a target
    void UpdateTarget()
    {
        //Creates an array called "Enemies" that will find any GameObjects 
        GameObject[] Enemies = GameObject.FindGameObjectsWithTag("enemy");
        //stores the distance of the closest enemy
        float shortestDistance = Mathf.Infinity;
        //stores which enemy is closest
        GameObject nearestEnemy = null;

        //looks through the array for GameObjects with the tag "enemy"
        foreach (GameObject enemy in Enemies)
        {
            //looks for the distance between the enemy and the tower
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            //checks to see if the distance of a new enemy is closer than the previous distance checked
            if (distanceToEnemy > shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            Debug.Log("I found the enemy!");
        }
        else
        {
            target = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if the target don't exist, do nothing
        if (target == null)
        {
            return;
        }
        
        //what direction is the target?
        Vector3 dir = target.position - transform.position;
        //How to turn to look in the direction of the target
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        //turn the complicated quaternion equation for rotation into nice and simple eulerAngles
        //eulerAngles is when you rotate something around an axis
        //Lerp makes it so it turns smoothly over a time
        Vector3 rotation = Quaternion.Lerp(baset.rotation, lookRotation, Time.deltaTime * rotationSpeed).eulerAngles;
        //makes it so it only rotates around the Y-axis
        baset.rotation = Quaternion.Euler (0f, rotation.y, 0f);
        
    }
    
    //visualize the range of the tower with a wire and make it blue
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
