using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLifeControl : MonoBehaviour
{

  void OnCollisionEnter2D(Collision2D coll) {
    GameManager gameManager = FindObjectOfType<GameManager>();

    if(coll.collider.CompareTag("Player") && gameManager.faseComplete())
    {
      gameManager.venceu();

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