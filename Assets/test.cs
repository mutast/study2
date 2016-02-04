using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	// Use this for initialization
	public string str1{get; set;}
	void Start () {
		int x = 20;
		//Debug.Log(x);

		int a=10,b=14,c=100,d=1,e=5;
		int max = MAX(a,b,c,d,e);
		//Debug.Log("max= " + max.ToString());

		Comp co = new Comp();
		co.Num1 = 10;
		//Debug.Log(co.Num1);
		Person ps = new Person("namae",18);
		Person.Chek();
		//Debug.Log(Person.id);
		//Debug.Log(ps.Name);
		//Debug.Log(ps.Age);
		//str1 = "ttttttttt";
		//Debug.Log(str1);
		Debug.Log("ctest" + Ctest1.Test1(10));
		Ctest1.Num1 = 1000;
		Debug.Log("ctest2" + Ctest1.Num1);
		Debug.Log("gittest確認しましたー");
	}

	static int MAX(params int[] a) {
		int max = a[0];
		for(int i=1 ;i<a.Length;i++) {
			if(max < a[i]) {
				max = a[i];
			}
		}
		return max;
	}

	static int Sam(int a=0,int b=0,int c= 0) {
		return a + b + c;
	}
	// Update is called once per frame
	void Update () {
	
	}
}

class Comp {
	private double num1;
	private double num2;

	public double Num1 {
		set{this.num1 = value;}
		get{return this.num1;}
	}
}

class Person {
	private string name = "";
	private int age = 0;
	public static int id = 0;
	public Person(string nam ,int age) {
		this.name = nam;
		this.age = age;
	}

	public static void Chek() {
		id ++;
		Debug.Log(id);
	}

	public string Name {
		set {name = value;}
		get {return name;}
	}
	public int Age {
		set {age = value;}
		get {return age;}
	}
}