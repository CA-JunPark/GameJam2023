using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject disc;
    public float offset = 1;
    public static bool loaded = false;
    GameObject discUI;

    // Start is called before the first frame update
    void Start()
    {
        GameObject lifes = GameObject.Find("lifes");
        discUI = lifes.transform.GetChild(3).gameObject;
        discUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (loaded){
            discUI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Z) || Input.GetMouseButton(1)){
                disc.transform.position = gameObject.GetComponent<BoxCollider2D>().bounds.center + (Vector3.right * offset);
                Instantiate(disc);
                loaded = false;
            }
        }
        else{
            discUI.SetActive(false);
        }
    }
}
