using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicianSpawn : MonoBehaviour
{
    public GameObject musician1;
    public GameObject musician2;
    // public GameObject musician3;
    public static int capturedCount = 0;
    private bool[] spawned;

    // Start is called before the first frame update
    void Start()
    {
        spawned = new bool[3];
        Vector3 jukeBox = GameObject.Find("Character").transform.position;
        float initialX = jukeBox.x + 7.6f;
        transform.position = new Vector3(initialX,transform.position.y,0);
        Vector3 spawnPos = new Vector3(initialX, transform.position.y + 1,0);
        musician1.transform.position = spawnPos;
        musician2.transform.position = spawnPos;
        // musician3.transform.position = spawnPos;

    }

    // Update is called once per frame
    void Update()
    {
        if (capturedCount == 0){
            if (!spawned[0]){
                Instantiate(musician1);
                spawned[0] = true;
            }
        }
        else if (capturedCount == 1){
            if (!spawned[1]){
                Instantiate(musician2);
                spawned[1] = true;
            }
        }
        // else{
        //     if (!spawned[2]){
        //         Instantiate(musician2);
        //         spawned[2] = true;
        //     }
        // }
    }
}
