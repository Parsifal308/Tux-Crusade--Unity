using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouse : MonoBehaviour
{
    private PlayerManager playerManager;
    private Camera playerCamera;
    private float clampedX;
    private float clampedY;
    [SerializeField] private GameObject cameraRotation;
    [SerializeField] private GameObject cameraPosition;
    [SerializeField] private float cameraSensibility = 0.25f;
    [SerializeField] private float positionLerp = 0.05f;
    [SerializeField] private float rotationLerp = 0.05f;


    private void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        playerCamera = Camera.main;
    }
    private void Update()
    {
        cameraRotation.transform.localRotation = Quaternion.Euler(-playerManager.MouseInput.MousePositionValue.y, playerManager.MouseInput.MousePositionValue.x, 0);
    }
    private void LateUpdate()
    {
        LerpCamera();
    }
    public void LerpCamera()
    { 
        //playerCamera.transform.position = Vector3.Slerp(playerCamera.transform.position, followTarget.transform.position, positionLerp);
        playerCamera.transform.rotation = Quaternion.Lerp(playerCamera.transform.rotation, cameraRotation.transform.rotation, rotationLerp);
    }
}
