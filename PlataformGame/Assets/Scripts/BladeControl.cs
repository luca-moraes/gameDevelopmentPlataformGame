using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeControl : MonoBehaviour
{
  private float speed = 4.0f;
  public int tipoAtaque = 0;
  private Rigidbody2D rb2d;

  void OnCollisionEnter2D(Collision2D coll) {
    if(tipoAtaque == 0){
      if(coll.collider.CompareTag("enemy"))
      {
        Destroy(gameObject);
      } 
    }else if(tipoAtaque == 1){
      if(coll.collider.CompareTag("Player"))
      {
        Destroy(gameObject);
      } 
    }
  }

  void Start()
  {
    rb2d = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    var vel = rb2d.velocity;

    vel.x = speed;

    rb2d.velocity = vel;
    var pos = transform.position;

    if (pos.x > 15 || pos.x < -15){
      Destroy(gameObject);
    }

    transform.position = pos;
    transform.rotation = Quaternion.Euler(new Vector3(0,0,-45));
  }
}