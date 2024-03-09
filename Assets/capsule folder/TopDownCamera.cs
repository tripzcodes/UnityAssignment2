using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public float[] zoomLevels; // Array of zoom levels
    public float zoomSpeed = 1.0f; // Speed of zooming
    public Light redSpotlight; // Reference to the red spotlight

    private Camera topDownCamera;
    private int currentZoomLevel = 0;

    void Start()
    {
        topDownCamera = GetComponent<Camera>();
        SetZoomLevel(0); // Set initial zoom level
    }

    void Update()
    {
        // Switch between zoom levels using keys 8, 9, and 0
        if (Input.GetKeyDown(KeyCode.Alpha8))
            SetZoomLevel(0);
        else if (Input.GetKeyDown(KeyCode.Alpha9))
            SetZoomLevel(1);
        else if (Input.GetKeyDown(KeyCode.Alpha0))
            SetZoomLevel(2);

        // Toggle red spotlight using key F
        if (Input.GetKeyDown(KeyCode.F))
            ToggleRedSpotlight();
    }

    void SetZoomLevel(int level)
    {
        if (level >= 0 && level < zoomLevels.Length)
        {
            currentZoomLevel = level;
            topDownCamera.fieldOfView = zoomLevels[level];
        }
    }

    void ToggleRedSpotlight()
    {
        redSpotlight.enabled = !redSpotlight.enabled;
    }
}
