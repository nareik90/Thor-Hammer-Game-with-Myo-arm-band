using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GUIText ScoreText;
    private int score;


    // Use this for initialization
    void Start () {
        score = 0;
        UpdateScore();
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        Debug.Log("Scored..........");
        UpdateScore();
    }

    void UpdateScore()
    {
        ScoreText.text = "Score: " + score;

    }
}
