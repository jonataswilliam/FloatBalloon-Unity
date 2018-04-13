using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Rigidbody2D rbBalloon;
	private float axisX;
//	private float axisY;

	private float speed = 5;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//		#if UNITY_EDITOR
//
//		/********************** Controle para Cima ************************/
//
//		if(Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))  {
//			upPress ();
//		}
//
//		if(Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.UpArrow))  {
//			upRelease ();
//		}
//
//		/********************** Controle para Baixo ************************/
//
//		if(Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow))  {
//			downPress ();
//		}
//
//		if(Input.GetKeyUp (KeyCode.S) || Input.GetKeyUp (KeyCode.DownArrow))  {
//			downRelease ();
//		}
//
//		/********************** Controle para Direita ************************/
//
//		if(Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow))  {
//			rightPress ();
//		}
//
//		if(Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.RightArrow))  {
//			rightRelease ();
//		
//		}
//
//		/********************** Controle para Esquerda ************************/
//
//		if(Input.GetKeyDown (KeyCode.L) || Input.GetKeyDown (KeyCode.LeftArrow))  {
//			leftPress ();
//		}
//
//		if(Input.GetKeyUp (KeyCode.L) || Input.GetKeyUp (KeyCode.LeftArrow))  {
//			leftRelease ();
//		}
//
//		axisX = Input.GetAxisRaw ("Horizontal");
//		axisY = Input.GetAxisRaw ("Vertical");
//
//		#endif

		rbBalloon.velocity = new Vector2 (axisX * speed, 0);

	}

	void OnTriggerEnter2D (Collider2D col) {			
		if (col.tag == "obstaculos") {			
			Destroy (this.gameObject);
			Application.Quit ();
		}
	}

	public void upPress() {
//		axisY = 1;
		axisX = 0;
	}

	public void upRelease() {
//		axisY = 0;

	}

	public void downPress() {
//		axisY = -1;
		axisX = 0;
	}

	public void downRelease() {
//		axisY = 0;
	}

	public void leftPress() {		
//		axisY = 0;
		axisX = -1;
	}

	public void leftRelease() {		
		axisX = 0;
	}

	public void rightPress() {		
//		axisY = 0;
		axisX = 1;
	}

	public void rightRelease() {		
		axisX = 0;
	}





}
