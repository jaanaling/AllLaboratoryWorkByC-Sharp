using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ThreeDim
{
    class Vector3D
    {
        float[] a;
        public Vector3D(float x, float y, float z)
        {
            a = new float[3];
            a[0] = x; a[1] = y; a[2] = z;
        }

        public Vector3D()
        {
            a = new float[3];
            for (int i = 0; i < 3; i++) a[i] = 0.0f;
        }

        public float x
        {
            get { return a[0]; }
        }

        public float y
        {
            get { return a[1]; }
        }

        public void Mult(Matrix3D A, Vector3D B)
        {
            for (int i = 0; i < 3; i++)
            {
                a[i] = 0.0f;
                for (int k = 0; k < 3; k++)
                    a[i] += A[i, k] * B.a[k];
            }
        }

        public float this[int i]
        {
            get
            {
                if (i > 2) new ArgumentOutOfRangeException("Vector index is wrong");
                return a[i];
            }
            set
            {
                if (i > 2) new ArgumentOutOfRangeException("Vector index is wrong");
                a[i] = value;
            }
        }

        public void copy(Vector3D Z)
        {
            for (int i = 0; i < 3; i++) a[i] = Z.a[i];
        }
    }
}
