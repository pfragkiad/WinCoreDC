using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinCoreDC;

public class BoundedParticleSystem : ParticleSystemBase
{
    public RectangleF Bounds { get; set; }

    public void AddRandomParticle()
    {
        _particles.Add(
            new Particle()
            {
                X = Random.Shared.Next(0, (int)(Bounds.Width - ParticleSize)),
                Y = Random.Shared.Next(0, (int)(Bounds.Height - ParticleSize)),
                Vx = -2.0f + 4.0f * Random.Shared.NextSingle(),
                Vy = -1.0f + 2.0f * Random.Shared.NextSingle(),
                MaxAge = 10,
                IsAlive = true
            });
    }

    public void UpdatePositions()
    {
        for (int i = _particles.Count - 1; i >= 0; i--)
            if (!_particles[i].IsAlive)
                _particles.RemoveAt(i);

        foreach (var p in _particles)
        {
            p.Age++;
           // if (p.Age > p.MaxAge) p.IsAlive = false;
            if (!p.IsAlive) continue;

            var newX = p.X + p.Vx;
            if (newX >= Bounds.Width - ParticleSize)
            {
                newX = Bounds.Width - ParticleSize;
                p.Vx = -p.Vx;
            }
            else if (newX <= 0)
            {
                newX = 0;
                p.Vx = -p.Vx;
            }
            p.X = newX;

            p.Vy += 0.05f;
            var newY = p.Y + p.Vy;
            if (newY >= Bounds.Height - ParticleSize)
            {
                newY = Bounds.Height - ParticleSize;
                p.Vy = -p.Vy;
            }
            else if (newY <= 0)
            {
                newY = 0;
                p.Vy = -0.5f * p.Vy;
            }
            p.Y = (int)newY;
        }
    }


}
