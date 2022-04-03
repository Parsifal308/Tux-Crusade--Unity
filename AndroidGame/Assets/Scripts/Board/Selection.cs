using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
    [SerializeField] private float pickUpRange = 10f;
    private int itemMask;
    private Ray pickUpRay;
    private RaycastHit itemHit;
    private LineRenderer pickUpRayLine;
    private void Start()
    {
        pickUpRayLine = GetComponent<LineRenderer>();
        itemMask = LayerMask.GetMask("Position");
    }
    private void Update()
    {
        Target();
    }

    public void Target()
    {
        pickUpRayLine.SetPosition(0, Camera.main.transform.position);
        pickUpRayLine.SetPosition(1, pickUpRay.origin + pickUpRay.direction * pickUpRange);
        pickUpRay.origin = Camera.main.transform.position;
        pickUpRay.direction = Camera.main.transform.forward;
        if (Physics.Raycast(pickUpRay, out itemHit, pickUpRange, itemMask))
        {
            Debug.Log(itemHit.transform.parent.gameObject.name);
            itemHit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

}
