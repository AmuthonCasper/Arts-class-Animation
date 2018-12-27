using UnityEngine;
using System.Collections;
/// <summary>
/// For comments, look in the original "CloudSpawner" script.
/// </summary>
public class CloudSpawner4 : MonoBehaviour
{
    public GameObject Button4;
    public GameObject Button_Pressed4;
    public GameObject InfoCloud4;

    public static bool startedPlaying4;
    AudioSource audioCloud4;

    // Use this for initialization
    void Start()
    {
        audioCloud4 = Button_Pressed4.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Button4.SetActive(false);
        Button_Pressed4.SetActive(true);
        InfoCloud4.SetActive(true);

        startedPlaying4 = true;
    }
}

