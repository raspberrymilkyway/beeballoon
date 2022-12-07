using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bee : MonoBehaviour
{
    static public Bee S;

    [Header("Set These")]
    public float speed = 1;

    [Header("Already Set")]
    private Rigidbody rb;
    private Vector3[] moves;
    private KeyCode[] arrows = new KeyCode[] {KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.UpArrow, KeyCode.DownArrow};
    private KeyCode[] keys = new KeyCode[] {KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S};
    
    void Start()
    {
        S = this;
        rb = GetComponent<Rigidbody>();
        moves = new Vector3[] {new Vector3(-speed, 0, 0), new Vector3(speed, 0, 0), new Vector3(0, speed, 0), new Vector3(0, -speed, 0)};
        
    }

    
    private void Update()
    {
        int keyMove = -1;

        for(int i = 0; i < 4; i++) {
            if(Input.GetKey(arrows[i])) keyMove = i;
            if(Input.GetKey(keys[i])) keyMove = i;
        }

        Vector3 basis = Vector3.zero;

        if(keyMove > -1) {
            basis = moves[keyMove];
            rb.velocity = speed * basis;
        }
        else{
            rb.velocity = basis;
        }
    }

    void OnCollisionEnter(Collision coll) {
        if(coll.gameObject.tag == "redboxofdoom" || coll.gameObject.tag == "bomb") {
            //Destroy(this.gameObject);
            SceneManager.LoadScene("level-1");
        }
    }
}
