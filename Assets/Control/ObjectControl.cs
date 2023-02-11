using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move left
        transform.position += Vector3.left * Time.deltaTime * CharacterMovement.characterSpeed;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Character"){
            Destroy(this.gameObject);
        }
        //TODO????
        if (collider.gameObject.layer == 7){
            Destroy(this.gameObject);
        }
    }
}
