using UnityEngine;
using System.Collections;

public class AreaLock : MonoBehaviour
{
    public GameObject Walls1; // Reference to the wall GameObject.
    public GameObject player; // Reference to the player GameObject.
    public GameObject WalkingCamera; // Reference to the camera GameObject.
    public GameObject Area1Camera; // Reference to the camera GameObject.

    bool playerNotFree = true; // Is the player free from the area?
    public static bool lockTriggerActivated1; // Did the player walk into the first lockTrigger?

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lockTriggerActivated1) // If the locktrigger got activated.
        {
            Area1Camera.SetActive(true); // Activate area camera

            Walls1.SetActive(true); // Activate the walls for this locking area. 

            playerNotFree = true; // The player isn't free now.
        }

        if (CloudSpawner.startedPlaying && playerNotFree) // Activates when audio stopped and player got locked in.
        {
            StartCoroutine(WaitSeconds()); // Start the Coroutine as seen below.
        }
    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(12); // Wait for 12 seconds.
        lockTriggerActivated1 = false; // Set lockTriggerActivated1 to false.

        Area1Camera.SetActive(false); // Disable the area camera.
  
        Walls1.SetActive(false); // Disable the area walls.
        playerNotFree = false; // The player is now free.
    }
}
