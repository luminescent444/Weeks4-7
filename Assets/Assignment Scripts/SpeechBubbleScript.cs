using Unity.VisualScripting;
using UnityEngine;

public class SpeechBubbleScript : MonoBehaviour
{
    public float timerCount;
    public float timerTotal = 3;
    public bool bubbleInstantiated = false;
    public GameObject speechBubble;
    public GameObject speechBubblePrefab;
    public Transform person;
    public GameObject personObj;
    public Vector3 bubbleSpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        person = personObj.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bubbleSpawn.y = person.transform.position.y +1.3f;
        bubbleSpawn.x = person.transform.position.x -0.5f;

        timerCount = timerCount + Time.deltaTime;

        //when its dead
        if (timerCount > timerTotal && bubbleInstantiated == false)
        {
            speechBubblePrefab = Instantiate(speechBubble,bubbleSpawn ,Quaternion.identity,person);
            bubbleInstantiated = true;
            timerCount = 0;
        }

        //when its instantiated
        if (timerCount > (timerTotal - 1) && bubbleInstantiated)
        {
            Destroy(speechBubblePrefab);
            bubbleInstantiated = false;
            timerCount = 0;
        }
    }
}
