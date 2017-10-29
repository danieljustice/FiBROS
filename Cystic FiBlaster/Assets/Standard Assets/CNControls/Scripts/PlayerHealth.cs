using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public static int playerHP = 10;
    public Text text;
    public Canvas restartCanvas;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "HP: " + playerHP;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Projectile")
        {
            Destroy(collision.gameObject);
            playerHP--;
            CheckAlive();
        }
    }

    private void CheckAlive()
    {
        if (playerHP <= 0)
        {
            text.text = "HP: " + playerHP;
            restartCanvas.enabled = true;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
