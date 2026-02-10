using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TempBackAndForth : MonoBehaviour
{
    public float speed = 0.02f;
    Vector3 position;
    float dist;
    public Vector3 playerStart;
    public Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;

        position.x += speed;

        transform.position = position;

        if (position.x > 9 || position.x < -9)
        {
            speed = speed *-1;
        }
    }

    

}
