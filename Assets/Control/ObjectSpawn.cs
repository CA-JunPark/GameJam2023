using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject contract;

    // float timer = 0;

    [Tooltip("second")]
    public float interval = 2;
    
    float[] grid;
    int cellNum;

    float spawnX;

    float spawnY;

    // Start is called before the first frame update
    void Start()
    {
        GridController groundController = GameObject.Find("ground").GetComponent<GridController>();
        grid = groundController.grid;
        cellNum = groundController.cellNum;
        spawnX = GameObject.Find("UpperBound").transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;
        if (interval < 0){
            int randInt = (int)(Random.Range(3,cellNum) - 1.1);
            spawnY = grid[randInt];
            contract.transform.position = new Vector3(spawnX, spawnY);
            Instantiate(contract);
            interval = 2;
        }
    }
}
