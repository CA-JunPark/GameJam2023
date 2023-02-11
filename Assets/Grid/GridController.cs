using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public float[] grid;
    private float lowerBound;
    private float upperBound;
    public int cellNum = 10;
    // Start is called before the first frame update
    void Awake()
    {
        upperBound = GameObject.Find("UpperBound").transform.position.y;
        lowerBound = GetComponent<BoxCollider2D>().bounds.max.y;
        float interval = ((upperBound - lowerBound) / cellNum);
        grid = new float[cellNum];
        for (int i = 0; i < grid.Length; i ++){
            grid[i] = lowerBound + (i * interval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
