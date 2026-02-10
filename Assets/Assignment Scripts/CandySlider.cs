using UnityEngine;
using UnityEngine.UI;

public class CandySlider : MonoBehaviour
{
    public Slider slider;
    public Vector3 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLocation(float sliderValue)
    {
        //get object position
        position = transform.position;

        //add speed to transform
        position.x = sliderValue;

        //correct the object position
        transform.position = position;
    }
}
