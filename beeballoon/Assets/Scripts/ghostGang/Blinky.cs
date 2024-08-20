using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinky : RedBoxOfDoom
{
    [Header("Blinky")]
    public bool xMove = true;

    public override void Move(){
        Vector3 tempPos = pos;
        if (pos.x > maxX && xMove){
            tempPos.x = maxX;
            pos = tempPos;
            xMove = false;
            directionY = -1;
        }
        else if (pos.x < minX && xMove){
            tempPos.x = minX;
            pos = tempPos;
            xMove = false;
            directionY = -1;
        }
        else if (pos.y > maxY && !xMove){
            tempPos.y = maxY;
            pos = tempPos;
            xMove = true;
            directionX *= -1;
        }
        else if (pos.y < minY && !xMove){
            tempPos.y = minY;
            pos = tempPos;
            directionY = 1;
        }
        else if (xMove){
            tempPos.x += speed * directionX;
            pos = tempPos;
        }
        else{
            tempPos.y += speed * directionY;
            pos = tempPos;
        }
    }
}
