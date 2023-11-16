using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathControl : MonoBehaviour
{
  void sumir() {
    Destroy(gameObject);
  }

  void Start()
  {
    Invoke("sumir", 1.5f);
  }

  void Update()
  {
  }
}