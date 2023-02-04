using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) speed = -5.0f;
        else if (Input.GetKey(KeyCode.D)) speed = 5.0f;
        else speed = 0f;

        transform.position += transform.right * speed * Time.deltaTime;
    }
}

