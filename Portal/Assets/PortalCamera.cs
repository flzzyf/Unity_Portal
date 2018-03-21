using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour {

    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

	void Update () 
    {
        Vector3 offset = playerCamera.position - otherPortal.position;
        transform.position = portal.position + offset;

        float angularDifference = Quaternion.Angle(portal.rotation, otherPortal.rotation);

        Quaternion rotationDifference = Quaternion.AngleAxis(angularDifference, Vector3.up);
        Vector3 newCameraDir = rotationDifference * playerCamera.forward;

        transform.rotation = Quaternion.LookRotation(newCameraDir, Vector3.up);
	}
}
