using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameProcessor : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TextMeshProUGUI testText;

    public Slider powerSlider;
    private int marks { get; set; }
    private AutoBall red;
    private AutoBall blue;
    private AutoBall black;
    private AutoBall yellow;
    private AutoBall pink;
    private AutoBall orange;
    private BallW white;
    private Vector3[] startPos;
    void Start()
    {
        testText = GameObject.Find("TextChange").GetComponent<TextMeshProUGUI>();
        
        startPos = new Vector3[7];

        red = GameObject.Find("Red").GetComponent<AutoBall>();
        startPos[0] = red.transform.position;

        blue = GameObject.Find("Blue").GetComponent<AutoBall>();
        startPos[1] = blue.transform.position;

        black = GameObject.Find("Black").GetComponent<AutoBall>();
        startPos[2] = black.transform.position;

        yellow = GameObject.Find("Yellow").GetComponent<AutoBall>();
        startPos[3] = yellow.transform.position;

        pink = GameObject.Find("Pink").GetComponent<AutoBall>();
        startPos[4] = pink.transform.position;

        orange = GameObject.Find("Orange").GetComponent<AutoBall>();
        startPos[5] = orange.transform.position;

        white = FindFirstObjectByType<BallW>();
        startPos[6] = white.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        testText.text = Convert.ToString(marks);
    }

    public void MaxMark() {
        marks++;
    }

    public void RestartGame() { 
       // marks = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    }

    public void PlayShoot() {

        white.HitOn(powerSlider.value);

    }
}
