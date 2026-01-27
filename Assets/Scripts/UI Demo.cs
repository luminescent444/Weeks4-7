using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    SpriteRenderer sr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            ColorChanger();
        }
        

    }

    public void ColorChanger()
    {
        sr.color = Random.ColorHSV();
    }

    public void SetScale(float scale)
    {

        transform.localScale = Vector3.one * scale;
        //scale is set in the buttons inspector

    }
}
