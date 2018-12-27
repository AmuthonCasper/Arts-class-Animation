using UnityEngine;
using System.Collections;

public class SineWave : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;
    public float amplitude;

    private Vector2 tempPosition;
    private Vector2 startPosition;
    void Start () 
    {
        startPosition = transform.position;
        tempPosition = transform.position;
    }
 
    void FixedUpdate () 
    {
        tempPosition.x += horizontalSpeed;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude + startPosition.y;
        transform.position = tempPosition;
    }
}