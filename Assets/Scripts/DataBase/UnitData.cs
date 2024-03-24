using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ������ ���� ������
public class UnitData 
{
    // �����õ�����
    // hp
    // mp
    // ���ݷ�
    // ����
    // �ǵ�
    // �̵��ӵ�
    // ��Ÿ�
    // ���ݼӵ�
    // ������ ����
    public int hp = 0;
    public int mp = 0;
    public int atk = 0;
    public int armor = 0;
    public int shield = 0;
    public int moveSpeed = 0;
    public int atkRange = 0;
    public int atkSpeed = 0;
    public int detectRange = 0;

    // Ÿ�� ������
    // ����Ÿ��
    // �뵵 - ���� �⺻AI����  �߸���������
    // ũ��Ÿ�� ���߼�
    // ����Ÿ�� ���� Ÿ�� ����
    // �Ӽ�Ÿ�� ���������
    // ����Ÿ�� �ΰ� ��� ���� ��
    public int kind = 0;
    public string usage = ""; // AU BU NHU NU
    public int size = 0;
    public string atkType = "";
    public string atrType = "";
        public string unitType = "";

    // �ڿ� ������
    // �䱸 �ڿ�
    public int[] consume;
    public string[] resourceType; // gold silver bronze

    // ��Ÿ ������
    // ���� ����
    // ���ſ���
    // �����ÿ���
    // ���ݿ���
    // ���
    // ����
    public bool isGround = true;
    public bool ishide = false;
    public bool isDetect = false;
        public bool isHunt = false; // �߸����� ���ݰ��ɿ���
        public bool isControl = false; // ������ ��Ʈ���Ҽ��ִ��� ����
    public bool isAttack = true;
    public bool isATG = true; // Attack To Ground
    public bool isATA = false; // Attack To Air

    // �Ʊ� ���� �����ϴ¹�?? �����۾��� �ʿ��ϴ°����� ����
    //public int Faction = 0; // 0 - ���� 1 - ���

    // ���� ������ - ���� �ۼ� ������Ʈ?
    // ������ų ������
    // ��������
}
