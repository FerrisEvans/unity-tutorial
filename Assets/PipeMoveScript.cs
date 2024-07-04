using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // If we give it a value here, It will fill this as the default value in Unity.
    public float moveSpeed = 5.0F;
    public float deadZone = -45F;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (Time.deltaTime * moveSpeed);
        if (transform.position.x < deadZone)
        {
            // Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }
}
