using Bordfodbold.Abstract;
using Bordfodbold.Concrete;
using Bordfodbold.Models;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bordfodbold.Infrastructure {
  public class NinjectDependencyResolver : IDependencyResolver {
    private IKernel kernel;
    public NinjectDependencyResolver(IKernel kernelParam) {
      kernel = kernelParam;
      AddBindings();
    }
    public object GetService(Type serviceType) {
      return kernel.TryGet(serviceType);
    }
    public IEnumerable<object> GetServices(Type serviceType) {
      return kernel.GetAll(serviceType);
    }
    private void AddBindings() {
      //      Mock<ISpillerRepository> mock = new Mock<ISpillerRepository>();

      //      mock.Setup(m => m.Spillere).Returns(new List<Spiller>
      //{
      //    new Spiller { SpillerID = 0, Spiller_Name = "Jonas", Spiller_Maal = 1, Spiller_Kampe=2}

      //});

      //      kernel.Bind<ISpillerRepository>().ToConstant(mock.Object);
            kernel.Bind<ISpillerRepository>().To<EFSpillerRepository>();
    }
  }
}
