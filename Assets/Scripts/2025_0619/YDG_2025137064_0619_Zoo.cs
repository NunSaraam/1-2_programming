using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YDG_2025137064_0619_Zoo : MonoBehaviour
{

    private void Start()
    {
        YDG_2025137064_0619_Animal tom = new YDG_2025137064_0619_Animal();
        tom.name = "Åè";
        tom.sound = "³Ä¿Ë";

        YDG_2025137064_0619_Animal jerry = new YDG_2025137064_0619_Animal();
        jerry.name = "Á¦¸®";
        jerry.sound = "ÂïÂï";

        tom.PlaySound();
        jerry.PlaySound();

        jerry = tom;
        jerry.name = "¹ÌÅ°";

        tom.PlaySound();
        jerry.PlaySound();
    }
}
