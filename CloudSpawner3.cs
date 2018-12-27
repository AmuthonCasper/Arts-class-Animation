using UnityEngine;
using System.Collections;
/// <summary>
/// For comments, look in the original "CloudSpawner" script.
/// </summary>
public class CloudSpawner3 : MonoBehaviour
{
    public GameObject Button3;
    public GameObject Button_Pressed3;
    public GameObject InfoCloud3;

    public static bool startedPlaying3;
    AudioSource audioCloud3;

    // Use this for initialization
    void Start()
    {
        audioCloud3 = Button_Pressed3.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Button3.SetActive(false);
        Button_Pressed3.SetActive(true);
        InfoCloud3.SetActive(true);

        startedPlaying3 = true;
    }
}

