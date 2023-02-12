using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscControl : MonoBehaviour
{
    float relativeSpeed = 1.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move right
        transform.position += Vector3.right * Time.deltaTime * CharacterMovement.characterSpeed * relativeSpeed;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // destroy 
        if (collider.gameObject.layer == 9 || collider.gameObject.layer == 7){
            Destroy(this.gameObject);
        }

        if (collider.gameObject.layer == 9){
            collider.gameObject.GetComponent<MusicianControl>().Hit();
        }
    }
}
