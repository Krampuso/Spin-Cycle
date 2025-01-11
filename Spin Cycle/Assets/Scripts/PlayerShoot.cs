using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    public float fireRate = 1f;
    
    private float timer = 0f;
    

    
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {
        timer += Time.deltaTime;
        if(Input.GetButton("Fire1"))
        {
            if(timer >= fireRate)
            {
               Shoot();
               timer = 0; 
            }
            
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, shootingPoint.position, transform.rotation); // Spawns bullet gameObject, Spawns from Shooting point possition, rotation?
    }
}
