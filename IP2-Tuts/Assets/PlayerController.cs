using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//This is the animation controller
	Animator animationController;


	// Use this for initialization
	void Start () {
		animationController=GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		float axisValue=0.0f;
#if UNITY_IPHONE && !UNITY_EDITOR
		if (Input.touches.Length>0){
			Vector2 touchPos=Input.GetTouch(0).position;
			Vector2 screenCentre=new Vector2(Screen.width/2,Screen.height/2);
			axisValue=Vector2.Distance(touchPos,screenCentre);
		}
#else
		axisValue=Input.GetAxis("Horizontal");
#endif
		animationController.SetFloat("Speed",Mathf.Abs(axisValue));
	}

	void FixedUpdate()
	{
		//float axisValue=Input.GetAxis("Horizontal");
	}
}
