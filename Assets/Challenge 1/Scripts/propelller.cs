using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propelller : MonoBehaviour
{
    public float speed = 10.0f;
    private Vector3 offset = new Vector3(0, 2, 4);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // command for continuous rotation
        transform.Rotate(Vector3.forward * speed);
    }
}
