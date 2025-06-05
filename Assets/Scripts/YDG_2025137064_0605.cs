using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class YDG_2025137064_0605 : MonoBehaviour
{
    // 10 - 1
    class Test
    {
        public int Power(int x)
        {
            return x * x;
        }
    }

    // 10 - 2
    class TestC
    {
        public int Sum(int min, int max)
        {
            int output = 0;
            for (int i = min; i <= max; i++)
            {
                output += i;
            }
            return output;
        }
    }

    // 6 - 4
    class MyMath
    {
        public static int Abs(int input)
        {
            if (input < 0)
            {
                return -input;
            }
            else
            {
                return input;
            }
        }
    }

    // 6 - 5
    class MyMathA
    {
        public static int Abs(int input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
        public static double Abs(double input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
        public static long Abs(long input)
        {
            if (input < 0) { return -input; }
            else { return input; }
        }
    }

    // 6 - 6
    class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;

        public Product(string name, int price)
        {
            Product.counter = counter + 1;
            this.id = counter;
            this.name = name;
            this.price = price;
        }
    }

    // 6 - 7
    class Product2
    {
        public string name;
        public int price;

        public Product2(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        Product2()
        {
            Debug.Log(this.name + "의 소멸자 호출");
        }
    }

    void Start()
    {
        // 10 - 1
        Test test = new Test();
        Debug.Log(test.Power(10));
        Debug.Log(test.Power(20));

        // 10 - 2
        TestC testC = new TestC();
        Debug.Log(testC.Sum(1, 100));

        // 10 - 3
        Debug.Log(MyMath.Abs(52));
        Debug.Log(MyMath.Abs(-273));

        // 6 - 5
        
        //int
        Debug.Log(MyMathA.Abs(52));
        Debug.Log(MyMathA.Abs(-273));

        //double
        Debug.Log(MyMathA.Abs(52.273));
        Debug.Log(MyMathA.Abs(-32.103));

        //long
        Debug.Log(MyMathA.Abs(21474836470));
        Debug.Log(MyMathA.Abs(-21474836470));

        // 6 - 6
        Product productA = new Product("감자", 2000);
        Product productB = new Product("고구마", 3000);

        Debug.Log(productA.id + ":" + productA.name);
        Debug.Log(productB.id + ":" + productB.name);
        Debug.Log(Product.counter + "개 생성되었습니다.");

        // 6 - 7
        Product2 product2 = new Product2("과자", 1000);
    }

}
