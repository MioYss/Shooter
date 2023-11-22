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


    public void OnSummon(SplineContainer spline_to_follow)
    {
        mon_chemin = spline_to_follow;

        spa.Container = mon_chemin;
        spa.Play();
    }

}
