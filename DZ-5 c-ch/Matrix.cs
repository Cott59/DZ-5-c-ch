using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace DZ_5_c_ch
{
    
    public class MyMatrix
    {
        public int[,] A { get; set; }
        public MyMatrix() {
            A = new int[3, 3];
        }
        public MyMatrix(int a, int s, int d, int f, int g, int h, int j, int k, int l)
        {
            A=new int[3,3];
            A[0, 0] = a; A[0, 1] = s; A[0, 2] = d;
            A[1, 0] = f; A[1, 1] = g; A[1, 2] = h;
            A[2, 0] = j; A[2, 1] = k; A[2, 2] = l;
        }

        public void Info()
        {
            Console.WriteLine($"{A[0, 0]} {A[0, 1]} {A[0, 2]}");
            Console.WriteLine($"{A[1, 0]} {A[1, 1]} {A[1, 2]}");
            Console.WriteLine($"{A[2, 0]} {A[2, 1]} {A[2, 2]}");
        }

        public static MyMatrix operator *(MyMatrix obj, int num)
        {
            obj.A[0,0] *= num; obj.A[0, 1] *= num; obj.A[0, 2] *= num;
            obj.A[1,0] *= num; obj.A[1, 1] *= num; obj.A[1, 2] *= num;
            obj.A[2,0] *= num; obj.A[2, 1] *= num; obj.A[2, 2] *= num;
            return obj;
        }
        public static MyMatrix operator *(MyMatrix obj1, MyMatrix obj2)
        {
            MyMatrix obj = new MyMatrix();
            obj.A[0, 0] = (obj1.A[0, 0] * obj2.A[0, 0])  +  (obj1.A[0, 1] * obj2.A[1, 0])  +  (obj1.A[0, 2] * obj2.A[2, 0]);
            obj.A[0, 1] = (obj1.A[0, 0] * obj2.A[0, 1])  +  (obj1.A[0, 1] * obj2.A[1, 1])  +  (obj1.A[0, 2] * obj2.A[2, 1]);
            obj.A[0, 2] = (obj1.A[0, 0] * obj2.A[0, 2])  +  (obj1.A[0, 1] * obj2.A[1, 2])  +  (obj1.A[0, 2] * obj2.A[2, 2]); 
            obj.A[1, 0] = (obj1.A[1, 0] * obj2.A[0, 0])  +  (obj1.A[1, 1] * obj2.A[1, 0])  +  (obj1.A[1, 2] * obj2.A[2, 0]);
            obj.A[1, 1] = (obj1.A[1, 0] * obj2.A[0, 1])  +  (obj1.A[1, 1] * obj2.A[1, 1])  +  (obj1.A[1, 2] * obj2.A[2, 1]); 
            obj.A[1, 2] = (obj1.A[1, 0] * obj2.A[0, 2])  +  (obj1.A[1, 1] * obj2.A[1, 2])  +  (obj1.A[1, 2] * obj2.A[2, 2]); 
            obj.A[2, 0] = (obj1.A[2, 0] * obj2.A[0, 0])  +  (obj1.A[2, 1] * obj2.A[1, 0])  +  (obj1.A[2, 2] * obj2.A[2, 0]);
            obj.A[2, 1] = (obj1.A[2, 0] * obj2.A[0, 1])  +  (obj1.A[2, 1] * obj2.A[1, 1])  +  (obj1.A[2, 2] * obj2.A[2, 1]);
            obj.A[2, 2] = (obj1.A[2, 0] * obj2.A[0, 2])  +  (obj1.A[2, 1] * obj2.A[1, 2])  +  (obj1.A[2, 2] * obj2.A[2, 2]);

            return obj;
        }
        public static MyMatrix operator +(MyMatrix obj1, MyMatrix obj2)
        {
            MyMatrix obj = new MyMatrix();
            obj.A[0, 0] = obj1.A[0, 0] + obj2.A[0, 0];
            obj.A[0, 1] = obj1.A[0, 1] + obj2.A[0, 1];
            obj.A[0, 2] = obj1.A[0, 2] + obj2.A[0, 2];
            obj.A[1, 0] = obj1.A[1, 0] + obj2.A[1, 0];
            obj.A[1, 1] = obj1.A[1, 1] + obj2.A[1, 1];
            obj.A[1, 2] = obj1.A[1, 2] + obj2.A[1, 2];
            obj.A[2, 0] = obj1.A[2, 0] + obj2.A[2, 0];
            obj.A[2, 1] = obj1.A[2, 1] + obj2.A[2, 1];
            obj.A[2, 2] = obj1.A[2, 2] + obj2.A[2, 2];

            return obj;
        }
        public static MyMatrix operator -(MyMatrix obj1, MyMatrix obj2)
        {
            MyMatrix obj;
            obj = obj1+(obj2*(-1));
            return obj;
        }
        public static bool operator ==(MyMatrix obj1, MyMatrix obj2)
        {
            if (obj1.A[0, 0] == obj2.A[0, 0] &&
                obj1.A[0, 1] == obj2.A[0, 1] &&
                obj1.A[0, 2] == obj2.A[0, 2] &&
                obj1.A[1, 0] == obj2.A[1, 0] &&
                obj1.A[1, 1] == obj2.A[1, 1] &&
                obj1.A[1, 2] == obj2.A[1, 2] &&
                obj1.A[2, 0] == obj2.A[2, 0] &&
                obj1.A[2, 1] == obj2.A[2, 1] &&
                obj1.A[2, 2] == obj2.A[2, 2])
                return true;
            else
                return false;   
        }
        public static bool operator !=(MyMatrix obj1, MyMatrix obj2)
        {
            if (obj1.A[0, 0] == obj2.A[0, 0] &&
                obj1.A[0, 1] == obj2.A[0, 1] &&
                obj1.A[0, 2] == obj2.A[0, 2] &&
                obj1.A[1, 0] == obj2.A[1, 0] &&
                obj1.A[1, 1] == obj2.A[1, 1] &&
                obj1.A[1, 2] == obj2.A[1, 2] &&
                obj1.A[2, 0] == obj2.A[2, 0] &&
                obj1.A[2, 1] == obj2.A[2, 1] &&
                obj1.A[2, 2] == obj2.A[2, 2])
                return false;
            else
                return true;
        }

        public override bool Equals(object? obj)
        {
            if(obj is MyMatrix myMatrix)
            { 
                   return obj.GetType() == myMatrix.GetType();
            }
          return false;
        }

        public override int GetHashCode()
        {
            return A.GetHashCode();
        }
    }
   
}
