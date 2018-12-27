using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScoreCount : MonoBehaviour {

    public GameObject scorecount; // Reference to the scorecount GameObject.
    public GameObject coin; // Reference to the coin GameObject.
    Text scorecountText; // Reference to the Text componement attached.

	// Use this for initialization
	void Start () {
        scorecountText = scorecount.GetComponent<Text>(); //Set "scorecountText" to the text componement attached.
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        CameraController.score += 1; // Take the score and add 1 to it.
        scorecountText.text = CameraController.score.ToString(); // Update the score text.
        coin.SetActive(false); // Disactivate the coin.
    }   
}
