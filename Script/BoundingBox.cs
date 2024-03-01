using UnityEngine;

public class BoundingBox : MonoBehaviour
{
    public Material highlightMaterial;
    public Material grabMaterial;

    private GameObject boundingBox;
    private bool isHighlighted;
    private bool isGrabbed;

    void Start()
    {
        // Create a new GameObject to act as the bounding box
        boundingBox = new GameObject("BoundingBox");
        boundingBox.transform.SetParent(transform);
        boundingBox.transform.localPosition = Vector3.zero;
        boundingBox.transform.localRotation = Quaternion.identity;
        boundingBox.transform.localScale = Vector3.one;

        // Add a BoxCollider to the bounding box GameObject
        BoxCollider boxCollider = boundingBox.AddComponent<BoxCollider>();
        boxCollider.size = GetComponent<Renderer>().bounds.size;
        boxCollider.center = Vector3.zero;

        // Disable the bounding box initially
        SetBoundingBoxActive(false);
    }

    void Update()
    {
        // Check if the object is currently highlighted or grabbed
        if (isHighlighted)
        {
            // Enable the bounding box and set the material to highlightMaterial
            SetBoundingBoxActive(true);
            boundingBox.GetComponent<Renderer>().material = highlightMaterial;
        }
        else if (isGrabbed)
        {
            // Enable the bounding box and set the material to grabMaterial
            SetBoundingBoxActive(true);
            boundingBox.GetComponent<Renderer>().material = grabMaterial;
        }
        else
        {
            // Disable the bounding box
            SetBoundingBoxActive(false);
        }
    }

    public void SetHighlighted(bool highlighted)
    {
        isHighlighted = highlighted;
    }

    public void SetGrabbed(bool grabbed)
    {
        isGrabbed = grabbed;
    }

    private void SetBoundingBoxActive(bool active)
    {
        boundingBox.SetActive(active);
    }
}
