using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    private PlayerManager playerManager;
    private Camera playerCamera;
    private float clampedX;
    private float clampedY;
    [SerializeField] private GameObject cameraRotation;
    [SerializeField] private GameObject cameraPosition;

    [SerializeField] private GameObject cameraTarget;
    [SerializeField] private GameObject cameraBoardAxis;
    [SerializeField] private float cameraSensibility = .1f;
    [SerializeField] private float zoomSensibility = 0.05f;
    [SerializeField] private float positionLerp = 0.05f;
    [SerializeField] private float rotationLerp = 0.05f;


    [SerializeField] bool isUsingMouse;


    private void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        playerCamera = Camera.main;
    }
    private void Update()
    {
        cameraBoardAxis.transform.Rotate(new Vector3(0, playerManager.MobileInputs.LeftStick.ReadValue<Vector2>().x * cameraSensibility, 0));
        playerCamera.transform.LookAt(cameraTarget.transform);



        //zoom
        //playerCamera.transform.Translate((cameraTarget.transform.localPosition - playerCamera.transform.localPosition).normalized * zoomSensibility * playerManager.MobileInputs.LeftStick.ReadValue<Vector2>().y * Time.deltaTime);
        
        //camera movement strafe/up/down
        playerCamera.transform.Translate(new Vector3(playerManager.MobileInputs.RightStick.ReadValue<Vector2>().x *cameraSensibility , playerManager.MobileInputs.RightStick.ReadValue<Vector2>().y * cameraSensibility, playerManager.MobileInputs.LeftStick.ReadValue<Vector2>().y * zoomSensibility));
    }
    private void LateUpdate()
    {
        //LerpCamera();
    }
    public void LerpCamera()
    { 
        //playerCamera.transform.position = Vector3.Slerp(playerCamera.transform.position, followTarget.transform.position, positionLerp);
        playerCamera.transform.rotation = Quaternion.Lerp(playerCamera.transform.rotation, cameraRotation.transform.rotation, rotationLerp);
    }
}
