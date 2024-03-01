using UnityEngine;

public class AnchorPointManager : MonoBehaviour
{
    public GameObject anchorPointPrefab;
    public int gridSizeX = 3;
    public int gridSizeY = 3;
    public float spacing = 1.0f;

    void Start()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                Vector3 position = new Vector3(x * spacing, 0, y * spacing);
                GameObject anchorPoint = Instantiate(anchorPointPrefab, position, Quaternion.identity, transform);
                anchorPoint.name = "AnchorPoint (" + x + "," + y + ")";
            }
        }
    }
}
