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
public static class MathHelper
{
    // Limits a value to a certain range
    public static int Clamp(int value, int min, int max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }
}

public class ColorRGB
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }

    // Default constructor – sets color to black (0,0,0)
    public ColorRGB()
    {
        Red = 0;
        Green = 0;
        Blue = 0;
    }

    // Constructor with parameters
    public ColorRGB(int red, int green, int blue)
    {
        Red = MathHelper.Clamp(red, 0, 255);
        Green = MathHelper.Clamp(green, 0, 255);
        Blue = MathHelper.Clamp(blue, 0, 255);
    }

    // Random color constructor
    public static ColorRGB GenerateRandomColor()
    {
        Random rnd = new Random();
        return new ColorRGB(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
    }
    //Returns RGB values ​​as text
    public override string ToString()
    {
        return $"RGB({Red}, {Green}, {Blue})";
    }

    // Returns as System.Drawing.Color
    public System.Drawing.Color ToColor()
    {
        return System.Drawing.Color.FromArgb(Red, Green, Blue);
    }
}
