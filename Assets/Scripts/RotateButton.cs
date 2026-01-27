using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class RotateButton : MonoBehaviour
{

    public float speed = 2;
    public Vector3 rotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make shape rotate by adding speed to euler angles
        rotation = transform.eulerAngles;
        rotation.z += speed * Time.deltaTime;
        transform.eulerAngles = rotation;  

    }

    public void StartSpin()
    {
        //if spinning set speed to 100
        speed = 100;
    }

    public void StopSpin()
    {
        //if not spinning set speed to 0
        speed = 0;
    }

}
