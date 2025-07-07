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

public class Point2D
{
    public double X { get; set; }
    public double Y { get; set; }

    // Constructor with parameters
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Random constructor
    public Point2D()
    {
        Random rnd = new Random();
        X = rnd.Next(0, 4); //Random X between 0 and 3
        Y = rnd.Next(0, 4); //Random Y between 0 and 3
    }

    public void PrintCoordinates()
    {
        Console.WriteLine($"(X, Y) = ({X}, {Y})");
    }
    
    // Calculates the polar coordinates of the point
    // r = distance to origin, θ = angle (degrees)
    public (double r, double theta) CalculatePolarCoordinates()
    {
        double r = Math.Sqrt(X * X + Y * Y); // Pisagor theorem
        double theta = Math.Atan2(Y, X) * (180 / Math.PI); //radian to angle
        return (r, theta);
    }
    // Creates a new point using the given polar coordinates
    public static Point2D CalculateCartesianCoordinates(double r, double thetaDegrees)
    {
        double theta = thetaDegrees * (Math.PI / 180); // Convert degrees to radians
        double x = r * Math.Cos(theta);
        double y = r * Math.Sin(theta);
        return new Point2D(x, y);
    }
    // Returns polar coordinates as a string
    public string PrintPolarCoordinates()
    {
        var polar = CalculatePolarCoordinates();
        return $"(r, θ) = ({polar.r:F2}, {polar.theta:F2}°)";
    }
}
