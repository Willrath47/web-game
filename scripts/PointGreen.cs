using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGreen : MonoBehaviour
{

    public int selectedSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {

            Destroy(gameObject);

        }
                
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {

            Destroy(gameObject);

        }
    }
}
