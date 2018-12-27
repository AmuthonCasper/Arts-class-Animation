using UnityEngine;
using System.Collections;
/// <summary>
/// For comments, look in the original "CloudSpawner" script.
/// </summary>
public class CloudSpawner2 : MonoBehaviour{
    public GameObject Button2;
    public GameObject Button_Pressed2;
    public GameObject InfoCloud2;

    public static bool startedPlaying2;
    AudioSource audioCloud2;

    // Use this for initialization
    void Start()
    {
        audioCloud2 = Button_Pressed2.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Button2.SetActive(false);
        Button_Pressed2.SetActive(true);
        InfoCloud2.SetActive(true);

        startedPlaying2 = true;
    }
}

