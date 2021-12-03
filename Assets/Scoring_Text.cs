using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoring_Text : MonoBehaviour


{
    public Score_Managing_System Score_Manager;
    public bool player_1_score = true;
    private TextMeshProUGUI Text_Mesh;
    void Start()
    {
        Text_Mesh = GetComponent<TextMeshProUGUI>();
    }


    // Update is called once per frame
    void Update()
    {
        if (player_1_score)
        {
            Text_Mesh.text = Score_Manager.player_1_score.ToString();

        }
        else
            Text_Mesh.text = Score_Manager.player_2_score.ToString();    }
}
