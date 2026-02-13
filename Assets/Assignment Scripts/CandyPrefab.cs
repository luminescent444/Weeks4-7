using UnityEngine;
using UnityEngine.UIElements;

public class CandyPrefab : MonoBehaviour
{
    float speed = 3f;
    public float rotationSpeed = 10f;
    public Vector3 position;
    public Vector3 rotation;

    //for collsiions
    public float dist;
    public GameObject player;
    public float score;

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
        position.y -= speed * Time.deltaTime;

        //do rotation
        rotation = transform.eulerAngles;
        rotation.z += rotationSpeed; 
        transform.eulerAngles = rotation;

        //correct the object position
        transform.position = position;

        if (position.y < -6)
        {
            Object.Destroy(gameObject);
        }

        CollisionCheck();
    }

    public void CollisionCheck()
    {
        //dist = Vector2.Distance(transform.position, player.position);
        //if (dist < 1)
        //{
        //    Destroy(gameObject);
        //    score += 1;
        //}
    }
}
