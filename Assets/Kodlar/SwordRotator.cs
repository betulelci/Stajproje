using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SwordRotator : MonoBehaviour
{
    [SerializeField] Vector3 RotateSpeed;
    void Update()
    {
        transform.Rotate(RotateSpeed * Time.deltaTime);
    }
}
