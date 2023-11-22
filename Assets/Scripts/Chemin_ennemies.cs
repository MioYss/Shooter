using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;

public class Chemin_ennemies : MonoBehaviour

{

    public Transform parent;
    public GameObject ennemie;
    public SplineContainer mon_chemin;
    public SplineAnimate spa;


    public void OnSummon(SplineContainer splineToFollow)
    {
        mon_chemin = splineToFollow;

        spa.Container = mon_chemin;
        spa.Play();
    }

}
