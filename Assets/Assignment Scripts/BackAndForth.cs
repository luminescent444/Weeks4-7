using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    public float speed;
    public Vector3 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        //get object position
        position = transform.position;


        if (position.x < -7.5 || position.x > 7.5)
        {
            speed = speed * -1;
        }


        //add speed to transform
        position.x += speed;

        //correct the object position
        transform.position = position;
    }
}
