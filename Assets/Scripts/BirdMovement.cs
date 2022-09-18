using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    public AudioSource audio;
    public AudioClip  hit,point,wing;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(wing);
            rb.velocity = Vector2.up*velocity;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.PlayOneShot(hit);
        gameManager.GameOver();
    }
    void OnTriggerEnter2D(Collider2D col){
        audio.PlayOneShot(point);
        gameManager.addScore();
    }
}
