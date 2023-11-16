using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiceControl : MonoBehaviour
{

  void OnCollisionEnter2D(Collision2D coll) {
    if(coll.collider.CompareTag("Player"))
    {
      Destroy(gameObject);
    }
  }

  void Start()
  {
  }

  void Update()
  {
  }
}