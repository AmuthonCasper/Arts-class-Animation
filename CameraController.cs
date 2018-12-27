using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject camera; // Reference to the camera GameObject.
    public GameObject player; // Reference to the player GameObject.

    public static float score; // The current score. (This is here because it wouldn't update in the game when it was in the ScoreCount script)

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float playx; // The position.x of the player.

      
        playx = player.transform.position.x; // Set the playx variable tp the position.x of the player.
        if (playx > 0.1 && playx < 221.30 && camera.activeSelf) // If the player is between the bounderies of the world and the dev does not want to lock the camera.
        {
            camera.transform.position = new Vector3(playx, 0, -10); // Set the camera.x position to the player.x position. (Camera follows the player)
        }
    }
}
