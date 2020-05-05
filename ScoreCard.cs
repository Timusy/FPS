using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCard : MonoBehaviour
{
    public static int GlobalScoreCard;
    public int scoreCard;
    public GameObject ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreCard = GlobalScoreCard;
        ScoreText.GetComponent<Text>().text = " " + scoreCard;
        
    }
}
