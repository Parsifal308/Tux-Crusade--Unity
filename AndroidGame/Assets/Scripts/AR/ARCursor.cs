using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARCursor : MonoBehaviour
{
    public GameObject cursor;
    public GameObject objectToPlace;
    public ARRaycastManager raycastManager;

    public bool isCursorActive;

    private void Start()
    {
        cursor.SetActive(isCursorActive);
    }
    private void Update()
    {
        if (isCursorActive)
        {
            UpdateCursor();
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (isCursorActive)
            {
                GameObject.Instantiate(objectToPlace, transform.position, transform.rotation);
            }
        }
    }
    public void UpdateCursor()
    {
        Vector2 screenPosition = Camera.main.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        raycastManager.Raycast(screenPosition, hits, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if(hits.Count > 0)
        {
            transform.position=hits[0].pose.position;
            transform.rotation=hits[0].pose.rotation;
        }
    }
}
