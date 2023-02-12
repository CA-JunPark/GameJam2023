using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    Rigidbody2D rgd;
    Collider2D collider2d;
    // Start is called before the first frame update
    void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // move left
        transform.position += Vector3.left * Time.deltaTime * CharacterMovement.characterSpeed;
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.layer == 6){
            rgd.gravityScale = 0;
            collider2d.isTrigger = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 7){
            Destroy(this.gameObject);
        }
    }
}
