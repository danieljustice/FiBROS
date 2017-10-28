using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    public float scrollSpeed = 1.0f;
    public Transform startPosition;
    public float percentHorizontal = 1.0f;
    public float percentVertical = 0.0f;
    public Vector3 endMarker;

	// Use this for initialization
	void Start () {
        endMarker = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = new Vector3(percentHorizontal, percentVertical, 0.0f);
		endMarker = endMarker + direction * scrollSpeed;
        transform.position = Vector3.Lerp(transform.position, endMarker, 0.1f);
       // print(transform.position + direction);
	}

    public void reset()
    {
        endMarker = startPosition.position;
        transform.position = endMarker;
    }
}
