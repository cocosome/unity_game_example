using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Description : MonoBehaviour
{
    /*
        transform = object 생성시 필수적으로 생성되는 property
         - 일부러 transfrom class의 객체를 따로 생성할 필요 없이 object생성시 자동으로 생성되어 있다!
         - gameObject와 transform은 1대1 관계이다
         - 이미 초기화가된 transform 변수가 존재한다!
    */

    /*
        transform.Translate() = 매개변수의 vetor값 만큼 object를 이동시킨다 - 원래 위치에서 vec값을 더하는 개념
        - ()안에는 Vector3나 Vector2 객체가 들어간다
        - Vector3는 3차원 Vector2는 2차원 객체이다.

         Vector3 vec = new Vector3(x, y, z) = Vector3객체 vec를 만들고 방향값은 x축, y축, z축 순서로 x,y,z값을 갖는다
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal")/50,Input.GetAxis("Vertical")/50,0);
        transform.Translate(vec);
    }
}
