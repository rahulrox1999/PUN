using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftButtons : MonoBehaviour
{
    public GameObject Floor1;
    public GameObject Floor2,F3,F4,F5,F6,F7,F8,F9;
    public GameObject InsToCall;
    private GameObject Lift;

    bool In1stFloor,In2ndFloor,In3,In4,In5,In6,In7,In8,In9,In10;

    public float Speed;



    // Start is called before the first frame update
    void Start()
    {
        Lift = GameObject.Find("Lift");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In1stFloor) )
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, Floor1.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In2ndFloor))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, Floor2.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In3))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F3.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In4))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F4.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In4))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F4.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In5))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F5.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In6))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F6.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In7))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F7.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In8))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F8.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.J) && (In9))
        {
            Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, F9.transform.position, Speed * Time.deltaTime);

        }

        //  transform.position = Vector3.MoveTowards(transform.position, Floor1.transform.position, Speed * Time.deltaTime);

    }

    public void CalledLift()
    {
        // transform.position = Vector3.MoveTowards(transform.position, Floor1.position, Speed);

        Lift.transform.position = Vector3.MoveTowards(Lift.transform.position, Floor1.transform.position, Speed * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "1")
        {
            InsToCall.SetActive(true);
            In1stFloor = true;
       
        }

        if (other.gameObject.tag == "2")
        {
            In2ndFloor = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "3")
        {
            In3 = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "4")
        {
            In4 = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "5")
        {
            In5 = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "6")
        {
            In6 = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "7")
        {
            In7 = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "8")
        {
            In8 = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "9")
        {
            In9 = true;
            InsToCall.SetActive(true);
        }

        if (other.gameObject.tag == "10")
        {
            In10 = true;
            InsToCall.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        InsToCall.SetActive(false);
        In1stFloor = false;
        In2ndFloor = false;


    }


}
