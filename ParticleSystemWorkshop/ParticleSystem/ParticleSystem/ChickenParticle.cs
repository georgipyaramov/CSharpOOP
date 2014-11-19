using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParticleSystem
{
    public class ChickenParticle : ChaoticParticle
    {
        private readonly MatrixCoords stopToCreateNew = new MatrixCoords(0, 0);
        private int tickMilliSecs;
        private int ticks;

        public ChickenParticle(MatrixCoords position, MatrixCoords speed, Random randomGenerator, int tickMilliSecs = 500, int ticks = 4)
            : base(position, speed, randomGenerator)
        {
            this.tickMilliSecs = tickMilliSecs;
            this.ticks = ticks;
        }

        public override IEnumerable<Particle> Update()
        {

            if (this.Speed.Equals(this.stopToCreateNew))
            {
                IEnumerable<Particle> allParticles = base.Update();
                List<Particle> newChickenCreated = new List<Particle>(allParticles);

                newChickenCreated.Add(new ChickenParticle(this.Position, GetRandomCoorts(), this.randomSpeedGEnerator));
                //Thread.Sleep(this.tickMilliSecs * this.ticks);
                Thread.Sleep(this.tickMilliSecs);

                return newChickenCreated;
            }
            return base.Update();
        }

        public override char[,] GetImage()
        {
            return new char[,] { { (char)12 } }; 
        }
    }
}
