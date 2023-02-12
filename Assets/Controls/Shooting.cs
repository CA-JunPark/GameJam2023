using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject disc;
    public float offset = 1;
    public static bool loaded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)){
            if (loaded){
                disc.transform.position = gameObject.GetComponent<BoxCollider2D>().bounds.center + (Vector3.right * offset);
                Instantiate(disc);
            }
        }
    }
}
