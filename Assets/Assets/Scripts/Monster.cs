using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
    public int ScoreValue;
    private GameController gameController;

    void Start()
    {
        // Navigate to Castle
        GameObject target = GameObject.Find("Target");

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
            Destroy(gameObject);
        }
    }
}
