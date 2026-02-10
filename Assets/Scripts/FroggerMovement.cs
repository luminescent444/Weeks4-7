using UnityEngine;
using UnityEngine.InputSystem;

public class FroggerMovement : MonoBehaviour
{
    public Vector3 position;
    public float speed = 1;
    public Transform car;
    public float dist;
    public Vector3 playerStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerStart.y = -4.3f;
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position;

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            position.y += speed;
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            position.y -= speed;
        }
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            position.x -= speed;
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            position.x += speed;
        }

        transform.position = position;

    }

    public void CollisionCheck()
    {
        dist = Vector2.Distance(transform.position, car.position);
        if (dist < 1)
        {
            position = transform.position;

            //destroy car
            Destroy(car);

            //put player at start
            position = playerStart;

            transform.position = position;
        }
    }
}
