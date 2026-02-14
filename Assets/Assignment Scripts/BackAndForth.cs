using UnityEngine;

public class BackAndForth : MonoBehaviour
{
    //creating variables

    //variables for the speed and position of the person
    public float speed;
    public Vector3 position;

    void Start()
    {
        //set the speed to its default value
        speed = 0.5f;
    }

    void Update()
    {
        //get the person's position
        position = transform.position;

        //if its outside the bounds of the screen
        if (position.x < -7.5 || position.x > 7.5)
        {
            //switch the speed to go the opposite direction
            speed = speed * -1;
        }


        //add the speed to the transform
        position.x += speed * Time.deltaTime;

        //correct the object position
        transform.position = position;
    }
}
