using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inky : RedBoxOfDoom
{
    [Header("Inky")]
    public float threshold = 0.2f;

    public override void Move(){
        float rand = Random.Range(0.0f, 1.0f);

        if (rand < threshold){
            directionX *= -1;
        }

        base.Move();
    }
}
