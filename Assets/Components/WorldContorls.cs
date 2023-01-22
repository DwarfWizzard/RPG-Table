using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldContorls : MonoBehaviour
{
    [SerializeField] private Camera camera;

    private Vector3 cameraPos;
    private Vector3 _dragOffset;
    private Vector3 origin;

    private float zoom = 5f;
    private float zoomStep = 10f;

    private bool drag = false;
    

    private void Start()
    {
        cameraPos = camera.transform.position;
        Debug.Log(Screen.width);
    }

    private void Update()
    {
        HandleZoom();
        HandleMouseMovement();
    }

    private void HandleMouseMovement() 
    {
        if (Input.GetMouseButton(2))
        {
            _dragOffset = camera.ScreenToWorldPoint(Input.mousePosition) - cameraPos;
            if (drag == false)
            {
                drag = true;
                origin = camera.ScreenToWorldPoint(Input.mousePosition);
            }       
        }
        else
        {
            drag = false;
        }

        if (drag)
        {
            cameraPos = origin - _dragOffset;
        }

        camera.transform.position = cameraPos;
    }

    private void HandleZoom()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            zoom -= zoomStep * Time.deltaTime * 10f;
        }
        if (Input.mouseScrollDelta.y < 0)
        {
            zoom += zoomStep * Time.deltaTime * 10f;
        }
        zoom = Mathf.Clamp(zoom, 1f, 10f);
        camera.orthographicSize = zoom;
    }
}
