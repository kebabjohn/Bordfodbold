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
            //kernel.Bind<IKampRepository>().To<EFKamprepository>();
            //rigtig forbindelse
            DateTime date = new DateTime();
            //mock forbindelse
            Mock<IKampRepository> mock = new Mock<IKampRepository>();
            mock.Setup(me => me.kampe).Returns(new List<Kamp>
               { new Kamp {Kamp_ID=0, Spiller1_ID=1, Spiller2_ID=2, Spiller3_ID=3, Spiller4_ID=4, Dato=date, Tid=5 }});
            // authentication provider binding
            kernel.Bind<IAuhtProvider>().To<FormAuthProvider>();

            //mock IAuhtor
            Mock<IAuhtProvider> muck = new Mock<IAuhtProvider>();
          //  kernel.Bind<IAuhtProvider>().ToConstant(muck.Object);
            //setup laves i test klasse
    }
  }
}
