using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

    public GameController GameController;
    public bool spawn = true;
    bool spawnNext = true;
    int monsterCounter = 0;

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
        if (spawnNext == true)
        {
            InvokeRepeating("SpawnNext", interval, interval);
        }
    }

    void update()
    {
        if (spawnNext == true)
        {
            InvokeRepeating("SpawnNext", interval, interval);
        }
    }

     void SpawnNext()
    {
        if (monsterCounter <= 3) {
            Instantiate(monsterPrefab, transform.position, Quaternion.identity);
            monsterCounter = monsterCounter + 1;
        }

        if (monsterCounter >= 4)
        {
            spawnNext = false;
            monsterCounter = monsterCounter - 1;
        }
    }
}