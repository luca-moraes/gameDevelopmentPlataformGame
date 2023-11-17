using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathControl : MonoBehaviour
{
  public float delayTime = 1.5f;
  void sumir() {
    Destroy(gameObject);
  }

  void Start()
  {
    Invoke("sumir", delayTime);
  }

  void Update()
  {
  }
}