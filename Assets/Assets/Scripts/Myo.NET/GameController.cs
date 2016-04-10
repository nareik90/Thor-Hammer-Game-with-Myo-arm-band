using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GUIText ScoreText;
    private int score;

    // The Bomb that should be spawned
    public GameObject Bomb;


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

    void update()
    {

        if (Input.GetKeyDown("Z"))
            Instantiate(Bomb, transform.position, Quaternion.identity);
            Debug.Log("Bomb imported");
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key was pressed");
        }
    }
    }





