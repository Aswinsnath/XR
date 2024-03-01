using Meta;
using UnityEngine;

public class CustomInteractable : MetaWorldInteractable
{
    public override void OnHoverBegin()
    {
        base.OnHoverBegin();
        // Add custom logic here to highlight the object when hovered over
    }

    public override void OnHoverEnd()
    {
        base.OnHoverEnd();
        // Add custom logic here to remove the highlight when no longer hovered over
    }
}
