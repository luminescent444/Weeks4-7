using UnityEngine;
using UnityEngine.UIElements;

public class CandyPrefab : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationSpeed = 0.1f;
    public Vector3 position;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get object position
        position = transform.position;


        


        //add speed to transform
        position.y += speed;

        //correct the object position
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
