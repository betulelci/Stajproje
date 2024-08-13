using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointController1 : MonoBehaviour
{
    void Start()
    {
        DataBase.LoadData();
        if (DataBase.SpownPosition == Vector3.zero)
        {
            DataBase.SpownPosition = transform.position;
            Debug.Log("SpownPosition = Vector3.Zero");
        }
        transform.position = DataBase.SpownPosition;

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.position = DataBase.SpownPosition;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            DataBase.SpownPosition = Vector3.zero;
            DataBase.SaveData();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CheckPointArea")
        {
            DataBase.SpownPosition = other.transform.position;
            DataBase.SaveData();

        }
    }




}
