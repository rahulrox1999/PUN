using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftInsideController : MonoBehaviour
{
    public GameObject floor1, floor2, floor3,floor4,floor5,floor6,floor7,floor8,floor9;
    bool inLift;
    private GameObject MainLift;

    public GameObject InsPanel;

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        MainLift = GameObject.Find("Lift");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1) && (inLift))
        {
            //Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor1.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.Alpha2) && (inLift))
        {
          //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor2.transform.position, Speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.Alpha3) && (inLift))
        {
            //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor3.transform.position, Speed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Alpha4) && (inLift))
        {
            //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor4.transform.position, Speed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Alpha5) && (inLift))
        {
            //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor5.transform.position, Speed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Alpha6) && (inLift))
        {
            //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor6.transform.position, Speed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Alpha7) && (inLift))
        {
            //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor7.transform.position, Speed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Alpha8) && (inLift))
        {
            //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor8.transform.position, Speed * Time.deltaTime);

        }


        if (Input.GetKey(KeyCode.Alpha9) && (inLift))
        {
            //  Debug.Log("WorkingFine");
            MainLift.transform.position = Vector3.MoveTowards(MainLift.transform.position, floor9.transform.position, Speed * Time.deltaTime);

        }


  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Inlift")
        {

            InsPanel.SetActive(true);
            inLift = true;
            Debug.Log("InsideLift");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        InsPanel.SetActive(false);
    }
}
