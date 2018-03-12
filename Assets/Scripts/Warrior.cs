using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Warrior : SomeCharacter
{

    void Awake()
    {
        Skills SkillsObject = new Skills();
        StreamReader StrRdr = new StreamReader("Assets\\Data\\Skills.json");
        string jsonStr = StrRdr.ReadToEnd();
        JsonUtility.FromJsonOverwrite(jsonStr, SkillsObject);
        health = SkillsObject.Max_HP;
        jumpForce = SkillsObject.Jump_Force;
        speed = SkillsObject.Speed;
        weight = SkillsObject.Weight;
        nameObject = SkillsObject.NickName;
        Debug.Log("Characteristics: HP - " + health + " JF - " + jumpForce + " SPD - " + speed + " WGHT - " + weight + " NM - " + nameObject);
    }
}
