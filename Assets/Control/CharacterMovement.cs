using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static float characterSpeed;
    public float speed;

    float delta;
    // Start is called before the first frame update
    void Start()
    {
        characterSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            speed += 1;
        }
        if (characterSpeed != speed ){
            characterSpeed = speed;
        }

    }

}
