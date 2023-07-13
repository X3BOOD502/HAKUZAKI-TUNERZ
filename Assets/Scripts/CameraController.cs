using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float distance = 1f;
    public Transform player;
    private Rigidbody playerRB;
    public Vector3 Offset;
    public float speed;
    void Start()
    {
        playerRB = player.GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 playerForward = (playerRB.velocity + player.transform.forward).normalized;
        transform.position = Vector3.Lerp(transform.position,
        player.position + player.transform.TransformVector(Offset)
        + playerForward * (-distance),
        speed * Time.deltaTime);
        transform.LookAt(player);
    }
}
