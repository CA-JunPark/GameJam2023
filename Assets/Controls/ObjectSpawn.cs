using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject contract;
    public GameObject objectDisc;
    public GameObject obstacle;

    // float timer = 0;

    [Tooltip("second")]
    public float interval = 2;
    public float obstacleInterval = 4;
    private float initialInterval;
    private float initialObstacleInterval;
    
    float[] grid;
    int cellNum;

    float spawnX;

    float spawnY;
    int randInt;
    int rand;
    int ceiling;

    // Start is called before the first frame update
    void Start()
    {
        GridController groundController = GameObject.Find("ground").GetComponent<GridController>();
        grid = groundController.grid;
        cellNum = groundController.cellNum;
        spawnX = GameObject.Find("UpperBound").transform.position.x;
        ceiling = 0;
        initialInterval = interval;
        initialObstacleInterval = obstacleInterval;
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;
        obstacleInterval -= Time.deltaTime;
        if (interval < 0){
            randInt = (int)(Random.Range(3,cellNum) - 1.1);
            spawnY = grid[randInt];
            rand = Random.Range(0,10);
            if (rand < 9 & ceiling < 10){
                contract.transform.position = new Vector3(spawnX, spawnY);
                Instantiate(contract);
                ceiling ++;
            }
            else{
                objectDisc.transform.position = new Vector3(spawnX, spawnY);
                Instantiate(objectDisc);
                ceiling = 0;
            }
            interval = initialInterval;
        }

        if (obstacleInterval < 0){
            obstacle.transform.position = new Vector3(spawnX, grid[1]);
            Instantiate(obstacle);
            obstacleInterval = Mathf.Clamp(initialObstacleInterval + Random.Range(-2,2), initialInterval - 1, initialInterval + 1);
        }
    }
}
