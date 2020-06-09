using System;
using System.Collections.Generic;
using System.Text;

namespace Opleidingscentrum
{
    interface IKost
    {
        void GegevensTonen();
        decimal MaandKost { get; }
    }
}
