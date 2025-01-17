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
        if(player1.activeSelf)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (!player1.activeSelf)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        if(player2.activeSelf)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else if (!player2.activeSelf)
        {
            transform.GetChild(1).gameObject.SetActive(false);
        }
        if(player3.activeSelf)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else if (!player3.activeSelf)
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }
    }
}
