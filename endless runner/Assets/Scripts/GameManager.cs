using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    [SerializeField]Text scoreText;
    [SerializeField] PlayerMovement playerMovement;

    public void IncrementScore()
    {
        score++;
        scoreText.text="SCORE:"+score;
        //Inrease player speed
        playerMovement.speed+=playerMovement.speedIncreasePerPoint;
    }

    private void Awake()
    {
        inst=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
