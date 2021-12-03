using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Winner_Text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int P1_score = PlayerPrefs.GetInt("Player_1_Score");
        int P2_score = PlayerPrefs.GetInt("Player_2_Score");
        string winner = "1";
        if (P2_score > 9)
        {
            winner = "2";
            
        }
        GetComponent<TextMeshProUGUI>().text = "Game Over \n player " + winner + " is the winner \n" + P1_score + "-" + P2_score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
