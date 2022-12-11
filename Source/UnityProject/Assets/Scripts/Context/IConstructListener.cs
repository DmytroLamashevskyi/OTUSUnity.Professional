using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Context
{
    public interface IConstructListener
    {
        public void Construct(GameContext context);

    }
}
