using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour {
    public GameObject Button; // Reference to the button GameObject of this area.
    public GameObject Button_Pressed; // Reference to the pressed button GameObject of this area.
    public GameObject InfoCloud1; // Reference to the information cloud of this area.

    public static bool startedPlaying;

    AudioSource audioCloud1;
    // Use this for initialization
    void Start () {
        audioCloud1 = Button_Pressed.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other) // If the player steps on the button.
    {
        Button.SetActive(false); // Disactivate the button.
        Button_Pressed.SetActive(true); // Activate the pressed button.
        InfoCloud1.SetActive(true); // Activate the information cloud for this area.

        startedPlaying = true;
    }


}

