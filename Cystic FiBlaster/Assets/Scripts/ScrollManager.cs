using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollManager : MonoBehaviour {

    //public BackgroundScroll[] backgrounds;
	public BackgroundScroll[] backgrounds;
    public float scrollTime = 1;
    private int backgroundIndex = 0;

    private float startTime;
    private float resetTime;
	// Use this for initialization
	void Start () {
        startTime = Time.time;
        resetTime = startTime + scrollTime; 
        for(int i = 0; i < backgrounds.Length; i++)
        {
            float scrollSpeed = backgrounds[i].scrollSpeed;
            float scrollFraction = .1f;
            backgrounds[i].reset();

			//UGLY HARD CODE that properly gets the backgrounds to collate
			Vector3 offset = new Vector3((backgrounds.Length-i) *30 * scrollSpeed * scrollTime, 0.0f, 0.0f);
            backgrounds[i].transform.position = backgrounds[i].transform.position + offset;
			backgrounds[i].endMarker = backgrounds[i].transform.position + offset;
			print (backgrounds [i].transform.position + offset);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(resetTime < Time.time)
        {
            int len = backgrounds.Length;
            backgrounds[backgroundIndex].reset();
            backgroundIndex = (backgroundIndex + 1) % len;
            resetTime = Time.time + scrollTime;
        }
	}
}
