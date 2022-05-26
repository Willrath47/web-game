using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Votext : MonoBehaviour
{
    public Text voitext;

    void Update()
    {
        


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            voitext.text = "10";

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            voitext.text = "15";

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            voitext.text = "20";

        }
        
    }

}
