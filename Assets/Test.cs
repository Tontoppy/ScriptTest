using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;
    private int power = 25;
    //int�^�̕ϐ�mp��錾���A53�ŏ��������Ă�������
    private int mp = 53;
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        this.hp -= damage;
    }
    //mp������Ė��@�U��������Magic�֐�������Ă�������
    /*Magic�֐�����mp��5�ȏ�̏ꍇ��5���炵�A
     * �R���\�[���� ���@�U���������B�c��MP�́Z�Z�B
     * �ƕ\�����Ă��������Bmp������Ȃ��ꍇ�AMP������Ȃ����߁A
     * ���@���g���Ȃ��B �ƕ\�����Ă�������
     */
    public void Magic()
    {
        if(this.mp >= 5)
        {
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");

        }
    }

}
public class Test : MonoBehaviour


{

        // Start is called before the first frame update
    void Start()
    {

        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
        int[] array = { 11, 22, 33, 44, 55 };

        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
        for (int i = 0; i<5; i++)
        {
            Debug.Log(array[i]);

        }
        //for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������
        for (int i = 4; i >= 0 ; i--)
        {
            Debug.Log(array[i]);

        }

        Boss lastboss = new Boss ();
        lastboss.Attack();
        lastboss.Defence(3);

        /*
        Magic�֐����Ăяo���āA���@���g���Ă�������
        Magic�֐���10��g������ɁA�����Magic�֐����Ăяo���ƁA
        mp������Ȃ����b�Z�[�W��\�����邱�Ƃ��m�F���Ă�������
        */
        for(int i = 1; i<=11; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
