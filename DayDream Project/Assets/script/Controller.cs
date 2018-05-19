using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	void Update(){
		Debug.LogFormat ("{0},{1},{2},{3}", GetContllorXYZ (), GetTouchPosXY (), GetTouchClick (), GetAppClick ());
	}

	Vector3 GetContllorXYZ(){
		Vector3 _xyz = new Vector3(GvrController.Orientation.x, GvrController.Orientation.y, GvrController.Orientation.z);
		return _xyz;
	}
	Vector2 GetTouchPosXY(){
		Vector2 _xy = new Vector2 (GvrController.TouchPos.x,GvrController.TouchPos.y);
		return _xy;
	}

	bool GetTouchClick(){
		bool _touch = GvrController.ClickButton;
		return _touch;
	}

	bool GetAppClick(){
		bool _click = GvrController.AppButton;
		return _click;
	}
}
