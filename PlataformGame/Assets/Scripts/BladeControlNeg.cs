using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeControlNeg : MonoBehaviour
{
  private float speed = 4.0f;
  private Rigidbody2D rb2d;

  void OnColiderEnter2D(Collision2D coll) {
    if(coll.collider.CompareTag("limit"))
    {
      Destroy(gameObject);
    } 
  }


  void Start()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    var vel = rb2d.velocity;

    vel.x = -speed;

    rb2d.velocity = vel;
    var pos = transform.position;

    if (pos.x > 15 || pos.x < -15){
      Destroy(gameObject);
    }

    transform.position = pos;
    transform.rotation = Quaternion.Euler(new Vector3(0,0,135));
  }
}