using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeletor : MonoBehaviour

{   

    private Collider2D col;
    private Animator anim;
    private int hp;
    Rigidbody2D sb;
    [SerializeField] private AudioSource myah;


    // Start is called before the first frame update
    void Start()
    {

        sb = GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        col = GetComponent<Collider2D>();

        hp = 1;

    }

    // Update is called once per frame
    private void Update()
    {  

    }

    /*void OnCollisionEnter2D(Collision2D other)
    {

        hp = hp - 1;

        anim.SetInteger("Muricion",hp);

    }*/


    void OnTriggerEnter2D(Collider2D other)
    {

        hp = hp - 1;

        anim.SetInteger("Muricion",hp);

        myah.Play ();

    }

    private void SetAllCollidersStatus (bool active)
    {

        if(hp > 0)
        {
            
            foreach(Collider2D col in GetComponents<Collider2D> ()) {
            col.enabled = true;
            }
        }
        else
        {

            foreach(Collider2D col in GetComponents<Collider2D> ()) {
            col.enabled = false;
            }
        }


    }


}
