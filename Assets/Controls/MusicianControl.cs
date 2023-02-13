using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicianControl : MonoBehaviour
{
    bool hit = false;
    float initialX;
    float jukeBoxX;
    float interval;
    float nextPosX;
    bool spawning = true;
    AudioSource hitSound;
    Animator animator;

    AudioSource backgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        initialX = gameObject.transform.position.x;
        jukeBoxX = GameObject.Find("Character").transform.position.x;
        interval = (initialX - jukeBoxX) / 4;
        nextPosX = CalcNextPosX();
        hitSound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        backgroundMusic = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawning){
            transform.position += Vector3.left * Time.deltaTime * CharacterMovement.characterSpeed;
            if (transform.position.x <= nextPosX){
                spawning = false;
                nextPosX = CalcNextPosX();
            }
        }
        if (hit){
            transform.position += Vector3.left * Time.deltaTime * CharacterMovement.characterSpeed;
            animator.SetBool("Hit", true);
            if (transform.position.x <= nextPosX){
                animator.SetBool("Hit", false);
                hit = false;
                nextPosX = CalcNextPosX();
            }
        }
    }

    public void Hit(){
        hit = true;
        PlayHit();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 11){
            MusicianSpawn.capturedCount ++;
            MusicianSpawn.spawned = false;
            CharacterMovement.characterSpeed += 2;
            backgroundMusic.pitch *= 1.03f;
            Destroy(gameObject);
        }
    }

    float CalcNextPosX(){
        return transform.position.x - interval;
    }

    void PlayHit(){
        hitSound.Play();
    }
    
}
