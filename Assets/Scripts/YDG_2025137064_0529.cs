using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class YDG_2025137064_0529 : MonoBehaviour
{
    // 5 - 6 class
    class Product
    {
        public string name;
        public int price;
    }

    // 5 - 7 class
    class MyMath
    {
        public static double PI = 3.141592;
    }

    // 5 - 1 class
    class Student
    {
        public string name;
        public int grade;
    }

    void Start()
    {
        // 8-1 변형예제
        System.Random random = new System.Random();

        Debug.Log(random.NextDouble() + random.Next(0, 9));
        Debug.Log(random.NextDouble() + random.Next(0, 9));
        Debug.Log(random.NextDouble() + random.Next(0, 9));
        Debug.Log(random.NextDouble() + random.Next(0, 9));
        Debug.Log(random.NextDouble() + random.Next(0, 9));
        
        // 5 - 3
        List<int> list = new List<int>();

        list.Add(52);
        list.Add(273);
        list.Add(32);
        list.Add(64);

        foreach (var item in list)
        {
            Debug.Log("Count" + list.Count + "\titem: " + item);
        }

        // 5 - 4
        List<int> listt = new List<int>();

        listt.Add(52);
        listt.Add(273);
        listt.Add(32);
        listt.Add(64);

        foreach (var item in listt)
        {
            Debug.Log("Count" + listt.Count + "\titem: " + item);
        }

        listt.Remove(52);

        foreach (var item in listt)
        {
            Debug.Log("Count" + listt.Count + "\titem: " + item);
        }

        // 5 - 5
        Debug.Log(Mathf.Abs(-52273));
        Debug.Log(Mathf.Ceil(52.273f));
        Debug.Log(Mathf.Floor(52.273f));
        Debug.Log(Mathf.Max(52, 273));
        Debug.Log(Mathf.Min(52, 273));
        Debug.Log(Mathf.Round(52.273f));

        // 5 - 6
        Product product = new Product();

        product.name = "감자";
        product.price = 2000;

        Debug.Log(product.name + " : " + product.price + "원");

        // 5 - 7
        Debug.Log(MyMath.PI);

        // 5 - 1
        List<Student> studentList = new List<Student>();
        studentList.Add(new Student() { name = "홍인록", grade = 1 });
        studentList.Add(new Student() { name = "황이우회", grade = 2 });
        studentList.Add(new Student() { name = "형창용", grade = 3 });
        studentList.Add(new Student() { name = "박서영", grade = 4 });
        studentList.Add(new Student() { name = "김지원", grade = 1 });
        studentList.Add(new Student() { name = "차경호하", grade = 2 });
        
        // 5 - 1 (2)
        for (int i = 0; i < studentList.Count; i++)
        {
            if (studentList[i].name == "김지원")
            {
                studentList.RemoveAt(i);
            }
        }

        foreach (Student item in studentList)
        {
            Debug.Log(item.name + " : " + item.grade);
        }

        // 응용예제  (1)
        //List<Student> studentList = new List<Student>();
        studentList.Add(new Student() { name = "홍인록", grade = 1 });
        studentList.Add(new Student() { name = "황이우회", grade = 2 });
        studentList.Add(new Student() { name = "형창용", grade = 3 });
        studentList.Add(new Student() { name = "박서영", grade = 4 });
        studentList.Add(new Student() { name = "김지원", grade = 1 });
        studentList.Add(new Student() { name = "차경호하", grade = 2 });

        foreach (Student item in studentList)
        {
            if (item.grade >= 3)
            {
                studentList.Remove(item);
            }
            else
            {
                Debug.Log(item.name + " : " + item.grade);
            }
        }

        // 응용예제  (2)
        //List<Student> studentList = new List<Student>();
        studentList.Add(new Student() { name = "홍인록", grade = 1 });
        studentList.Add(new Student() { name = "황이우회", grade = 2 });
        studentList.Add(new Student() { name = "형창용", grade = 3 });
        studentList.Add(new Student() { name = "박서영", grade = 4 });
        studentList.Add(new Student() { name = "김지원", grade = 1 });
        studentList.Add(new Student() { name = "차경호하", grade = 2 });

        for (int i = 0; i < studentList.Count; i++)
        {
            if (studentList[i].grade <= 3)
            {
                studentList.RemoveAt(i);
            }
        }
    }
}



