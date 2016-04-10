using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour {

    void OnTriggerEnter(Collider co)
    {
        // If target then deal Damage, destroy self
        if (co.name == "Ground")
        { 
            Destroy(gameObject);
            Debug.Log("Target hit... Bang");
        }
    }
}
