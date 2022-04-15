using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ThreeDim
{
    class Cube3D
    {
        Vector3D[,] P, Q;

        public Cube3D()
        {
            P = new Vector3D[4, 2];
            Q = new Vector3D[4, 2];

            P[0, 0] = new Vector3D(1, 1, 1);
            P[1, 0] = new Vector3D(-1, 1, 1);
            P[2, 0] = new Vector3D(-1, -1, 1);
            P[3, 0] = new Vector3D(1, -1, 1);
         
           
            P[0, 1] = new Vector3D(1, 1, -1);
            P[1, 1] = new Vector3D(-1, 1, -1);
            P[2, 1] = new Vector3D(-1, -1, -1);
            P[3, 1] = new Vector3D(1, -1, -1);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                {
                    Q[i, j] = new Vector3D();
                    Q[i, j].copy(P[i, j]);
                }

        }

        public void Rotate(Matrix3D R)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    Q[i, j].Mult(R, P[i, j]);
        }

        public void Paint(Graphics g, float scale)
        {
            int j;
            for (int k = 0; k < 2; k++)
                for (int i = 0; i < 4; i++)
                {
                    j = i + 1; if (j > 3) j = 0;
                    g.DrawLine(Pens.Black,
                        Q[i, k].x * scale, Q[i, k].y * scale,
                        Q[j, k].x * scale, Q[j, k].y * scale);
                }
            for (int i = 0; i < 4; i++)
                g.DrawLine(Pens.Blue,
                    Q[i, 0].x * scale, Q[i, 0].y * scale,
                    Q[i, 1].x * scale, Q[i, 1].y * scale);
        }

    }
}
