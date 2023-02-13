using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caught : MonoBehaviour
{
    AudioSource speedUpSound;
    Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        speedUpSound = GameObject.Find("SpeedUp").GetComponent<AudioSource>();
        scoreScript = GameObject.Find("Character").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 9){
            PlaySpeedUp();
            scoreScript.AddScore(100);
        }
    }

    void PlaySpeedUp(){
        speedUpSound.Play();
    }
}
