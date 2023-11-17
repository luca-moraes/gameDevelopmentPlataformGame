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

  void OnCollisionEnter2D(Collision2D coll) {
	GameManager gameManager = FindObjectOfType<GameManager>();

    if(coll.collider.CompareTag("emperorsBlade"))
    {
		//gameManager.hit();
    }else if(coll.collider.CompareTag("melange")){
		// gameManager.hit();
		// animator.SetBool("correndo", false);
		// animator.SetBool("pulando", false);
		// animator.SetBool("parado", false);
		// animator.SetBool("morreu", true);
		
		var psc = transform.position;
		Instantiate(paulDefetead, psc, Quaternion.identity);
		Destroy(gameObject);
	}
  }

  void Start()
  {
    rb2d = GetComponent<Rigidbody2D>();   
	animator = GetComponent<Animator>();
	animator.SetBool("morreu", false);
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
		vel.y = speed*1.1f;

		animator.SetBool("correndo", false);
		animator.SetBool("pulando", true);
		animator.SetBool("parado", false);
	}
	else {
		vel.y = -(speed/4);
		vel.x = 0;

		animator.SetBool("correndo", false);
		animator.SetBool("pulando", false);
		animator.SetBool("parado", true);
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