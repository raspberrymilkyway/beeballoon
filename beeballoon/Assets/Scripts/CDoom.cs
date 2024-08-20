using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDoom : MonoBehaviour
{
    [Header("Set Me")]
    public float maxTopX = 10.0f;
    public float maxBotX = 10.0f;
    public float maxY = 10.0f;
    public float minX = 10.0f;
    public float minY = 10.0f;
    public float speed = 1.0f;

    private int directionX = 1;
    private int directionY = 1;
    private bool yMove = true;

    public Vector3 pos{
        get { return(this.transform.position); }
        set { this.transform.position = value; }
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move(){
        if (pos.y > maxY){
            directionY = -1;
            yMove = false;
            Vector3 tempPos = pos;
            tempPos.y = maxY;
            pos = tempPos;
        }
        else if (pos.y < minY){
            directionY = 1;
            yMove = false;
            Vector3 tempPos = pos;
            tempPos.y = minY;
            pos = tempPos;
        }
        
        if (pos.x > maxTopX && directionY == -1){
            directionX = -1;
            Vector3 tempPos = pos;
            tempPos.x = maxTopX;
            pos = tempPos;
        }
        else if (pos.x > maxBotX && directionY == 1){
            directionX = -1;
            Vector3 tempPos = pos;
            tempPos.x = maxBotX;
            pos = tempPos;
        }
        else if (pos.x < minX){
            directionX = 1;
            yMove = true;
            Vector3 tempPos = pos;
            tempPos.x = minX;
            pos = tempPos;
        }

        if (directionY == -1 && minX != maxTopX && !yMove){
            Vector3 tempPos = pos;
            tempPos.x += directionX * speed;
            pos = tempPos;
        }
        else if (directionY == 1 && minX != maxBotX && !yMove){
            Vector3 tempPos = pos;
            tempPos.x += directionX * speed;
            pos = tempPos;
        }
        else if (minY != maxY && yMove){
            Vector3 tempPos = pos;
            tempPos.y += directionY * speed;
            pos = tempPos;
        }
    }
}
