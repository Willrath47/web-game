using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class bowscript : MonoBehaviour
{
    public Vector2 direction;

    public float force, angle, rad, xmax, vo, d, ymax;

    public double pie, gra;

    public GameObject PointPrefab;

    public GameObject[] Points;

    public int numberOfpoints;

    public Text angletext, textodis, textodisy, votext;

    // Start is called before the first frame update
    void Start()
    {

        if(GameObject.Find("point(Clone)") == null)
        {
            Points = new GameObject[numberOfpoints];
            for (int i = 0; i < numberOfpoints; i++)
           {
                Points[i] = Instantiate(PointPrefab, transform.position, Quaternion.identity);

            }
        }

        Points = new GameObject[numberOfpoints];
        for (int i = 0; i < numberOfpoints; i++)
        {
            Points[i] = Instantiate(PointPrefab, transform.position, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {

        Angulo();

        FaceMouse();

        if (Input.GetKeyDown(KeyCode.Space))
        //if (Input.GetMouseButtonDown(0))
        {

            Tiro();

        }
     

        if(GameObject.Find("point(Clone)") == null)
        {
            Points = new GameObject[numberOfpoints];
            for (int i = 0; i < numberOfpoints; i++)
            {
                Points[i] = Instantiate(PointPrefab, transform.position, Quaternion.identity);

            }
        }

        for (int i = 0; 1 < Points.Length; i++)
        {
            Points[i].transform.position = PointPosition(i * 0.1f);
        }

    }

    void Tiro()
    {

        d = 2;

        gra = 9.81;

        vo = 10;

        xmax = ((vo * vo) * Mathf.Sin(d * rad)) / (float)gra;

        /*xmax = (float)Math.Sin(d*45);*/

        ymax = ((vo * vo) * (Mathf.Sin(rad)) * (Mathf.Sin(rad))) / (d * (float)gra);

        textodis.text = xmax.ToString();

        textodisy.text = ymax.ToString();

        votext.text = vo.ToString();

    }

    void Angulo()
    {

        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 bowPos = transform.position;

        direction = MousePos - bowPos; //calculate the Direction

        rad = Mathf.Atan2(direction.y, direction.x);

        pie = 180 / 3.141592653589793238463;

        angle = rad * (float)pie;

        angletext.text = angle.ToString();

        /*Debug.Log(angle);*/

    }

    void FaceMouse()
    {
        transform.right = direction;

    }

    /*void TrackMovement()
    {

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        Debug.Log(angle);

    }*/

    Vector2 PointPosition(float t)
    {
        Vector2 currentPointPos = (Vector2)transform.position + (direction.normalized * force * t) + 0.5f * Physics2D.gravity * (t * t);
        return currentPointPos;

        /*Debug.Log(currentPointPos);*/

    }
}