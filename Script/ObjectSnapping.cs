using UnityEngine;

public class ObjectSnapping : MonoBehaviour
{
    public float snapDistance = 0.1f;
    private bool isGrabbed;

    void Update()
    {
        if (isGrabbed)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, snapDistance))
            {
                // Check if the hit object is suitable for snapping
                if (IsSnapTarget(hit.collider.gameObject))
                {
                    SnapToSurface(hit.collider.gameObject, hit.point, hit.normal);
                }
            }
        }
    }

    private void SnapToSurface(GameObject snapTarget, Vector3 snapPosition, Vector3 snapNormal)
    {
        // Calculate the rotation to match the surface normal
        Quaternion targetRotation = Quaternion.FromToRotation(transform.up, snapNormal) * transform.rotation;

        // Snap the object to the surface
        transform.position = snapPosition;
        transform.rotation = targetRotation;

        // Optionally, you can attach the snapped object to the snap target
        transform.SetParent(snapTarget.transform);
    }

    private bool IsSnapTarget(GameObject obj)
    {
        // Add your logic here to determine if the object is suitable for snapping
        return obj.CompareTag("SnapTarget");
    }

    public void SetGrabbed(bool grabbed)
    {
        isGrabbed = grabbed;
    }
}
