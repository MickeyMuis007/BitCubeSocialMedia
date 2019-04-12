using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.SeedWork
{
    public interface IBuild<TBuilder, TBuild> : IBuilder where TBuilder : class, IBuilder where TBuild : class, IEntity
    {
        TBuilder Copy(TBuild copy);
        TBuild Build();
    }
}
