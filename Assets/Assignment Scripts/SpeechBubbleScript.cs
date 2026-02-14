using Unity.VisualScripting;
using UnityEngine;

public class SpeechBubbleScript : MonoBehaviour
{
    //creating variables

    //variables for tracking the on/off
    public float timerCount;
    public float timerTotal = 3;
    public bool bubbleInstantiated = false;

    //gameobjects storing the bubble and bubble prefab/its spawn
    public GameObject speechBubble;
    public GameObject currentSpeechBubblePrefab;
    public Vector3 bubbleSpawn;

    //gameobjects storing the person and its transform
    public Transform person;
    public GameObject personObj;

    void Start()
    {
        //getting the transform of the person from it's object reference using getcomponent
        person = personObj.GetComponent<Transform>();
    }

    void Update()
    {
        //setting the values of where the bubble would spawn
        bubbleSpawn.y = person.transform.position.y +1.3f;
        bubbleSpawn.x = person.transform.position.x -0.5f;

        //increasing the timer each frame
        timerCount = timerCount + Time.deltaTime;

        //if the timer runs out when the bubble isnt visble
        if (timerCount > timerTotal && bubbleInstantiated == false)
        {
            //spawn the bubble a its spawn as a child of the person
            currentSpeechBubblePrefab = Instantiate(speechBubble,bubbleSpawn ,Quaternion.identity,person);
            
            //note that a bubble has been spawned 
            bubbleInstantiated = true;

            //reset the timer
            timerCount = 0;
        }

        //if the timer runs out when the bubble is visble
        if (timerCount > (timerTotal - 1) && bubbleInstantiated)
        {
            //destroy the bubble
            Destroy(currentSpeechBubblePrefab);

            //note that a bubble has been destroyed
            bubbleInstantiated = false;

            //reset the timer
            timerCount = 0;
        }
    }
}
