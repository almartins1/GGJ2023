using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backMove : MonoBehaviour
{
    
    public GameObject preFab;
    private float a;

    void Start()
    {
        a = 1f;
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        //Tile movement
        transform.position += new Vector3(0, a * 10, 0) * Time.deltaTime;
        Debug.Log(transform.position);

        if (transform.position.y >= 20.0f)
        {
            transform.position = new Vector2(0, -20.0f);
        }

        if (Input.GetKeyDown(KeyCode.W)) Instantiate(preFab, new Vector3(Random.Range(-13.0f, 13.0f), -9, 0f), Quaternion.identity);
    }
}
