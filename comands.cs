using UnityEngine;
using System.Collections;

public class comands : MonoBehaviour {

	private player player;
	public string button;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType (typeof(player)) as player;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	public void OnTouchDown() {
//		switch(button) {
//			case "right":			
//				player.rightPress ();
//				break;
//
//			case "left":
//				player.leftPress ();
//				break;
//			}
//
//	}

	public void OnTouchUp() {
		switch(button) {
			case "right":			
				player.rightRelease ();
				break;

			case "left":			
				player.leftRelease ();
				break;
			}
	}

	public void OnTouchStay() {
		switch(button) {
			case "right":					
				player.rightPress ();
				break;

			case "left":			
				player.leftPress ();
				break;
			}
		
	}
}
