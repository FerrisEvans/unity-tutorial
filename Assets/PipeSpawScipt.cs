using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawScipt : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2.0F;
    private float timer = 0F;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0F;
        }
        
    }

    private void SpawnPipe()
    {
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
