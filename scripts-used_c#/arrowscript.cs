using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowscript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private AudioSource bass;
    bool hasHit= false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
            
        }

        if (hasHit == false)
        {
            TrackMovement();

        }
    }

    void TrackMovement()
    {
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

       // Debug.Log(angle);

    }



    void OnCollisionEnter2D(Collision2D col)
    {
        hasHit = true;
        rb.isKinematic = true;
        rb.velocity = Vector2.zero;
        bass.Play ();

    }
}

