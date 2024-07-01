using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float flapStrength;
    // Start is called before the first frame update.
    // It's for any code that will run as soon as this script is enabled. And it runs precisely once.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(new Vector3(0, 0, 90));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
        
        
    }
}
