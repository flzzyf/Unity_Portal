using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {

    public Camera cameraA;
    public Material cameraMatA;
    public Camera cameraB;
    public Material cameraMatB;

	void Start () 
    {
        cameraB.targetTexture.height = Screen.height;
        cameraB.targetTexture.width = Screen.width;
        cameraB.targetTexture.depth = 24;

        cameraA.targetTexture.height = Screen.height;
        cameraA.targetTexture.width = Screen.width;
        cameraA.targetTexture.depth = 24;

	}

}
