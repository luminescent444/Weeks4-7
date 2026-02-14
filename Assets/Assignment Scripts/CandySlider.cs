using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CandySlider : MonoBehaviour
{
    //creating variables 

    //stores the slider's values
    public Slider slider;

    //stores the position of the handle
    public Vector3 position;

    //stores the prefab
    public GameObject candyPrefab;

    //stores the position of the person
    public Transform person;

    //stores the position of the currently spawned prefab
    public GameObject currentPrefab;

    //position that the prefab spawns at
    public Vector3 spawnPos;

    //stores the distance between the person and prefab 
    public float dist;

    //variables for the score text
    public float score;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        //set the y value that the prefabs spawn at
        spawnPos.y = 4;
    }

    void Update()
    {
        //check if theres a collision
        CollisionCheck();

        //update the text that shows the score
        scoreText.text = "Score: " + score;

    }

    //function to update the location of the candy indicator on the top
    public void SetLocation(float sliderValue)
    {
        //get handle's position
        position = transform.position;

        //set the x's transform = to the value of the slider
        position.x = sliderValue;

        //correct the object position
        transform.position = position;

        //set the prefab spawn position = to the slider value
        spawnPos.x = sliderValue; 
    }

    //function to spawn in a prefab when the button is pressed
    public void Spawn()
    {
        //spawn the prefab at the location set by the slider
        currentPrefab = Instantiate(candyPrefab,spawnPos, Quaternion.identity);
    }

    //function to check for a collision between the person and the candy prefabs
    public void CollisionCheck()
    {
        //find the distance between the person and candy
        dist = Vector2.Distance(currentPrefab.transform.position, person.position);
        
        //if theyre too close together
        if (dist < 1.3)
        {
            //destroy the candy
            Destroy(currentPrefab);

            //add 1 to the score
            score += 1;
        }
    }
}