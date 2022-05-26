using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootarrpw2 : MonoBehaviour
{
    public float LaunchForce;
    [SerializeField] private AudioSource swoosh;

    public GameObject Arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        //if (Input.GetMouseButtonDown(0))
            {
            Shoot();
           
            swoosh.Play ();

        }
      
    }
    

    void Shoot()
    {
        GameObject ArrowIns = Instantiate(Arrow,transform.position,transform.rotation);

        ArrowIns.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;

    }
}
