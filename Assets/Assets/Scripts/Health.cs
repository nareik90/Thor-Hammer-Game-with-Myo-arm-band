using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
    GUIText tm;
    private Spawn spawn;

    // Use this for initialization
    void Start()
    {
        tm = GetComponent<GUIText>();
        Debug.Log("Start Health class");
    }


    // Return the current Health by counting the '/'
    public int current()
    {
        return tm.text.Length;
    }

    // Decrease the current Health by removing one '/'
    public void decrease()
    {
        Debug.Log("Health Decrease");
        if (current() > 1)
            tm.text = tm.text.Remove(tm.text.Length - 1);
        else
            Destroy(transform.parent.gameObject);
    }
}
