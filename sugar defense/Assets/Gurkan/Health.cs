using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script also handles some of the respawn functions
public class Health : MonoBehaviour
{
    

    public float maxhealth = 100f;
    public float currenthealth;

    public float damage = 10f;

    private Enemyrespawn enemyrespawn;
    
    
    // Start is called before the first frame update
    public void Start()
    {
        
        
        currenthealth = maxhealth;

        enemyrespawn = GetComponent<Enemyrespawn>();
    }

    // Update is called once per frame
   public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currenthealth = currenthealth - damage;
        }
        
        if (currenthealth <= 0f)
        {
            enemyrespawn.RespawnEnemy();
            Destroy(gameObject);
            
        }

       
    }




}
