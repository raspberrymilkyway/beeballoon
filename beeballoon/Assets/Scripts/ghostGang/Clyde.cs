using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clyde : RedBoxOfDoom
{
    [Header("Clyde")]
    public float midX = 10.0f;
    public float midY = 10.0f;

    private bool moveX = true;
    private bool middleX = true;
    private bool middleY = false;

    //this is. repetitive. alas
    public override void Move(){
        Vector3 tempPos = pos;
        if (directionX == -1 && middleX && moveX){
            if (pos.x <= midX){
                tempPos.x = midX;
                pos = tempPos;
                middleX = false;
                directionY = -1;
                moveX = false;
            }
            else{
                tempPos.x += speed * directionX;
                pos = tempPos;
            }
        }
        else if (directionX == -1 && moveX){
            if (pos.x <= minX){
                tempPos.x = minX;
                pos = tempPos;
                middleY = true;
                directionY = 1;
                moveX = false;
            }
            else{
                tempPos.x += speed * directionX;
                pos = tempPos;
            }
        }
        else if (directionY == 1 && middleY && !moveX){
            if (pos.y >= midY){
                tempPos.y = midY;
                pos = tempPos;
                middleY = false;
                directionX = 1;
                moveX = true;
            }
            else{
                tempPos.y += speed * directionY;
                pos = tempPos;
            }
        }
        else if (directionY == 1 && !moveX){
            if (pos.y >= maxY){
                tempPos.y = maxY;
                pos = tempPos;
                middleX = true;
                directionX = -1;
                moveX = true;
            }
            else{
                tempPos.y += speed * directionY;
                pos = tempPos;
            }
        }
        else if (directionY == -1 && !moveX){
            if (pos.y <= minY){
                tempPos.y = minY;
                pos = tempPos;
                middleX = false;
                directionX = -1;
                moveX = true;
            }
            else{
                tempPos.y += speed * directionY;
                pos = tempPos;
            }
        }
        else if (directionX == 1 && moveX){
            if (pos.x >= maxX){
                tempPos.x = maxX;
                pos = tempPos;
                middleY = false;
                directionY = 1;
                moveX = false;
            }
            else{
                tempPos.x += speed * directionX;
                pos = tempPos;
            }
        }
        else{
            Debug.Log("forgot a movement, ig");
        }
    }
}
