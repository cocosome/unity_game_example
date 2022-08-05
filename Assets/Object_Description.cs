using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Description : MonoBehaviour
{
    /*
        transform = object ������ �ʼ������� �����Ǵ� property
         - �Ϻη� transfrom class�� ��ü�� ���� ������ �ʿ� ���� object������ �ڵ����� �����Ǿ� �ִ�!
         - gameObject�� transform�� 1��1 �����̴�
         - �̹� �ʱ�ȭ���� transform ������ �����Ѵ�!
    */

    /*
        transform.Translate() = �Ű������� vetor�� ��ŭ object�� �̵���Ų�� - ���� ��ġ���� vec���� ���ϴ� ����
        - ()�ȿ��� Vector3�� Vector2 ��ü�� ����
        - Vector3�� 3���� Vector2�� 2���� ��ü�̴�.

         Vector3 vec = new Vector3(x, y, z) = Vector3��ü vec�� ����� ���Ⱚ�� x��, y��, z�� ������ x,y,z���� ���´�
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
