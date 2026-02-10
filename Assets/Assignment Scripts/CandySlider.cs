using UnityEngine;
using UnityEngine.UI;

public class CandySlider : MonoBehaviour
{
    public Slider slider;
    public Vector3 position;
    public GameObject candy;
    public Vector3 spawnPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos.y = 4;
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

        spawnPos.x = sliderValue; 
    }

    public void Spawn()
    {
        Instantiate(candy,spawnPos, Quaternion.identity);
    }
}
