using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bordfodbold.Models;

namespace Bordfodbold.Abstract {
  public  interface IKampRepository {
        IEnumerable<Kamp> kampe { get; }

    }
}
