using UnityEngine;

public class BackgroundGroupLoop : MonoBehaviour
{
    public Transform player;

    void LateUpdate()
    {
        if (player == null) return;

        SpriteRenderer[] sprites =
            GetComponentsInChildren<SpriteRenderer>();

        if (sprites.Length == 0) return;

        Bounds groupBounds = sprites[0].bounds;

        for (int i = 1; i < sprites.Length; i++)
        {
            groupBounds.Encapsulate(sprites[i].bounds);
        }

        Camera cam = Camera.main;
        float cameraLeft =
            player.position.x -
            (cam.orthographicSize * cam.aspect);

        // เมื่อ Background หลุดไปทางซ้ายสุดของกล้อง
        if (groupBounds.max.x < cameraLeft)
        {
            transform.position += Vector3.right *
                                  groupBounds.size.x * 2f;
        }
    }
}