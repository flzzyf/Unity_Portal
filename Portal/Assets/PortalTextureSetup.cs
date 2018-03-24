using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {

    public Camera cameraB;
    public Material cameraMatB;

	void Start () 
    {
        cameraB.targetTexture.height = Screen.height;
        cameraB.targetTexture.width = Screen.width;
        cameraB.targetTexture.depth = 24;

	}

}
