using UnityEngine;
using System.Collections;

public class RespawnScript : MonoBehaviour {
    public GameObject player; // Reference to the player GameObject.
    public GameObject redFadeIn; // Reference to the redFadeIn GameObject.

    public float respawnX; // The respawn position for x
    public float respawnY; // The respawn position for y

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

	}


    void OnTriggerEnter2D(Collider2D other) // If the player walks into an Obstacle.
    {
            StartCoroutine(WaitSeconds()); // Start the coroutine as seen below.
    }

    IEnumerator WaitSeconds()
    {
        redFadeIn.SetActive(true); // Activate the red dead screen.
        PlayerController.canMove = false; // Freeze the player (see PlayerController script).
        yield return new WaitForSeconds(2); // Wait for 2 seconds... (duration of the fading animation)
        redFadeIn.SetActive(false); // Disable the red dead screen.
        PlayerController.canMove = true; // UNfreeze the player.
        player.transform.position = new Vector2(respawnX, respawnY); // Take the player to the said respawn position.
    }
}
    

