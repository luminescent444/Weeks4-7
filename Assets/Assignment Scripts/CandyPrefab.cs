using UnityEngine;
using UnityEngine.UIElements;

public class CandyPrefab : MonoBehaviour
{
    //creating variables

    //variables for moving the candy
    float speed = 3f;
    public Vector3 position;

    //variables for spinning the candy
    public float rotationSpeed = 10f;
    public Vector3 rotation;

    void Start()
    {

    }

    void Update()
    {
        //get object position
        position = transform.position;

        //add speed to object's transform
        position.y -= speed * Time.deltaTime;

        //rotate the candy
        rotation = transform.eulerAngles;
        rotation.z += rotationSpeed; 
        transform.eulerAngles = rotation;

        //correct the object position
        transform.position = position;

        //if the candy falls below the bottom of the screen
        if (position.y < -6)
        {
            //destroy the instance
            Object.Destroy(gameObject);
        }
    }
}
