using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class SwapCharacter : MonoBehaviour
{
    public int selectedPlayer = 0;
    
    void Start()
    {
        SelectPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedPlayer = selectedPlayer;

        if(Input.GetKeyDown(KeyCode.R))
        {
            if(selectedPlayer >= transform.childCount - 1)
                selectedPlayer = 0;
            else
                selectedPlayer++;
        }

        if (previousSelectedPlayer != selectedPlayer)
        {
            SelectPlayer();
        }
    }

    void SelectPlayer()
    {
        int i = 0;
        foreach (Transform character in transform)
        {
            if(i == selectedPlayer)
                character.gameObject.SetActive(true);
            else 
                character.gameObject.SetActive(false);
            i++;
        }
    }
    
}
