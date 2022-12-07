using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{

    [Header("Set These")]
    public float speed = 1;

    [Header("Already Set")]
    private Vector3[] moves = new Vector3[] {
        Vector3.left, Vector3.right, Vector3.up, Vector3.down
    };
    private KeyCode[] arrows = new KeyCode[] {KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.UpArrow, KeyCode.DownArrow};
    private KeyCode[] keys = new KeyCode[] {KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S};
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.KeyDown(KeyCode.A)) {

        }
        
    }
}
