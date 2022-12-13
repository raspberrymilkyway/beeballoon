using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Transform mc;
    public GameObject emi;
    public float range;
    public float attack;
    public float speed;
    public AudioSource ouchie;

    private Animator anime;
    private SpriteRenderer sprend;
    private CapsuleCollider2D boxer;

    // Start is called before the first frame update
    void Start()
    {
        name = this.gameObject.name;

        range = 6;
        attack = 2;
        speed = 1;


        anime = GetComponent<Animator>();
        sprend = GetComponent<SpriteRenderer>();
        boxer = GetComponent<CapsuleCollider2D>();
        ouchie = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(mc.position, transform.position) <= range) {
            transform.position = Vector2.MoveTowards(transform.position, mc.position, speed*Time.deltaTime);

            if(Vector3.Distance(mc.position, transform.position) <= attack) {
            anime.CrossFade(name+"-kaboom", 0);
            anime.speed = 1;
            }
            else {
            anime.CrossFade(name, 0);
            anime.speed = 1;
            }
        }
        else {
            anime.CrossFade(name+"-static", 0);
            anime.speed = 1;
        }
    }

    void OnCollisionEnter2D(Collision2D Col)
    {
        if(Col.gameObject.name == "bee") {
            ouchie.Play(0);
            
        }
    }
}
