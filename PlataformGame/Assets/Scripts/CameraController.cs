using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContoller : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    private float boundX = 5.4f;
    private float boundY = 2.45f;

    private void LateUpdate()
    {
        float posX = target.position.x;
        float posY = target.position.y;

        posX = posX < -boundX ? -boundX : posX;
        posX = posX > boundX ? boundX : posX;

        posY = posY < -boundY ? -boundY : posY;
        posY = posY > boundY ? boundY : posY;

        transform.position = new Vector3(posX, posY, transform.position.z);
    }
}