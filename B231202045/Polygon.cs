
/******************************************************************************
 *                    OBJECT ORIENTED PROGRAMMING PROJECT                     *
 ****************************************************************************** 
 * Student Name   : Berkan                                                    *
 * Student Surname: Akten                                                     *
 * Student Number : B231202045                                                *
 * Lecturer       : Gülüzar Çit                                               *
 * Course Name    : OBJECT ORIENTED PROGRAMMING                               *
 * Assignment     : Term Project                                              *
 * Date Submitted : 15.05.2025                                                *
 ******************************************************************************/
using System;
using System.Collections.Generic;

public class Polygon
{
    private double initialRotationAngle = 0;
    public Point2D Center { get; set; } // The center of polygpn(x,y)
    public int Length { get; set; }            // Side length 
    public int NumberOfSides { get; set; }     // number of sides
    public ColorRGB Color { get; set; } //Color of the polygon (in RGB format)
    public List<Point2D> Vertices { get; private set; } = new List<Point2D>(); //The list of corner points

    // Constructor with no parameter (creates with random values)
    public Polygon()
    {
        Random rnd = new Random();
        Center = new Point2D(); // random (x,y)
        Length = rnd.Next(3, 10); //Side length 3 to 9 
        NumberOfSides = rnd.Next(3, 11); //Number of sides 3 to 10 
        Color = ColorRGB.GenerateRandomColor(); //Random  color
    }

    // Constructor with parameters (The values which are given by users)
    public Polygon(Point2D center, int length, int numberOfEdges, ColorRGB color)
    {
        Center = center;
        Length = length;
        NumberOfSides = numberOfEdges;
        Color = color;
    }

    // Calculates corner points
    public void CalculateEdgeCoordinates(double rotationAngleDegrees = 0)
    {
        Vertices.Clear(); // Clear last corners
        double anglePolygon = 360.0 / NumberOfSides; // Angle between each corner
        double radius = Length;

        for (int i = 0; i < NumberOfSides; i++)
        {// Calculate the angle and convert it to radians
            double angle = (anglePolygon * i + rotationAngleDegrees) * Math.PI / 180.0;

         // x and y coordinates are calculated trigonometrically

            double x = Center.X + radius * Math.Cos(angle);
            double y = Center.Y + radius * Math.Sin(angle);

         // New corner is added to the list
            Vertices.Add(new Point2D(x, y));
        }
    }

    // Rotate polygon with choosen angle (CW or CCW)
    // Angle is rotating angle
    // counterClockWise is rotates counterclockwise
    public void RotatePolygon(double angle, bool counterClockwise = false)
    {
        double delta;
        if (counterClockwise)
        {
            delta = -angle;
        }
        else
        {
            delta = angle;
        }

        initialRotationAngle += delta; // Added to the current rotation angle
        CalculateEdgeCoordinates(initialRotationAngle); // Calculate new vertices
    }


    //  Returns the corner points as text (for example: V1 = (2.00, 1.00))
    public List<string> GetVertexStrings()
    {
        List<string> output = new List<string>();
        for (int i = 0; i < Vertices.Count; i++)
        {
            var v = Vertices[i];
            output.Add($"V{i + 1} = ({v.X:F2}, {v.Y:F2})");
        }
        return output;
    }
}
