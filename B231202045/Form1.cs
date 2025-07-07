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
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace B231202045

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Polygon initialPolygon; // Represents the currently drawn polygon
       
        private void buttonDraw_Click(object sender, EventArgs e) // Runs when the "Draw" button is clicked
        {
           

            try
            {
                // Gets the center point from textboxes
                int centerx = int.Parse(textBoxX.Text);
                int centery = int.Parse(textBoxY.Text);
                Point2D center = new Point2D(centerx, centery);

                // Gets side length and number of sides from textboxes
                int length = int.Parse(textBoxLength.Text);
                int edges = int.Parse(textBoxEdges.Text);

                // Gets RGB colors from trackbars
                int r = trackBarR.Value;
                int g = trackBarG.Value;
                int b = trackBarB.Value;
                ColorRGB color = new ColorRGB(r, g, b);

                // Create Polygon object
                initialPolygon = new Polygon(center, length, edges, color);

                // Calculate the sides so that the angle is zero at the beginning
                initialPolygon.CalculateEdgeCoordinates(0);

                // Write corner points to ListBox
                listBoxVertices.Items.Clear();
                listBoxVertices.Items.Add("Edge Coordinates");
                listBoxVertices.Items.Add("----------------------------------------------------------------------");
                foreach (string vertex in initialPolygon.GetVertexStrings())
                {
                    listBoxVertices.Items.Add(vertex);
                }

                //Draw polygon
                DrawPolygon(initialPolygon);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        // Method to draw polygon on pictureBox
        private void DrawPolygon(Polygon polygon)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White); // Make background white

                // Find the max value of X and Y
                double maxX = polygon.Vertices.Max(p => Math.Abs(p.X));
                double maxY = polygon.Vertices.Max(p => Math.Abs(p.Y));

                // Calculate the scale (divide by 1.1 to leave some space)
                double scaleX = pictureBox1.Width / (2 * maxX * 1.1);
                double scaleY = pictureBox1.Height / (2 * maxY * 1.1);
                double scale = Math.Min(scaleX, scaleY); // The smallest scale is chosen so that it fits    

                // Convert points
                PointF[] points = polygon.Vertices.Select(p =>
                    new PointF(
                        (float)(p.X * scale + pictureBox1.Width / 2),
                        (float)(p.Y * scale + pictureBox1.Height / 2)
                    )).ToArray();
                // Draw with specified color
                Pen pen = new Pen(polygon.Color.ToColor(), 2);
                g.DrawPolygon(pen, points);
            }

            pictureBox1.Image = bmp; // transfer drawing to pictureBox
        }
        // It works when the "Rotate" button is clicked
        private void buttonRotate_Click(object sender, EventArgs e)
        {
            if (initialPolygon == null)
            {
                MessageBox.Show("Önce bir çokgen çizmeniz gerekiyor.");
                return;
            }

            try
            {
                int angle = int.Parse(textBoxAngle.Text);
                bool isCCW = checkBoxCCW.Checked;

                // Rotate polygon
                initialPolygon.RotatePolygon(angle, isCCW);

               
                listBoxVertices.Items.Clear();
                listBoxVertices.Items.Add("Edge Coordinates");
                listBoxVertices.Items.Add("-----------------------------------------------------------------");

                // Write new coordinates to listbox
                foreach (var v in initialPolygon.GetVertexStrings())
                {
                    listBoxVertices.Items.Add(v);
                }

                // Draw again
                DrawPolygon(initialPolygon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        //Clicking the "Reset" button creates a polygon with random parameters
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();

            // Random center point
            int centerX = rastgele.Next(0, 4);
            int centerY = rastgele.Next(0, 4);

            // Other random parameters
            int length = rastgele.Next(3, 10);
            int edges = rastgele.Next(3, 11);
            int red = rastgele.Next(0, 256);
            int green = rastgele.Next(0, 256);
            int blue = rastgele.Next(0, 256);
            int angle = 30; // veya 0

            // Update form members
            textBoxX.Text = centerX.ToString();
            textBoxY.Text = centerY.ToString();
            textBoxLength.Text = length.ToString();
            textBoxEdges.Text = edges.ToString();
            textBoxAngle.Text = angle.ToString();
            trackBarR.Value = red;
            trackBarG.Value = green;
            trackBarB.Value = blue;

            // Creates new polygon
            var center = new Point2D(centerX, centerY);
            var color = new ColorRGB(red, green, blue);
            initialPolygon = new Polygon(center, length, edges, color);
            initialPolygon.CalculateEdgeCoordinates();

            // Draw
            DrawPolygon(initialPolygon);
            //Update the list
            listBoxVertices.Items.Clear();
            listBoxVertices.Items.Add("Edge Coordinates");
            listBoxVertices.Items.Add("------------------------------------------------------------");
            foreach (var v in initialPolygon.GetVertexStrings())
            {
                listBoxVertices.Items.Add(v);
            }
        }

        
    }
}
