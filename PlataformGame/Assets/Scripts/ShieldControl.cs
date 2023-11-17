using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldControl : MonoBehaviour
{

  void OnCollisionEnter2D(Collision2D coll) {
  }

  public void removeShield(){
    Destroy(gameObject);
  }

  void Start()
  {
  }

  void Update()
  {
  }
}