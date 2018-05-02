using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int age;

            age = 30;

        Debug.Log("Hello World");
        Debug.Log(age);

        int answer;

        answer = 1 + 2;
        Debug.Log(answer);

        answer = 1 - 2;
        Debug.Log(answer);

        answer = 2 * 4;
        Debug.Log(answer);

        answer = 8 / 2;
        Debug.Log(answer);

        string name;

        name = "sugiyama";

        Debug.Log(name);

        int n1 = 8;
        int n2 = 8;

        answer = n1 + n2;

        Debug.Log(answer);

        int herbNum = 1;
        if (herbNum == 1) ;
        Debug.Log("HPが５０回復");
        

    }

    // Update is called once per frame
    void Update () {
		
	}
}
