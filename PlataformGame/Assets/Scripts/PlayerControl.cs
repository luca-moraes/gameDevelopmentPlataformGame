using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
  public KeyCode moveLeft = KeyCode.A;
  public KeyCode moveRight = KeyCode.S;
  public KeyCode jump = KeyCode.Space;
  public KeyCode shoot = KeyCode.Return;

  public float speed = 10.0f;
  public float boundY = 4.0f;
  public float boundX = 10.0f;
  private float direction = 0.0f;
  private Rigidbody2D rb2d;
  public GameObject dagacris;
  public GameObject negDagacris;

  	void OnCollisionEnter2D(Collision2D coll) {
    	if(coll.collider.CompareTag("alek") 
        || coll.collider.CompareTag("zoio1")
        || coll.collider.CompareTag("zoio2")
        || coll.collider.CompareTag("zoio3")
        || coll.collider.CompareTag("cigarro")
        || coll.collider.CompareTag("marreta"))
		{
            GameManager gameManager = FindObjectOfType<GameManager>();
            gameManager.hit();
    	}
    }

  void Start()
  {
    rb2d = GetComponent<Rigidbody2D>();   
	boundY = 4.0f; 
  }

  void Update()
  {
    var vel = rb2d.velocity;

	if(Input.GetKeyDown(shoot)){
		var psc = transform.position;

		if(direction == 0.0f){
			psc.x += 0.5f;
			Instantiate(dagacris, psc, Quaternion.identity);
		}else if(direction == 180.0f){
			psc.x -= 0.5f;
			Instantiate(negDagacris, psc, Quaternion.identity);
		}
	}

    if(Input.GetKey(moveLeft)) {
		vel.x = -speed;
		direction = 180.0f;
	}
	else if(Input.GetKey(moveRight)) {
		vel.x = speed;
		direction = 0.0f;
	}
	else if(Input.GetKey(jump)){
		vel.y = speed*1.1f;
	}
	else {
		vel.y = -(speed/4);
		vel.x = 0;
	}

	rb2d.velocity = vel;
	var pos = transform.position;

	if (pos.y > boundY) {
		pos.y = boundY;
	}
	else if (pos.y < -boundY) {
		pos.y = -boundY;
	}

	if (pos.y > boundX) {
		pos.y = boundX;
	}
	else if (pos.y < -boundX) {
		pos.y = -boundX;
	}

    transform.position = pos;
	transform.rotation = Quaternion.Euler(new Vector3(0,direction,0));
  }
}