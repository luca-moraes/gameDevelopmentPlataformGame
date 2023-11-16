using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiceControl : MonoBehaviour
{

  void OnCollisionEnter2D(Collision2D coll) {
    GameManager gameManager = FindObjectOfType<GameManager>();

    if(coll.collider.CompareTag("Player"))
    {
		//gameManager.hit();
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