using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreeDim
{
    class Matrix3D
    {
        float[,] a;

        public void Rotate(int axis, float angle)
        {
            float s, c;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (i == j) a[i, j] = 1.0f;
                    else a[i, j] = 0.0f;
            c = Convert.ToSingle(Math.Cos(angle * Math.PI / 180.0));
            s = Convert.ToSingle(Math.Sin(angle * Math.PI / 180.0));
            switch (axis)
            {
                case 0:
                    a[1, 1] = a[2, 2] = c;
                    a[2, 1] = -(a[1, 2] = s);
                    break;
                case 1:
                    a[0, 0] = a[2, 2] = c;
                    a[2, 0] = -(a[0, 2] = -s);
                    break;
                case 2:
                    a[0, 0] = a[1, 1] = c;
                    a[1, 0] = -(a[0, 1] = s);
                    break;
                default:
                    new ArgumentOutOfRangeException("Matrix axis is wrong");
                    break;
            }
        }

        public Matrix3D()
        {
            a = new float[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (i == j) a[i, j] = 1.0f;
                    else a[i, j] = 0.0f;
        }
        public void Mult(Matrix3D A, Matrix3D B)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = 0.0f;
                    for (int k = 0; k < 3; k++)
                        a[i, j] += A.a[i, k] * B.a[k, j];
                }
        }

        public float this[int i, int j]
        {
            get
            {
                if (i > 2 || j > 2) new ArgumentOutOfRangeException("Matrix index is wrong");
                return a[i, j];
            }
        }

    }
}
