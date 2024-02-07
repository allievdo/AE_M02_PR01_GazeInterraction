using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    public GameObject Door;

    bool isOpen = false;
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Door open");
        isOpen = true;
        Door.transform.position += new Vector3(0, 5, 0);
    }
}
