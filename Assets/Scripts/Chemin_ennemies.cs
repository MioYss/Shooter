using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chemin_ennemies : MonoBehaviour

{

    public Transform parent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, parent.transform.position, .03f);
    }


}
