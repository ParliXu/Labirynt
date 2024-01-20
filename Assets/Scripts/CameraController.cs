using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float mouseSensitivity = 100f;
    float xRotacion = 0f;
    Transform player;
    
    
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
        player = transform.parent;
    }

    private void Update()
    {
        CameraRotacion();
    }
    private void CameraRotacion()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotacion -= mouseY;
        xRotacion = Mathf.Clamp(xRotacion, -90f, 80f);
        transform.localRotation = Quaternion.Euler(xRotacion, 0f, 0f);
    }
}
