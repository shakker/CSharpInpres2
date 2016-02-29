using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Ca fonctionne */

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> ListShape = new List<Shape>();
            List<Segment> ListSegment = new List<Segment>();
            List<Square> ListSquare = new List<Square>();
            List<Circle> ListCircle = new List<Circle>();

            mypoint p1 = new mypoint(4, 5);
            mypoint p2 = new mypoint(2, 1);
            mypoint pBis = new mypoint(p1);

            Console.WriteLine("Points :");
            Console.WriteLine("Constructeur par defaut:");
            p1.Draw();
            Console.WriteLine("\n");
            p2.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Copie de p1 : ");
            pBis.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            Segment seg0 = new Segment();
            Segment seg1 = new Segment(p1,p2);
            Segment seg2 = new Segment(seg1);
            Segment seg3 = new Segment(2,6,3,1);

            Console.WriteLine("Segments :");
            Console.WriteLine("Constructeur par defaut :");
            seg0.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("A partir de deux points :");
            seg1.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Copie du precedent :");
            seg2.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("A partir de quatre coordonnees :");
            seg3.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            Square squ0 = new Square();
            Square squ1 = new Square(2, 5, 7);
            Square squ2 = new Square(squ1);
            Square squ3 = new Square(5,p1);

            Console.WriteLine("Carre :");
            Console.WriteLine("Constructeur par defaut :");
            squ0.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("A partir de coordonnees et longueur :");
            squ1.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Copie du precedent :");
            squ2.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("A partir de longueur et point :");
            squ3.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            Circle c0 = new Circle();
            Circle c1 = new Circle(2, 5, 7);
            Circle c2 = new Circle(c1);
            Circle c3 = new Circle(1, p1);

            Console.WriteLine("Cercle :");
            Console.WriteLine("Constructeur par defaut :");
            c0.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("A partir de coordonnees et rayon :");
            c1.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Copie du precedent :");
            c2.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("A partir de rayon et point :");
            c3.Draw();
            Console.WriteLine("\n");
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            ListShape.Add(seg0);
            ListShape.Add(seg1);
            ListShape.Add(seg2);
            ListShape.Add(seg3);

            ListShape.Add(squ0);
            ListShape.Add(squ1);
            ListShape.Add(squ2);
            ListShape.Add(squ3);

            ListShape.Add(c0);
            ListShape.Add(c1);
            ListShape.Add(c2);
            ListShape.Add(c3);

            Console.WriteLine("Liste :");
            foreach (Shape sh in ListShape)
            {
                sh.Draw();
            }

            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

           Console.WriteLine("Liste avec IPointy :");
           foreach (Shape sh in ListShape)
            {
                if (sh is IPointy)
                {
                    sh.Draw();
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Liste sans IPointy.");
            foreach (Shape sh in ListShape)
            {
                if (!(sh is IPointy))
                {
                    sh.Draw();
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();




            Square EquSquare = new Square(1, 2, 5) ;

            ListSquare.Add(new Square(1, 3, 5));
            ListSquare.Add(new Square(6, 5, 6));
            ListSquare.Add(new Square(1, 2, 1));
            ListSquare.Add(new Square(4, 6, 4));
            ListSquare.Add(new Square(3, 4, 2));

            Console.WriteLine("Liste de carre :");

            foreach (Square sh in ListSquare)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            ListSquare.Sort();
            Console.WriteLine("Apres tri :");
            foreach (Square sh in ListSquare)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();


            MySquareAbscisseComparer SquComp = new MySquareAbscisseComparer();
            ListSquare.Sort(SquComp);

            Console.WriteLine("Apres tri sur abscisse :");
            foreach (Square sh in ListSquare)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Liste de comparaison au carre :" + EquSquare);
            foreach (Square sh in ListSquare)
            {
                if (sh.Equals(EquSquare))
                {
                    Console.WriteLine("Le carré " + sh + " est égal");
                } 
                else
                {
                    Console.WriteLine("Le carré " + sh + " n'est pas égal");
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            mypoint InPoint = new mypoint(6, 4);
            Console.WriteLine("Liste de comparaison au point :" + InPoint);
            foreach (Square sh in ListSquare)
            {
                if (sh.IsPointIn(InPoint))
                {
                    Console.WriteLine("Le point est dans le carre : " + sh);
                }
                else
                {
                    Console.WriteLine("Le point n'est pas dans le carre : " + sh);
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();



            Circle EquCircle = new Circle(3, 2, 4);

            ListCircle.Add(new Circle(1, 6, 5));
            ListCircle.Add(new Circle(6, 2, 4));
            ListCircle.Add(new Circle(3, 1, 1));
            ListCircle.Add(new Circle(4, 3, 4));
            ListCircle.Add(new Circle(2, 4, 2));

            Console.WriteLine("Liste de cercle :");

            foreach (Circle sh in ListCircle)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            ListCircle.Sort();
            Console.WriteLine("Apres tri :");
            foreach (Circle sh in ListCircle)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();


            MyCircleAbscisseComparer CirComp = new MyCircleAbscisseComparer();
            ListCircle.Sort(CirComp);

            Console.WriteLine("Apres tri sur abscisse :");
            foreach (Circle sh in ListCircle)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Liste de comparaison au cercle :" + EquCircle);
            foreach (Circle sh in ListCircle)
            {
                if (sh.Equals(EquCircle))
                {
                    Console.WriteLine("Le cercle " + sh + " est égal");
                }
                else
                {
                    Console.WriteLine("Le cercle " + sh + " n'est pas égal");
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            mypoint InPointCir = new mypoint(6, 4);
            Console.WriteLine("Liste de comparaison au point :" + InPointCir);
            foreach (Circle sh in ListCircle)
            {
                if (sh.IsPointIn(InPointCir))
                {
                    Console.WriteLine("Le point est dans le cercle : " + sh);
                }
                else
                {
                    Console.WriteLine("Le point n'est pas dans le cercle : " + sh);
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();



            Segment EquSegment = new Segment(3, 1, 1, 2);

            ListSegment.Add(new Segment(1, 6, 5, 6));
            ListSegment.Add(new Segment(6, 2, 4, 3));
            ListSegment.Add(new Segment(3, 1, 1, 2));
            ListSegment.Add(new Segment(4, 3, 4, 4));
            ListSegment.Add(new Segment(2, 4, 2, 3));

            Console.WriteLine("Liste de segment :");

            foreach (Segment sh in ListSegment)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            ListSegment.Sort();
            Console.WriteLine("Apres tri :");
            foreach (Segment sh in ListSegment)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();


            MySegmentAbscisseComparer SegComp = new MySegmentAbscisseComparer();
            ListSegment.Sort(SegComp);

            Console.WriteLine("Apres tri sur abscisse :");
            foreach (Segment sh in ListSegment)
            {
                sh.Draw();
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Liste de comparaison au segment :" + EquSegment);
            foreach (Segment sh in ListSegment)
            {
                if (sh.Equals(EquSegment))
                {
                    Console.WriteLine("Le segment " + sh + " est égal");
                }
                else
                {
                    Console.WriteLine("Le segment " + sh + " n'est pas égal");
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();

            mypoint InPointSeg = new mypoint(3, 1);
            Console.WriteLine("Liste de comparaison au point :" + InPointSeg);
            foreach (Segment sh in ListSegment)
            {
                if (sh.IsPointIn(InPointSeg))
                {
                    Console.WriteLine("Le point est dans le segment : " + sh);
                }
                else
                {
                    Console.WriteLine("Le point n'est pas dans le segment : " + sh);
                }
            }
            Console.WriteLine("Appuyez sur entrer");
            Console.ReadKey();
            Console.Clear();



            Console.WriteLine("On reprend la 1ere liste");
            Console.WriteLine("Tri sur la surface");
            ListShape.Sort();
            foreach (Shape sh in ListShape)
            {
                sh.Draw();
                if(sh.Surface() != 100000)
                    Console.WriteLine("Surface: " + sh.Surface());
                else
                    Console.WriteLine("Surface: impossible");
                Console.WriteLine("\n");
            }

            Console.WriteLine("Appuyez sur entrer pour terminer");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
