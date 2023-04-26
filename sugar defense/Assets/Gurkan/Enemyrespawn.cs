using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyrespawn : MonoBehaviour
{

    

    public GameObject enemyprefab;
    private Transform enemyspawnpoint;

    public float respawntime = 3f;
    private float timer;

    public bool dead = false;
    
    // Start is called before the first frame update
    private void Start()
    {
        enemyspawnpoint = GameObject.Find("Waypoint").transform;

    }

    

    public void RespawnEnemy()
    {
        Instantiate(enemyprefab, enemyspawnpoint.position, enemyspawnpoint.rotation);
    }

    // Update is called once per frame
   public void Update()
    {
        
       
       timer += Time.deltaTime;
       if (timer >= respawntime)
       {
         RespawnEnemy();
         timer = 0;
       }
          
          
      


    }
}
