using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class BackgroundLoop : MonoBehaviour
{
    public Transform player;

    private float backgroundWidth;

    void Start()
    {
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void LateUpdate()
    {
        if (player == null) return;

        Camera cam = Camera.main;
        float cameraHalfWidth =
            cam.orthographicSize * cam.aspect;

        float backgroundRight =
            transform.position.x + backgroundWidth / 2f;

        // เมื่อ Background หลุดพ้นจอด้านซ้าย
        // ย้ายไปต่อด้านขวาสุด
        if (backgroundRight <
            player.position.x - cameraHalfWidth)
        {
            transform.position +=
                Vector3.right * backgroundWidth * 2f;
        }
    }
}