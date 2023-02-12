using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDiscControl : MonoBehaviour
{
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
        if (collider.gameObject.layer == 8 || collider.gameObject.layer == 7){
            Destroy(this.gameObject);
            Shooting.loaded = true;
        }
    }
}
