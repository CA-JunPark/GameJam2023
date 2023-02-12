using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    AudioSource collectSound;
    // Start is called before the first frame update
    void Start()
    {
        collectSound = GameObject.Find("Collect").GetComponent<AudioSource>();
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
            PlayCollect();
        }
    }
}
