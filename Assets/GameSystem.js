#pragma strict
import UnityEngine.UI;
import Chara1;
public var text:Text;
public var b1f:Text;
public var Btnback:Button;
public var charactor1:Image;
public var flg1:boolean = true;
public var num:Number;
public var slider1:Slider;
public var tx1:Text;
public var pow:Button;
public var rbody:Rigidbody2D;

public var obj1:GameObject;
function Start () {
	text.text = "tuchiya";
	Btnback.onClick.AddListener(backb);
	pow.onClick.AddListener(pow1);
	rbody = charactor1.GetComponent.<Rigidbody2D>();
	obj1 = GameObject.Find("Image2");
}

function Update () {
	if(flg1) {
		charactor1.transform.Translate(0.1,0,0);
		b1f.text = "LEFT";
	}else {
		charactor1.transform.Translate(-0.1,0,0);
		b1f.text = "RIGHT";
	}
	num = slider1.value;
	tx1.text = "" + num;
	text.text = "Tm:" + parseInt(Time.time);
}
function backb () {
	text.text = "btnhittt";
	flg1 = !flg1;
}
function pow1() {
	Debug.Log("pow1");
	rbody.AddForce(Vector2.up * 4000f);
	charactor1.SendMessage("test1");
}