using UnityEngine;
using System.Collections;

public class LockTrigger1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other) // If the player activates the trigger
    {
        AreaLock.lockTriggerActivated1 = true;
        Destroy(gameObject);
        
    }
}
