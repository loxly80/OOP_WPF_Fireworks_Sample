using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace OOP_WPF_Fireworks_Sample
{
  public class Rocket
  {
    private Random random = new Random();
    public Point Location { get; set; }
    public Brush Color { get; set; }
    public Vector Vector { get; set; }
    public int Level { get; set; }

    public Rocket(int level)
    {
      Level = level;
    }

    public Rocket(Point location, Brush color, Vector vector, int level)
    {
      Location = location;
      Color = color;
      Vector = vector;
      Level = level;
    }

    public List<Rocket> Explode()
    {
      List<Rocket> rockets = new List<Rocket>();
      if(Level > 0)
      {
        for (int i = 0; i < ; i++)
      }      
      return rockets;
    }
  }
}
