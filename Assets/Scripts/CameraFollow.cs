using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float zoomSize = 3f;

    void LateUpdate()
    {
        if (player == null) return;

        transform.position = new Vector3(
            player.position.x,
            transform.position.y,
            -10f
        );

        GetComponent<Camera>().orthographicSize = zoomSize;
    }
}