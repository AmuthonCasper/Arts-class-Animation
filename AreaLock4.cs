using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AreaLock4 : MonoBehaviour
{

    public GameObject Walls4;
    public GameObject player;
    public GameObject WalkingCamera; // Reference to the camera GameObject.
    public GameObject Area4Camera; // Reference to the camera GameObject.

    // All the gameobject in the game.
    public GameObject FadeInPanelCanvas;
    public GameObject ScoreCountCanvas;
    public GameObject Blocks;
    public GameObject Clouds;
    public GameObject Canvas;
    public GameObject Obstacles1;
    public GameObject PickUps;


    public bool want2LockCam4 = true; // Does script want to lock the cam?
    bool playerNotFree = true; // Is the player free from the area?
    bool LoadEndScene; // Load the end scene if true...
    bool want2load = true;

    public static bool lockTriggerActivated4 = false; // Did the player walk into the fourth lockTrigger? 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lockTriggerActivated4) // If the locktrigger got activated.
        {
            Area4Camera.SetActive(true); // Activate area camera

            Walls4.SetActive(true); // Activate the walls for this locking area. 

            playerNotFree = true; // The player isn't free now.
        }

        if (CloudSpawner4.startedPlaying4 && playerNotFree) // Activates when audio stopped and player got locked in.
        {
            StartCoroutine(WaitSeconds()); // Start the Coroutine as seen below.
        }
        
        if (LoadEndScene) // If script wants to load end scene...
        {
            SceneManager.LoadScene("EndingScene", LoadSceneMode.Additive); // Load the ending scene.
            DeleteAllMain(); // Delete all objects in main scene (to stop the scenes from interfering (bug?)).
            LoadEndScene = false; // Set LoadEndScene to false.
        }
        
    }

    void DeleteAllMain() // Delete all objects in main scene (to stop the scenes from interfering (bug?)).
    {
        FadeInPanelCanvas.SetActive(false);
        ScoreCountCanvas.SetActive(false);
        Blocks.SetActive(false);
        Clouds.SetActive(false);
        Canvas.SetActive(false);
        Obstacles1.SetActive(false);
        PickUps.SetActive(false);
    }

    IEnumerator WaitSeconds()
    {
        yield return new WaitForSeconds(23); // Wait for 23 seconds.
        lockTriggerActivated4 = false; // Set lockTriggerActivated3 to false.

        Walls4.SetActive(false); // Disable the area camera.
        playerNotFree = false; // The player is now free.
        if (want2load) // If script wants to load (so this only loads gets called once).
        {
            LoadEndScene = true; // Load the end scene.
            want2load = false; 
        }

    }
}






