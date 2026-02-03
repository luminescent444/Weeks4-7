using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerValue = 0;
    public float timerMax = 10;
    public Slider timerVisuals;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerVisuals.maxValue = timerMax;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;

        if (timerValue > timerMax)
        {
            timerValue = 0;
        }

        timerVisuals.value = timerValue;
    
    }
}
