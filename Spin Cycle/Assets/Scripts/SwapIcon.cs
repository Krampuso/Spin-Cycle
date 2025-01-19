using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class SwapIcon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    // Update is called once per frame
    void Update() // Look for better coding solution. 
    {
        IconChange(); 
    }
    
    void IconChange()
    {
        GameObject[] players = {player1,player2,player3};

         for(int i = 0; i < transform.childCount; i++) //Turn off all icons first
         {
            transform.GetChild(i).gameObject.SetActive(false);
         }

         for(int i = 0; i < players.Length; i++)
         {
            if(players[i].activeSelf)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
         }
    }
}
