using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Animator anmi;

    public int collect = 4;

 // Update is called once per frame
    void Update()
    {
        anmi.SetInteger("OpenDoor", collect);
        
    }
}
