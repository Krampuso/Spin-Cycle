using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassBossNavigation : MonoBehaviour
{
    public GameObject Boss;
    public GameObject leafBullet;
    private GameObject spawnedLeaf;
    private Rigidbody2D rb;
    private int simpleAttack = 0;
    private float timer = 0;
    private float attackSwitchTime = 10;


    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Debug.Log(timer);
        PhaseOne();
    }

    void PhaseOne()
    {
        //simpleAttack = Random.Range(1,4);
        simpleAttack = 1;
        switch (simpleAttack)
        {
            case 1:
            timer += Time.deltaTime;
            if(timer < attackSwitchTime)
            {
                StartCoroutine(AttackOne());
            };
            //code
            break;
            case 2:
            timer += Time.deltaTime;
            //code
            break;
            case 3:
            timer += Time.deltaTime;
            //code
            break;
        }
       /* if(timer > attackSwitchTime){
            timer = 0;
        }
        This is good once I have other cases set up*/
    }
    IEnumerator AttackOne()
    {
        Instantiate(leafBullet, transform.position + new Vector3(2f, 0f, 0f), Quaternion.identity);
        Instantiate(leafBullet, transform.position + new Vector3(0f, 2f, 0f), Quaternion.identity);
        Instantiate(leafBullet, transform.position + new Vector3(2f, 2f, 0f), Quaternion.identity);
        yield return new WaitForSeconds(10f);
    }

}
