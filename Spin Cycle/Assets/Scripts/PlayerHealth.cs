using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int playerHealth = 100;
    int currentHealth; 
    int maxHealth; 
    int damageTaken;
    public EnemyBullet enemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        if(enemyBullet == null)
        {
            Debug.Log("Enemy bullet is not assigned!");

        }
        else
        {
            maxHealth = playerHealth;
            currentHealth = playerHealth;
            damageTaken = enemyBullet.bulletDamage;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This script works");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnemyBullet")
            {
                currentHealth -= damageTaken;
                Debug.Log("Current health is " + currentHealth);
            }
    }



    

    
}
