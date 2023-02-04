using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=UnityEngine.Random;

public class preFabUp : MonoBehaviour
{
    private float a;
    // Start is called before the first frame update
    void Start()
    {
        a = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-Scroll.horizontalSpeed*100, a*10, 0) * Time.deltaTime;

       if (transform.position.y >= 9)
        {
            Destroy(gameObject);
        }
    }
}
