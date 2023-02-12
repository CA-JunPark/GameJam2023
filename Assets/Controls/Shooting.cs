using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    GameObject disc;
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        disc.transform.position = gameObject.transform.position + (Vector3.right * offset);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)){
            Instantiate(disc);
        }
    }
}
