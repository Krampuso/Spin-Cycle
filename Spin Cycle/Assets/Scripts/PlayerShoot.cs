using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    

    
    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {

    }
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
    }
}
