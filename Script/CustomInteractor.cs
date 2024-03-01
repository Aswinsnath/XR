using Meta;
using UnityEngine;

public class CustomInteractor : MetaWorldInteractor
{
    public override void OnGrabBegin(GameObject grabbedObject, Vector3 grabPosition, Quaternion grabRotation)
    {
        base.OnGrabBegin(grabbedObject, grabPosition, grabRotation);
        // Add custom logic here to handle grabbing objects
    }

    public override void OnGrabEnd(GameObject grabbedObject, Vector3 grabPosition, Quaternion grabRotation)
    {
        base.OnGrabEnd(grabbedObject, grabPosition, grabRotation);
        // Add custom logic here to handle releasing grabbed objects
    }
}
