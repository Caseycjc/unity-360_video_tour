using UnityEngine;
using UnityEngine.UI;

public class TextToggle : MonoBehaviour
{
    public GameObject infoGroup; // Drag your InfoGroup (or InfoText) object here in the Inspector.

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    ToggleText();
                }
            }
        }
    }

    private void ToggleText()
    {
        if (infoGroup != null)
        {
            infoGroup.SetActive(!infoGroup.activeSelf);
        }
    }
}