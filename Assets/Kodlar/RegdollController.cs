using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class RegdollController : MonoBehaviour
{
    // Start is called before the first frame update
    AnimatorController controller;
    void Start()
    {
        controller = GetComponent<AnimatorController>();
        FizikState(true);
        ColliderState(false);
        GetComponent<Animator>().enabled = true;
    }

    private void FizikState(bool state)
    {
        Rigidbody[] ChildRigidBodys = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody child in ChildRigidBodys)
        {
            child.isKinematic = state;
        }
    }

    private void ColliderState(bool state)
    {
        Collider[] ChildColliders = GetComponentsInChildren<Collider>();
        foreach (Collider child in ChildColliders)
        {
            child.enabled = state;
        }
    }
    public void EnterRagdoll()
    {
        Debug.Log("Regdola Girdi");
        GetComponentInParent<CapsuleCollider>().enabled = false;
        GetComponentInParent<Rigidbody>().isKinematic = true;
        controller.Controller.enabled = false;
        GetComponent<Animator>().SetBool("Death", true);

        GetComponent<Animator>().enabled = false;

        FizikState(false);
        ColliderState(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            EnterRagdoll();
        }
    }
}
