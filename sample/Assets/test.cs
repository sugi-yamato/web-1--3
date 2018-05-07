using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    // Use this for initialization
    void SayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    public class Player
    {
        private int hp = 100;
        private int power = 50;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた。");
        }

        public void Damage(int damage)
        {
            this.hp -= damage;
            Debug.Log(damage + "のダメージを受けた。");
        }
    }
        
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

        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }


        int[] points = { 83, 99, 52, 93, 15 };

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 90)
            {
                Debug.Log(points[i]);
            }
        }

        SayHello();

        CallName("Tom");

        int kotae;
        kotae = Add(2, 3);
        Debug.Log(kotae);

        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Vector2 startsPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startsPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);


    }

    // Update is called once per frame
    void Update () {
		
	}
}
