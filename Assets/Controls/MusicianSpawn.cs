using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicianSpawn : MonoBehaviour
{
    public GameObject musician;
    public static int capturedCount = 0;
    public static bool spawned;
    float timer = 5;
    public float NextSpawnTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 jukeBox = GameObject.Find("Character").transform.position;
        float initialX = jukeBox.x + 7.6f;
        transform.position = new Vector3(initialX,transform.position.y,0);
        Vector3 spawnPos = new Vector3(initialX, transform.position.y + 1,0);
        musician.transform.position = spawnPos;
       
        timer = NextSpawnTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!spawned){
            timer -= Time.fixedDeltaTime;
            if (timer < 0){
                Instantiate(musician);
            spawned = true;
            timer = NextSpawnTime;
            }   
        }
    }

    public void ResetTimer(){
        timer = NextSpawnTime;
    }
}
