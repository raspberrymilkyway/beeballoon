using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinky : RedBoxOfDoom
{
    private bool moveY = true;
    private bool moveX = false;

    public override void Move(){
        Vector3 tempPos = pos;
        if (pos.x > maxX){
            tempPos.x = maxX;
            pos = tempPos;
            directionY = -1;
            moveY = true;
            moveX = false;
        }
        else if (pos.x < minX){
            tempPos.x = minX;
            pos = tempPos;
            directionY = 1;
            moveY = true;
            moveX = false;
        }
        else if (pos.y > maxY){
            tempPos.y = maxY;
            pos = tempPos;
            directionX = 1;
            moveY = false;
            moveX = true;
        }
        else if (pos.y < minY){
            tempPos.y = minY;
            pos = tempPos;
            directionX = -1;
            moveY = false;
            moveX = true;
        }

        if (moveY && directionY == 1){        //up
            tempPos.y += speed;
            pos = tempPos;
        }
        else if (moveY && directionY == -1){  //down
            tempPos.y += speed * directionY;
            pos = tempPos;
        }
        if (moveX && directionX == 1){        //right
            tempPos.x += speed;
            pos = tempPos;
        }
        else if (moveX && directionX == -1){  //left
            tempPos.x += speed * directionX;
            pos = tempPos;
        }
    }
}
