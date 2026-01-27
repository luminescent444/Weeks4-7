using UnityEngine;

public class PrefabSpawn : MonoBehaviour

{
    public GameObject pre;
    Vector3 randompos;
    Vector3 mousepos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousepos = Camera.main.ScreenToWorldPoint(mousepos.current.position.ReadValue());
    }

    public void Spawn ()
    {

        Instantiate(pre,mousepos);

    }
}
