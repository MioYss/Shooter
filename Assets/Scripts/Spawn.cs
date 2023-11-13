using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform parent;
    public GameObject ennemi;
    public int nombre_ennemi = 0;
    public int starting_point_x;
    public int starting_point_y;

    /*public void GenerateObject()
    {
        for (int i = 0; i < 3; i++)
            Instantiate(ennemi, parent.position + Vector3.right * Random.Range(0f, 15f), parent.rotation);*/

    public void GenerateObject()
          {
              for (int j = starting_point_y; j <= 4; j+=2)
              {
                  for (int i = starting_point_x; i < 5; i+=2)
                  {
                        Instantiate(ennemi, new Vector3(1 + (1.8f * i), 0.8f * j, 0), Quaternion.identity);
                  }
              }
          }
    
}
