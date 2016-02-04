using UnityEngine;
using System.Collections;

public class Ctest1 : MonoBehaviour {
	private static int num1 = 1;
	private string txt1 = "test";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static int Num1 {
		set {num1 = value;}
		get {return num1;}
	}

	public string Txt1 {
		set{txt1 = value;}
		get{return txt1;}
	}

	public static int Test1(int num) {
		int num1 = num + 10;
		return num1;
	}
}
