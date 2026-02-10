using UnityEngine;
using UnityEngine.UIElements;

public class CandyPrefab : MonoBehaviour
{
    public float speed = 0.1f;
    public float rotationSpeed = 0.1f;
    public Vector3 position;
    public float dist;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get object position
        position = transform.position;

        //add speed to transform
        position.y -= speed;

        //do rotation
        position.z += rotationSpeed;

        //correct the object position
        transform.position = position;

        if (position.y < -6)
        {
            Object.Destroy(gameObject);
        }
    }

    public void CollisionCheck ()
    {
        
    }
}
