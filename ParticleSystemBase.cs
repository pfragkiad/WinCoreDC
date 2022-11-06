using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCoreDC;

public class Particle
{
    public float X, Y;
    public float Vx, Vy;

    public int MaxAge;

    public bool IsAlive;

    public int Age;
}


public class ParticleSystemBase
{
    protected List<Particle> _particles = new();
    public List<Particle> Particles { get => _particles; }


    public float ParticleSize { get; set; }

}
