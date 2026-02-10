using UnityEngine;
using UnityEngine.UIElements;

public class MoveAcrossScreen : MonoBehaviour
{
    float speed = 0.02f;
    Vector3 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;

        position.x += speed;

        transform.position = position;

        if (position.x > 9)
        {
            Destroy(gameObject);
        }
    }
}
