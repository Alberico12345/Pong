using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score_Managing_System : MonoBehaviour
{
    public int player_1_score = 0;
    public int player_2_score = 0;
    public string EndScene = "";
    void Update()
    {
        if (player_1_score > 9 || player_2_score > 9)
        {
            PlayerPrefs.SetInt("Player_1_Score", player_1_score);
            PlayerPrefs.SetInt("Player_2_Score", player_2_score);
            SceneManager.LoadScene(EndScene);
        }

        
    }
}