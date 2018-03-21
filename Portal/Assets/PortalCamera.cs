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
	}
}
