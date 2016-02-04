#pragma strict

function Start () {
	Debug.Log("chara2 get");
}

function Update () {
	if(Input.GetMouseButtonDown(0)) {
		Debug.Log("c2 down");
	}
	transform.Rotate(0,0,5*Time.deltaTime);
}

function OnMouseEnter() {
	Debug.Log("c2 hit");
}