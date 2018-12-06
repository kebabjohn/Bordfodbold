using Bordfodbold.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bordfodbold.Abstract {
  public interface ISpillerRepository {
    IEnumerable<Spiller> Spillere { get; }
  }
}
