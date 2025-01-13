using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin, fasterSpin}

    [Header("Bullet Attributes")]
    public GameObject bullet;
    public float bulletsLife = 1f;
    public float speed = 1f;

    [Header("Spawner Attributes")]

    [SerializeField] private SpawnerType spawnerType;
    [SerializeField] private float firingRate = 1f;

    private GameObject spawnedBullet;
    private float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(spawnerType == SpawnerType.Spin) transform.eulerAngles = new Vector3(0f,0f,transform.eulerAngles.z+1f);
        if(spawnerType == SpawnerType.fasterSpin) transform.eulerAngles = new Vector3(0f,0f,transform.eulerAngles.z+3f);
        if(timer >= firingRate)
        {
            Fire();
            timer = 0;
        }
        
    }

    private void Fire() 
    {
        if(bullet) 
        {
            spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<EnemyBullet>().speed = speed;
            spawnedBullet.GetComponent<EnemyBullet>().bulletLife = bulletsLife;
            spawnedBullet.transform.rotation = transform.rotation;


        }
    }
}
