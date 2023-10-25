using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temps : MonoBehaviour
{
    //public float temps_avant_changement;
    //public float reset_temps;

    Vector2 position_depart;
    Vector2 position_mouvement;
    public float frequence_mouvement;
    public float distance_mouvement;

    // Start is called before the first frame update
    void Start()
    {
        //reset_temps = temps_avant_changement;
        position_depart = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Time.time > reset_temps)
        {


            temps_avant_changement = Time.time + reset_temps;

        } */


        SinMovement();
       
    }

    public bool  extrémité;

    private void SinMovement()
    {

        float sinByTime = Mathf.Sin(Time.time * frequence_mouvement);
        position_mouvement.x = position_depart.x + sinByTime* distance_mouvement;
        transform.position = new Vector2(position_mouvement.x, transform.position.y);
        if ((sinByTime <= -0.99f) || (sinByTime >= 0.99f))
        {
            if(extrémité == false)
            {
                transform.position += Vector3.down;
                extrémité = true;
            }
        }
        else
        {
            extrémité = false;
        }
    }

    
}
