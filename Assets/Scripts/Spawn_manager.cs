using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_manager : MonoBehaviour
{

    public Spawn spawnOne;
    public Spawn spawnTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<Drop_ennemies>() == false)
        {
            spawnOne.GenerateObject();
            spawnTwo.GenerateObject();
        }
    }
}
