using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHP = 100f;
    public float enemyMaxHP;

    Bullet bullet;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(enemyHP);
       enemyMaxHP = enemyHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    { 
        Debug.Log("Collision Script is working");

        bullet = col.gameObject.GetComponent<Bullet>();

        if(col.gameObject.CompareTag("PlayerBullet"))
        {
            Debug.Log("Collided");
            enemyHP -= bullet.bulletDamage;
            Debug.Log("Enemy Hp is " + enemyHP);
            if(enemyHP <= 0){
                Destroy(gameObject);
            }
            
        }
        else
        {
            Debug.Log("Not working");
        }
        Destroy(col.gameObject);
            
            
        
    }
}
