using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject car;
    float timerCount;
    float timerLimit = 0.5f;
    public Vector3 carStart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCount += Time.deltaTime;
        if (timerCount > timerLimit)
        {
            Spawn();
            timerCount = 0;
        }
    }

    public void Spawn()
    {
        carStart.y = Random.Range(-3, 3);
        carStart.x = -9;
        Instantiate(car, carStart, Quaternion.identity);
    }
}
