using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Random = UnityEngine.Random;

public class Scroll : MonoBehaviour
{
    // Start is called before the first frame update


    public Button leftButton, rightButton;
    public static float verticalSpeed = 0.5f;
    public static float horizontalSpeed = 0f;
    [SerializeField] private Renderer backRendeerer;
    public static double MAX_speed;
    private float Result;



    public GameObject preFab;

    void Start()
    {
        horizontalSpeed = 0f;
        MAX_speed = 0.2;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A)) horizontalSpeed = -0.1f;
        else if (Input.GetKey(KeyCode.D)) horizontalSpeed = 0.1f;
        else horizontalSpeed = 0f;

        if (Input.GetKeyDown(KeyCode.W)) Instantiate(preFab, new Vector3(Random.Range(-13.0f, 13.0f), -9, 0f), Quaternion.identity);

        Result = Convert.ToSingle(System.Math.Sqrt(System.Math.Pow(MAX_speed, 2) - System.Math.Pow(horizontalSpeed, 2)));
        Debug.Log(horizontalSpeed);
        Debug.Log(Result);

        backRendeerer.material.mainTextureOffset += new Vector2(horizontalSpeed * Time.deltaTime, -Result * Time.deltaTime);


    }
}
