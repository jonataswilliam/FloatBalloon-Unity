using UnityEngine;
using System.Collections;

public class obstaculosMoviment : MonoBehaviour {

	public Rigidbody2D rb_plataforma;
	public float speed;
	private float axisY = -3;

	// Use this for initialization
	void Start () {
		rb_plataforma.velocity = new Vector2 (0, axisY * speed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
