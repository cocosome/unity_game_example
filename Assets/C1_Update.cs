using UnityEngine;

public class C1_Update : MonoBehaviour
{
    void Update()
    {  
        //Input : ���� �� �Է��� �����ϴ� Ŭ����
        //anyKeyDown : �ƹ� �Է��� "����"�� ���� �� true
        if(Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        //anyKey = �ƹ� �Է��� ������ true
        // if(Input.anyKey)
        //     Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�");

        
        //�Է��Լ��� keydown, keystay, keyup������ Ű���带 ������ ��, ������ ������, ���� ������3������ ������

        /*
            GetKeyDown = Ű���带 ������ �� �ߵ�(true)
            GetKey = Ű���带 ������ �߿� �ߵ�(true)
            GetKeyUp = Ű���忡�� ���� ���� �� �ߵ�(true)
        */

        /*
            KeyCode.something = ���� Ű������ something�� �Է¹޾��� ���� �ǹ�

            -----example-----
            KeyCode.Return = enterŰ
            KeyCode.LeftArrow = ����Ű ����
            KeyCode.RightArrow = ����Ű ������
            KeyCode.a = aŰ
            KeyCode.F1 = F1Ű
            KeyCode.Escape = ESCŰ
        */

        // if(Input.GetKeyDown(KeyCode.Return))
        //     Debug.Log("�������� �����Ͽ����ϴ�.");
        
        // if(Input.GetKey(KeyCode.LeftArrow))
        //     Debug.Log("�������� �̵� ��");

        // if(Input.GetKeyUp(KeyCode.RightArrow))
        //     Debug.Log("������ �̵��� ���߾����ϴ�.");


        /*
            GetMouseButtonDown = ���콺 ��ư�� ������ �� �ߵ�(true)
            GetMouseButton = ���콺 ��ư�� ������ �߿� �ߵ�(true)
            GetMousButtonUp = ���콺 ��ư���� ���� ���� �� �ߵ�(true)

            GetMouseButton(0) - ���� ���콺 ��ư
            GetMouseButton(1) - ������ ���콺 ��ư
        */

        if(Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�!");

        if(Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if(Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");

        /*
            Project Settings - Input Manager�� ��ϵ� key�� ���ؼ� �Է��� ���� �� �ִ�.

            Input Manager�� size�� �ø��� ����� ���� button�� �߰��� �� �ִ�.

            ���� �̸����� ���� hardware device�� ���ÿ� �ߵ� �����ϴ�!
            

            GetButtonDown("something") = something�� ������ �� �ߵ�
            GetButton("something") = something�� ������ �߿� �ߵ�
            GetButtonUp("something") = something���� ���� ���� �� �ߵ�

            "Jump" = spacebar�� �ǹ���
            "vertical" = w, s, Ű���� ��Ű, Ű���� �Ʒ�Ű ��� ������

        */
        
        if(Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if(Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");
        
        if(Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");
        

        if(Input.GetButtonDown("Vertical"))
            Debug.Log("����Ű�� �������ϴ�.");

        /*
            GetAxis = ����, ������ �Է¹ް� float�� ��ȯ(float)
            - Ű���带 ������ �� ������ ������ ���� ����ġ�� ��ȯ��

            GetAxisRaw = ����, ������ �Է¹ް� int�� ��ȯ(int)
            - GetAxis�� �޸� ����ġ���� ������ �ʰ� 0�� 1���� �������·� ���� ���
        */  


        if(Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal"));
        }

        if(Input.GetButton("Vertical"))
        {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }

        
    }
}
