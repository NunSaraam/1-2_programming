using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YDG_2025137064_0612 : MonoBehaviour
{
    class Box
    {
        private int width;
        
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    Debug.Log("너비는 자연수를 입력해 주세요.");
                }
            }
        }

        private int height;
        
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    Debug.Log("높이는 자연수를 입력해주세요.");
                }
            }
        }

        public Box(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area() { return this.Width * this.Height; }
    }

    class Square
    {
        private int width;

        public int Width
        {
            get { return width; }
            set {  width = value; }
        }

        public int Height { get; private set; }
    }

    private void Start()
    {
        Box box = new Box(-10, -20);

        box.Width = -200;
        box.Height = -100;

        Debug.Log(box.Width + ", " + box.Height);

        Square sq = new Square();
        sq.Width = 10;
        //sq.Height = 10;

    }
}
