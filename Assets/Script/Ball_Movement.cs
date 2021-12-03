using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public float ServeForce = 0.5f;
    public Collider2D LeftWall;
    public Collider2D RightWall;
    private Vector3 StartPosition;
    public Score_Managing_System Score_System;
    private bool Scoring_Allowed = true;
    public float Cool_Down = 1f;
    public List<Collider2D> Walls;
    public List<Collider2D> Paddles;
    public AudioClip Wall_Hit;
    public AudioClip Score_Sound;
    public AudioClip Paddle_Hit;
    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        StartCoroutine("Serve");
    }

    // Update is called once per frame
    
    void Update()
    {
         if ((GetComponent<Collider2D>().IsTouching(LeftWall) || GetComponent<Collider2D>().IsTouching(RightWall)) && Scoring_Allowed)
        {
            Scoring_Allowed = false;
            if (GetComponent<Collider2D>().IsTouching(LeftWall))
                Score_System.player_2_score += 1;
            else
                Score_System.player_1_score += 1;
            GetComponent<Rigidbody2D>().Sleep();
            transform.position = StartPosition;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            StartCoroutine("Serve");
            PlaySound(Score_Sound);

        }
         
          foreach (Collider2D Wall in Walls)
        {
            if (GetComponent<Collider2D>().IsTouching(Wall))
            {
                PlaySound(Wall_Hit);
                break;
            }
            
        }
          foreach (Collider2D Paddle in Paddles)
        {
            if (GetComponent<Collider2D>().IsTouching(Paddle))
            {
                PlaySound(Paddle_Hit);
                break;
            }
        }

    }
    IEnumerator Serve()
    {
        yield return new WaitForSeconds(Cool_Down);
        GetComponent<Rigidbody2D>().WakeUp();
        int x = Random.Range(0, 2);
        if (x == 0)
            x = -1;
        float y = Random.Range(-ServeForce, ServeForce);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(ServeForce * x, y));
        Scoring_Allowed = true;
    }
    private void PlaySound(AudioClip Sound)
    {
        AudioSource AS = GetComponent<AudioSource>();
        AS.clip = Sound;
        AS.Play();
    }
}