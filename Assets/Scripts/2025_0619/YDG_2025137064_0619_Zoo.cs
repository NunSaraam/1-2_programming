using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YDG_2025137064_0619_Zoo : MonoBehaviour
{

    private void Start()
    {
        YDG_2025137064_0619_Animal tom = new YDG_2025137064_0619_Animal();
        tom.name = "��";
        tom.sound = "�Ŀ�";
        tom.PlaySound();


        YDG_2025137064_0619_Animal jerry = new YDG_2025137064_0619_Animal();
        jerry.name = "����";
        jerry.sound = "����";
        jerry.PlaySound();

        jerry = tom;
        jerry.name = "��Ű";

        tom.PlaySound();
        jerry.PlaySound();
  
    }
}
