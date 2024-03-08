using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Update()
    {
        // Switch between cameras using keyboard input
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCamera(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCamera(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchCamera(2);
        }
    }

    void SwitchCamera(int newCameraIndex)
    {
        // Disable the current camera
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Enable the new camera
        currentCameraIndex = newCameraIndex;
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }
}
