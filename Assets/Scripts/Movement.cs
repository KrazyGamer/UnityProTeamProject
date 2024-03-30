using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Transform CamHolder;
    float horizontalLook;
    float verticalLook;

    // Update that moves camera when user moves match
    void Update()
    {

        horizontalLook = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * horizontalLook);

        
        verticalLook -= Input.GetAxis("Mouse Y");
        verticalLook = Mathf.Clamp(verticalLook, -90f, 90f);
        CamHolder.localEulerAngles = new Vector3(verticalLook, 0, 0);

    }
}
