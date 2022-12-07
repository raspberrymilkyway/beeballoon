using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
{

    [Header("Set These")]
    public float speed = 1;

    [Header("Already Set")]
    private Rigidbody rb;
    private Vector3[] moves = new Vector3[] {
        Vector3.left, Vector3.right, Vector3.up, Vector3.down
    };
    private KeyCode[] arrows = new KeyCode[] {KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.UpArrow, KeyCode.DownArrow};
    private KeyCode[] keys = new KeyCode[] {KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S};
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        keyMove = -1;

        for(int i = 0; i < 4; i++) {
            if(Input.GetKey(arrows[i])) keyMove = i;
            if(Input.Get(keys[i])) keyMove = i;
        }

        Vector3 base = Vector3.zero;
        if(keyMove > -1) {
            base = moves[keyMove];
            rb.velocity = speed * base;
        }
        
    }
}
