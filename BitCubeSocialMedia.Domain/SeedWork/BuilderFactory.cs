using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.SeedWork
{
    public class BuilderFactory <TBuilder> where TBuilder : class, IBuilder
    {
        public static TBuilder Create()
        {
            return (TBuilder)Activator.CreateInstance(typeof(TBuilder));
        }
    }
}
