using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rgb;
    public float power = 3;
    bool groundCheck;
    AudioSource jumpSound;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButton(0)){
            if (groundCheck) {
                PlaySound();
                rgb.velocity = Vector2.up * power;
            }

        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.layer == 6){
            groundCheck = true;
        }
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if (collider.gameObject.layer == 6){
            groundCheck = false;
        }
    }

    void PlaySound(){
        jumpSound.Play();
    }


}
