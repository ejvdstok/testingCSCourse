using System;
using System.Collections.Generic;
using System.Text;

namespace Opleidingscentrum
{
    interface IKost
    {
        void Afbeelden();
        decimal MaandKost { get; }
    }
}
