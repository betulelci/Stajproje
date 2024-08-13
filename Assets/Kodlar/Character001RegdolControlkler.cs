using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character001RegdolControlkler : MonoBehaviour
{
    // Start is called before the first frame update
    RegdollController RagdolController;
    void Start()
    {
        RagdolController = GetComponentInChildren<RegdollController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnterRegdol")
        {
            RagdolController.EnterRagdoll();
        }
        
    }
}
