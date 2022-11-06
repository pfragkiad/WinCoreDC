using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinCoreDC;



public class ParticleSystem : ParticleSystemBase
{


    public int MaxAge { get; set; }

    public ParticleSystem( float size, int maxAge)
    {
        ParticleSize = size;
        MaxAge = maxAge;
    }

    public void AddParticle(float x, float y)
    {
        _particles.Add(
            new Particle()
            {
                X = x,
                Y = y,
                Vx = -1.0f + 2.0f * Random.Shared.NextSingle(),
                Vy = -5.0f + 4.0f * Random.Shared.NextSingle(),
                MaxAge = Random.Shared.Next(35, this.MaxAge),
                IsAlive = true
            });
    }

    public void IncreaseEnergy()
    {
        foreach (var p in _particles)
        {
            p.Vx = 1.4f * p.Vx;
            p.Vy = 1.4f * p.Vy;
        }
    }



    public void UpdatePositions()
    {
        for (int i = _particles.Count - 1; i >= 0; i--)
            if (!_particles[i].IsAlive)
                _particles.RemoveAt(i);

        foreach(var p in _particles)
        {
            p.Age++;
            if (p.Age > p.MaxAge) p.IsAlive = false;
            if (!p.IsAlive) continue;

            p.X += p.Vx;
            p.Y +=p.Vy;
        }
    }


}
