using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameController GameController;
    public bool spawn = true;
 

    // The Monster that should be spawned
    public GameObject monsterPrefab;

    // Spawn Delay in seconds
    public float interval = 10;



    // Use this for initialization
    void Start()
    {
        /*gameOver = false;
        restart = false;
        RestartText.text = "";
        GameOverText.text = "";*/

        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {

        while (spawn == true)
        {
            Instantiate(monsterPrefab, transform.position, Quaternion.identity);

            if (spawn == false)
            {
                break;
            }
        }
    }
    /*
    public void GameOver ()
    {
        GameOverText.text = "Game Over!";
        gameOver = true;
    }*/
}
