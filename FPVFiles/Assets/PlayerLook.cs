using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Vector2 _mousSensitivity;
    private Vector2 _padSensitivity;
    public Vector2 _mouseYLimit;
    private float horizontal;
    private float vertical;
    public bool cameraActive;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraActive)
        {
            
            
            float mouseY = Input.GetAxis("Mouse Y") * _mousSensitivity.y* Time.deltaTime;
            
            Vector3 cameraAngles = Camera.main.transform.eulerAngles;
            vertical = vertical + mouseY;
            vertical = Mathf.Clamp(vertical, _mouseYLimit.x, _mouseYLimit.y);
            Camera.main.transform.eulerAngles = new Vector3(vertical, cameraAngles.y, cameraAngles.z);

            float mouseX = Input.GetAxis("Mouse X") * _mousSensitivity.x * Time.deltaTime;
            horizontal = horizontal + mouseX;
            //Debug.Log(mouseX);
            //horizontal = Mathf.Clamp(vertical, _mouseYLimit.x, _mouseYLimit.y);
            Vector3 PlayerAngles = transform.eulerAngles;
            transform.eulerAngles = new Vector3(PlayerAngles.x, horizontal, PlayerAngles.z);
        }
        if (Input.GetButton("Fire1")) cameraActive = true;

        
        
    }
}
