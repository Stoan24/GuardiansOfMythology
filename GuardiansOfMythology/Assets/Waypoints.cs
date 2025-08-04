using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] path;

    void Awake()
    {
        path = new Transform[transform.childCount];

        for (int i = 0; i < path.Length; i++)
        {
            path[i] = transform.GetChild(i);
        }
    }
}
