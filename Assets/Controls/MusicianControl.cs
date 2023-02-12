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

    // Start is called before the first frame update
    void Start()
    {
        initialX = gameObject.transform.position.x;
        jukeBoxX = GameObject.Find("Character").transform.position.x;
        interval = (initialX - jukeBoxX) / 4;
        nextPosX = CalcNextPosX();
        
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
            if (transform.position.x <= nextPosX){
                hit = false;
                nextPosX = CalcNextPosX();
            }
        }
    }

    public void Hit(){
        hit = true;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 11){
            Destroy(gameObject);
            MusicianSpawn.capturedCount ++;
            MusicianSpawn.spawned = false;
        }
    }

    float CalcNextPosX(){
        return transform.position.x - interval;
    }
    
}
