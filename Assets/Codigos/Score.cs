using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{

    public TMP_Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Puntos: " + score.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
