using UnityEngine;
using System.Collections;

public class EnemyPatrol : MonoBehaviour
{
  Rigidbody2D enemyRigidBody2D;
  public float UnitsToMove = 5.0f;
  public float EnemySpeed = 500;
  public bool _isFacingRight;
  private float _startPos;
  private float _endPos;

  public bool _moveRight = true;

  public void Awake()
  {
    enemyRigidBody2D = GetComponent<Rigidbody2D>();
    _startPos = transform.position.x;
    _endPos = _startPos + UnitsToMove;
    _isFacingRight = transform.localScale.x > 0;
  }

  public void Update()
  {
    transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
    
    if (_moveRight)
    {
      enemyRigidBody2D.AddForce(Vector2.right * EnemySpeed * Time.deltaTime);
      if (!_isFacingRight)
        Flip();
    }

    if (enemyRigidBody2D.position.x >= _endPos)
      _moveRight = false;

    if (!_moveRight)
    {
      enemyRigidBody2D.AddForce(-Vector2.right * EnemySpeed * Time.deltaTime);
      if (_isFacingRight)
        Flip();
    }
    if (enemyRigidBody2D.position.x <= _startPos)
      _moveRight = true;
  }

  public void Flip()
  {
    transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    _isFacingRight = transform.localScale.x > 0;
  }
}
