using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCharacter : MonoBehaviour
{
    public GameObject[] players;
    
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        Debug.Log(players[0]);
        Debug.Log(players[1]);
        Debug.Log(players[2]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SwapPlayer();
        }
    }

    public void SwapPlayer()
    {
        for(int i = 0; i <3; i++)
        {
           players[i].SetActive(true);
           int temp = i;
           Debug.Log(temp);
        }
    }
    
}
