using UnityEngine;

public class SpeedSwitching : MonoBehaviour

{

    public int selectedSpeed = 0;
    [SerializeField] private AudioSource power;

    // Start is called before the first frame update
    void Start()
    {
        SelectSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
        int previousSelectedSpeed = selectedSpeed;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            selectedSpeed = 0;

        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount>=2)
        {

            selectedSpeed = 1;

        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount>=3)
        {

            selectedSpeed = 2;

            power.Play ();

        }
        
        if (previousSelectedSpeed != selectedSpeed)
        {

            SelectSpeed();

        }



    }

    void SelectSpeed()
    {

        int i = 0; 
        foreach (Transform speed in transform)
        {

            if (i == selectedSpeed)
                speed.gameObject.SetActive(true);
            
            else
                speed.gameObject.SetActive(false);

            i++;

        }

    }
}
