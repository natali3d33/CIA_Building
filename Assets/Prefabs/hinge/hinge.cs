using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hinge : MonoBehaviour
{
    [SerializeField] DoorSwing DoorType;
    [SerializeField] bool AutoDoorOpener = true;
    [SerializeField] Pivot pivot;

    // Start is called before the first frame update
    void Start()
    {
        pivot.DoorType = DoorType;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!AutoDoorOpener) return;
        pivot.Open();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!AutoDoorOpener) return;
        pivot.Close();
    }
}
