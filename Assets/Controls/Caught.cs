using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caught : MonoBehaviour
{
    AudioSource speedUpSound;
    // Start is called before the first frame update
    void Start()
    {
        speedUpSound = GameObject.Find("SpeedUp").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //9

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 9){
            PlaySpeedUp();
        }
    }

    void PlaySpeedUp(){
        speedUpSound.Play();
    }
}
