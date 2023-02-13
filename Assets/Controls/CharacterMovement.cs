using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static float characterSpeed;
    public float speed;

    AudioSource backgroundMusic;
    float delta;
    // Start is called before the first frame update
    void Start()
    {
        characterSpeed = speed;
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.J)){
         backgroundMusic.pitch *= 1.03f;
       }
    }

}
