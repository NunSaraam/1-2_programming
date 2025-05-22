using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YDG_2025137064_0522 : MonoBehaviour
{

    void Start()
    {
        // 4-9
        string[] array = { "사과", "배", "포도", "딸기", "바나나" };

        foreach (string item in array)
        {
            Debug.Log(item);
        }

        // 4-10
        string[] array1 = { "사과", "배", "포도", "딸기", "바나나" };

        foreach (var item in array)
        {
            Debug.Log(item);
        }

        // 4-11
        string stars;
        for (int n = 0; n < 10; n++)
        {
            stars = "";
            for (int o = 0; o < n + 1; o++)
            {
                stars += "*";
            }
            Debug.Log(stars);
        }

        // 4-12 변형
        string str;
        int s = 10;
        for (int n = 1; n <= s; n++)
        {
            str = "";

            for (int o = 0; o < s - n; o++)
            {
                str += "  ";
            }

            for (int t = 0; t < n; t++)
            {
                str += "*";
            }

            Debug.Log(str);
        }

        // 4-14
        for (int j = 1; j < 10; j++)
        {
            if (j % 2 == 0)
            {
                continue;
            }
            Debug.Log(j);
        }

        // 4-14 변형
        for (int j = 1; j < 10; j++)
        {
            if (j % 2 == 1)
            {
                Debug.Log(j);
            }
        }


        // 4-1(1)
        string input = "photato Tomato";
        Debug.Log(input.ToUpper());
        Debug.Log(input.ToLower());

        // 4-1(2)
        string input2 = "감자 고구마 토마토";
        string[] inputs = input2.Split(new char[] { ' ' });

        foreach (var Item in inputs)
        {
            Debug.Log(Item);
        }

        // 4-1(3)
        string input3 = " test          \n";
        Debug.Log("::" + input3.Trim() + "::");

        // 4-1(4)
        string[] array2 = { "감자", "고구마", "토마토", "가지" };
        Debug.Log(string.Join(",", array2));
    }

}