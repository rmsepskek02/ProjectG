using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 유닛이 가지고 있을 데이터
public class UnitData 
{
    // 피지컬데이터
    // hp
    // mp
    // 공격력
    // 방어력
    // 실드
    // 이동속도
    // 사거리
    // 공격속도
    // 디텍팅 범위
    public int hp = 0;
    public int mp = 0;
    public int atk = 0;
    public int armor = 0;
    public int shield = 0;
    public int moveSpeed = 0;
    public int atkRange = 0;
    public int atkSpeed = 0;
    public int detectRange = 0;

    // 타입 데이터
    // 종족타입
    // 용도 - 빌더 기본AI유닛  중립헌팅유닛
    // 크기타입 대중소
    // 공격타입 폭발 타격 관통
    // 속성타입 물불전기등
    // 유닛타입 인간 기계 정령 등
    public int kind = 0;
    public string usage = ""; // AU BU NHU NU
    public int size = 0;
    public string atkType = "";
    public string atrType = "";
        public string unitType = "";

    // 자원 데이터
    // 요구 자원
    public int[] consume;
    public string[] resourceType; // gold silver bronze

    // 기타 데이터
    // 공중 지상
    // 은신여부
    // 디텍팅여부
    // 공격여부
    // 대공
    // 대지
    public bool isGround = true;
    public bool ishide = false;
    public bool isDetect = false;
        public bool isHunt = false; // 중립유닛 공격가능여부
        public bool isControl = false; // 유저가 컨트롤할수있는지 여부
    public bool isAttack = true;
    public bool isATG = true; // Attack To Ground
    public bool isATA = false; // Attack To Air

    // 아군 적군 구분하는법?? 서버작업이 필요하는것으로 보임
    //public int Faction = 0; // 0 - 퍼플 1 - 블루

    // 마법 데이터 - 추후 작성 오브젝트?
    // 마법스킬 데이터
    // 마법여부
}
