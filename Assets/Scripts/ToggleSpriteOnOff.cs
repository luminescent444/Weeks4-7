using UnityEngine;

public class ToggleSpriteOnOff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleShape()
    {

        gameObject.SetActive(!gameObject.activeInHierarchy);

    }

}
