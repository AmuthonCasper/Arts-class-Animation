using UnityEngine;
using System.Collections;

public class AreaLock3 : MonoBehaviour
{
    public GameObject Walls3; // Reference to the wall GameObject.
    public GameObject player; // Reference to the player GameObject.
    public GameObject WalkingCamera; // Reference to the camera GameObject.
    public GameObject Area3Camera; // Reference to the camera GameObject.

    bool playerNotFree = true; // Is the player free from the area?
    public static bool lockTriggerActivated3; // Did the player walk into the third lockTrigger? 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lockTriggerActivated3) // If the locktrigger got activated.
        {
            Area3Camera.SetActive(true); // Activate area camera

            Walls3.SetActive(true); // Activate the walls for this locking area. 

            playerNotFree = true; // The player isn't free now.
        }

        if (CloudSpawner3.startedPlaying3 && playerNotFree) // Activates when audio stopped and player got locked in.
        {
            StartCoroutine(WaitSeconds()); // Start the Coroutine as seen below.
        }
    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(23); // Wait for 23 seconds.
        lockTriggerActivated3 = false; // Set lockTriggerActivated3 to false.

        Area3Camera.SetActive(false); // Disable the area camera.

        Walls3.SetActive(false); // Disable the area walls.
        playerNotFree = false; // The player is now free.
    }
}




