using GTA;
using GTA.Math;

namespace EnableAllinteriors
{
  public class EAIBLip : Script
  {
    public Vector3 Pos { get; set; }

    public int BlipID { get; set; }

    public string name { get; set; }

    public bool Shortrange { get; set; }

    public EAIBLip()
    {
    }

    public EAIBLip(Vector3 p, int b, string n, bool s)
    {
      this.Pos = p;
      this.BlipID = b;
      this.name = n;
      this.Shortrange = s;
    }
  }
}
