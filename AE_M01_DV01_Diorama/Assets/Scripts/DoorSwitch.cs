using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    public GameObject Door;

    public Renderer ren;

    bool isOpen = false;
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Door open");
        ren.material.color = Color.green;
        isOpen = true;
        Door.transform.position += new Vector3(0, 5, 0);
    }
}
