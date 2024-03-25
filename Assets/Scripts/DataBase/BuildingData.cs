using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������ ������ ���� ������
namespace ProjectG.DB
{
    public class BuildingData
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
        public int barrior = 0;
        public int moveSpeed = 0;
        public int atkRange = 0;
        public int atkSpeed = 0;
        public int detectRange = 0;
        public int visualRange = 0;

        // Ÿ�� ������
        // ����Ÿ��
        // �뵵 - ���� �⺻AI����  �߸���������
        // ũ��Ÿ�� ���߼�
        // ����Ÿ�� ���� Ÿ�� ����
        // �Ӽ�Ÿ�� ���������
        // ����Ÿ�� �ΰ� ��� ���� ��
        public int kind = 0;
        public int size = 0;
        public string atkType = "";
        public string atrType = "";
        public string objectType = "";

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
        public bool isHide = false;
        public bool isDetect = false;
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
}