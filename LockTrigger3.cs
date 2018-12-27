using UnityEngine;
using System.Collections;

public class LockTrigger3 : MonoBehaviour { 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) // If the player steps on the button.
    {
        AreaLock3.lockTriggerActivated3 = true;
        Destroy(gameObject);
    }
}
