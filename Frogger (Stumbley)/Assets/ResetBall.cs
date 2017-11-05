using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ResetBall : MonoBehaviour {

	private Vector3 startPosition;
	static List<ResetBall> allBalls=new List<ResetBall>();
	
	void Awake(){
		startPosition = this.transform.position;
		allBalls.Add (this);
	}

	public static void resetAll(){
		
		foreach (var item in allBalls) {
			item.OnReset();
			print("I reset");
		}
	}
	
	void OnDestroy() {
		allBalls.Remove (this);
	}
	
	void OnReset(){
		gameObject.SetActive (true);
		transform.position = startPosition;
		if (GetComponent<Rigidbody> ()) {
			GetComponent<Rigidbody>().velocity=Vector3.zero;
			GetComponent<Rigidbody>().angularVelocity=Vector3.zero;
		}
	}
}