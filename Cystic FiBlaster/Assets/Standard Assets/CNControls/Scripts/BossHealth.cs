using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour {

    public int HP = 80;
    public int scoreValue = 1000;
    public Canvas restartCanvas;
    public float speed = 2;
    bool isDead = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            transform.parent.gameObject.transform.position = Vector3.Lerp(transform.position, transform.position - Vector3.up * speed, 0.1f);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            HP--;
            CheckAlive();
        }
    }

    private void CheckAlive()
    {
        if (HP <= 0)
        {
            ScoreManager.score += scoreValue;
            isDead = true;
            restartCanvas.enabled = true;
        }
    }
}
