using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CandySlider : MonoBehaviour
{
    public Slider slider;
    public Vector3 position;
    public GameObject candy;
    public Transform person;
    public GameObject pre;
    public Vector3 spawnPos;
    public float dist;
    public float score;
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPos.y = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //pre = GetComponent<>
        CollisionCheck();
        scoreText.text = "Score: " + score;
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
        pre = Instantiate(candy,spawnPos, Quaternion.identity);
    }

    public void CollisionCheck()
    {
        dist = Vector2.Distance(pre.transform.position, person.position);
        if (dist < 1)
        {
            Destroy(pre);
            score += 1;
        }
    }
}


