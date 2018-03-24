using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleport : MonoBehaviour {

    public Transform player;
    public Transform receiver;

    bool playerInThePortal = false;
	
	void Update () 
    {
        if(playerInThePortal)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portalToPlayer);

            if(dotProduct < 0)
            {
                float rotationDiff = Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 posOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = receiver.position + posOffset;

                playerInThePortal = false;
                print("juice");
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            playerInThePortal = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInThePortal = false;
        }
    }
}
