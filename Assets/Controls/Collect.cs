using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    AudioSource collectSound;
    Score scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        collectSound = GameObject.Find("Collect").GetComponent<AudioSource>();
        scoreScript =GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayCollect(){
        collectSound.Play();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 12){
            scoreScript.AddScore(10);
            PlayCollect();
        }
    }
}
