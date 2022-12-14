using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bee : MonoBehaviour
{
    static public Bee S;

    [Header("Set These")]
    public float speed = 1;

    [Header("Already Set")]
    public int totalLives = 3; //don't change this without changing ui
    public int currLevel = 1;

    private Image beeTop;
    private Image beeMid;
    private Image beeBot;

    private Rigidbody2D rb;
    private Vector2[] moves;
    private KeyCode[] arrows = new KeyCode[] {KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.UpArrow, KeyCode.DownArrow};
    private KeyCode[] keys = new KeyCode[] {KeyCode.A, KeyCode.D, KeyCode.W, KeyCode.S};
    private SpriteRenderer sprend;
    private AudioSource pop;

    private int facing = 1;
    private int livesLeft;
    private float xStart;
    private float yStart;

    void Start()
    {
        S = this;
        rb = GetComponent<Rigidbody2D>();
        sprend = GetComponent<SpriteRenderer>();
        pop = GetComponent<AudioSource>();
        moves = new Vector2[] {new Vector2(-speed, 0), new Vector2(speed, 0), new Vector2(0, speed), new Vector2(0, -speed)};
        beeTop = GameObject.Find("bee3").GetComponent<Image>();
        beeMid = GameObject.Find("bee2").GetComponent<Image>();
        beeBot = GameObject.Find("bee1").GetComponent<Image>();
        beeTop.enabled = true;
        beeMid.enabled = true;
        beeBot.enabled = true;
        livesLeft = totalLives;
        xStart = transform.position.x;
        yStart = transform.position.y;
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
            if (keyMove == 0 && facing != -1){
                facing = -1;
                sprend.flipX = false;
            }
            else if (keyMove == 1 && facing != 1){
                facing = 1;
                sprend.flipX = true;
            }
            basis = moves[keyMove];
            rb.velocity = speed * basis;
        }
        else{
            rb.velocity = basis;
        }
    }

    void OnCollisionEnter2D(Collision2D coll) {
        //Debug.Log(coll.gameObject.tag);
        if(coll.gameObject.tag == "redboxofdoom" || coll.gameObject.tag == "bomb") {
            //Destroy(this.gameObject);
            Vector3 ori = new Vector3(xStart, yStart, 0);
            livesLeft--;
            if (livesLeft == 2){
                beeTop.enabled = false;
                transform.position = ori;
            }
            else if (livesLeft == 1){
                beeMid.enabled = false;
                transform.position = ori;
            }
            else if (livesLeft == 0){
                beeBot.enabled = false;
                transform.position = ori;
            }
            else{
                SceneManager.LoadScene("GameOver");
            }
        }
        if(coll.gameObject.tag == "balloon") {
            pop.Play();
            Destroy(coll.gameObject);
            Score.S.BeeBalloon();
        }
    }
}
