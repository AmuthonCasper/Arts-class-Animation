using UnityEngine;
using System.Collections;

public class AreaLock2 : MonoBehaviour
{
    public GameObject Walls2; // Reference to the wall GameObject.
    public GameObject player; // Reference to the player GameObject.
    public GameObject WalkingCamera; // Reference to the camera GameObject.
    public GameObject Area2Camera; // Reference to the camera GameObject.

    bool playerNotFree = true; // Is the player free from the area?
    public static bool lockTriggerActivated2; // Did the player walk into the second lockTrigger?

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lockTriggerActivated2) // If the locktrigger got activated.
        {
            Area2Camera.SetActive(true); // Activate area camera

            Walls2.SetActive(true); // Activate the walls for this locking area. 

            playerNotFree = true; // The player isn't free now.
        }

        if (CloudSpawner2.startedPlaying2 && playerNotFree) // Activates when audio stopped and player got locked in.
        {
            StartCoroutine(WaitSeconds()); // Start the Coroutine as seen below.
        }
    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(17); // Wait for 17 seconds.

        lockTriggerActivated2 = false; // Set lockTriggerActivated2 to false.

        Area2Camera.SetActive(false); // Disable the area camera.

        Walls2.SetActive(false); // Disable the area walls.
        playerNotFree = false; // The player is now free.
    }
}


