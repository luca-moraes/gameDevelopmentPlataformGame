using System;
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
  public GameObject paulDefetead;
  private Animator animator;
//   private float lastPosY = 0.0f;
  private bool floatingCondition = false;

  void OnCollisionEnter2D(Collision2D coll) {
	GameManager gameManager = FindObjectOfType<GameManager>();

    if(coll.collider.CompareTag("emperorsBlade") && gameManager.morto())
    {
		gameManager.ferido();
		gameManager.perdeu();

		var psc = transform.position;
		Instantiate(paulDefetead, psc, Quaternion.identity);
		Destroy(gameObject);

    }else if(coll.collider.CompareTag("emperorsBlade") && !gameManager.morto()){
		gameManager.ferido();
	}else if(coll.collider.gameObject.name == "colider"){
		floatingCondition = false;
	}
	// else if(coll.collider.gameObject.tag == "limit"){
	// 	floatingCondition = false;
	// }
	// else if(coll.collider.CompareTag("melange")){
		// gameManager.hit();
		// animator.SetBool("correndo", false);
		// animator.SetBool("pulando", false);
		// animator.SetBool("parado", false);
		// animator.SetBool("morreu", true);
		
		// var psc = transform.position;
		// Instantiate(paulDefetead, psc, Quaternion.identity);
		// Destroy(gameObject);
	// }
  }

	void OnCollisionExit2D(Collision2D coll) {
		if(coll.collider.gameObject.name == "colider"){
			floatingCondition = true;
		}
	}

  void Start()
  {
    rb2d = GetComponent<Rigidbody2D>();   
	animator = GetComponent<Animator>();
	animator.SetBool("morreu", false);
	boundY = 4.0f; 
	// lastPosY = transform.position.y;
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

		animator.SetBool("correndo", true);
		animator.SetBool("pulando", false);
		animator.SetBool("parado", false);
	}
	else if(Input.GetKey(moveRight)) {
		vel.x = speed;
		direction = 0.0f;

		animator.SetBool("correndo", true);
		animator.SetBool("pulando", false);
		animator.SetBool("parado", false);
	}
	else if(Input.GetKey(jump)){
		vel.y = speed*1.06f;
		
		floatingCondition = true;

		animator.SetBool("correndo", false);
		animator.SetBool("pulando", true);
		animator.SetBool("parado", false);
	}
	else {
		vel.y = -(speed/2);
		vel.x = 0;

		// bool isFalling;

		// if((Math.Abs(lastPosY) - Math.Abs(transform.position.y)) > 0.1f){
		// 	isFalling = true;
		// }else{
		// 	isFalling = false;
		// }

		animator.SetBool("correndo", false);
		animator.SetBool("pulando", floatingCondition);
		animator.SetBool("parado", !floatingCondition);

		// lastPosY = transform.position.y;
	}

	rb2d.velocity = vel;
	var pos = transform.position;

	if (pos.y > boundY) {
		pos.y = boundY;
	}
	else if (pos.y < -boundY) {
		floatingCondition = false;
		pos.y = -boundY;
	}
	// else if((boundY + 0.5f) < pos.y && pos.y < -(boundY + 0.5f)){
	// 	floatingCondition = true;
	// }

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