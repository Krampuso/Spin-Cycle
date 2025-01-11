using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    public float fireRate;
    
    public bool canFire = true;
    

    
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, shootingPoint.position, transform.rotation); // Spawns bullet gameObject, Spawns from Shooting point possition, rotation? 
        canFire = false; 
        float timeToNextFire = 1 / fireRate;
        canFire = false; 
    }
}
