using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCam : MonoBehaviour
{
    public Transform position1; 
    public Transform position2; 
    public Transform lookAtTargetA; 
    public Transform lookAtTargetB; 

    private bool togglePosition = false;
    private CinemachineFreeLook freeLookCamera;

    void Start()
    {
        freeLookCamera = GetComponent<CinemachineFreeLook>();

        transform.position = position1.position;
        transform.rotation = position1.rotation;
        freeLookCamera.LookAt = lookAtTargetA;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            togglePosition = !togglePosition;
            if (togglePosition)
            {
                freeLookCamera.LookAt = null;
                transform.position = position1.position;
                transform.rotation = position1.rotation;
                freeLookCamera.LookAt = lookAtTargetA;
            }
            else
            {
                freeLookCamera.LookAt = null;
                transform.position = position2.position;
                transform.rotation = position2.rotation;
                freeLookCamera.LookAt = lookAtTargetB;
            }
        }
    }
}
