using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
    public int ScoreValue;
    private GameController gameController;

    void Start()
    {
         // Navigate to Target
        GameObject target = GameObject.Find("Target");
        GameObject healthDec = GameObject.Find("DisplyUI");

        if (target)
            GetComponent<NavMeshAgent>().destination = target.transform.position;

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameControllerObject == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }


    void OnTriggerEnter(Collider co)
    {
        // If target then deal Damage, destroy self
        if (co.name == "Target")
        {
            co.GetComponentInChildren<Health>().decrease();
            KillMonster();
            Debug.Log("Target hit... Bang");
        }

        if (co.name == "Hammer")
        {
            KillMonster();
            gameController.AddScore(ScoreValue);
            Debug.Log("Scored..........");
        }
    }

    void KillMonster() {
        Destroy(gameObject);
    }
}
