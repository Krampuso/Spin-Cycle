using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHP = 100;
    Bullet bullet;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(enemyHP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    { 
        Debug.Log("Script is working");

        bullet = col.gameObject.GetComponent<Bullet>();

        if(col.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("Collided");
            enemyHP -= bullet.bulletDamage;
            Debug.Log("Enemy Hp is " + enemyHP);
        }
        else
        {
            Debug.Log("Not working");
        }
            
            
        
    }
}
