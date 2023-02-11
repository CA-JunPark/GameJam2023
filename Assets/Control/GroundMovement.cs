using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    Vector3 initialPos;
    Vector3 loopEnd;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        
        loopEnd = GameObject.Find("GroundLoopEnd").transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += Vector3.left * Time.deltaTime * CharacterMovement.characterSpeed;
        
        if (GetComponent<BoxCollider2D>().bounds.max.x < loopEnd.x){
            transform.position = initialPos;
        }
            
        
    }
}
