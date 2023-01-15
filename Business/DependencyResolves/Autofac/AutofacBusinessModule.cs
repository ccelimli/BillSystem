using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Helper.ImageHelper.Concrete;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //AnimalShelter
            builder.RegisterType<AnimalShelterManager>().As<IAnimalShelterService>().SingleInstance();
            builder.RegisterType<AnimalShelterDal>().As<IAnimalShelterDal>().SingleInstance();

            //Bank
            builder.RegisterType<BankManager>().As<IBankService>().SingleInstance();
            builder.RegisterType<BankDal>().As<IBankDal>().SingleInstance();

            //Bill
            builder.RegisterType<BillManager>().As<IBillService>().SingleInstance();
            builder.RegisterType<BillDal>().As<IBillDal>().SingleInstance();

            //BillImage
            builder.RegisterType<BillImageManager>().As<IBillImageService>().SingleInstance();
            builder.RegisterType<BillImageDal>().As<IBillImageDal>().SingleInstance();

            //Category
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<CategoryDal>().As<ICategoryDal>().SingleInstance();

            //City
            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<CityDal>().As<ICityDal>().SingleInstance();

            //Fag
            builder.RegisterType<FagManager>().As<IFagService>().SingleInstance();
            builder.RegisterType<FagDal>().As<IFagDal>().SingleInstance();

            //Foundation
            builder.RegisterType<FoundationManager>().As<IFoundationService>().SingleInstance();
            builder.RegisterType<FoundationDal>().As<IFoundationDal>().SingleInstance();

            //ImageHelper
            builder.RegisterType<ImageHelper>().As<ImageHelper>().SingleInstance();

            //Institution
            builder.RegisterType<InstitutionManager>().As<IInstitutionService>().SingleInstance();
            builder.RegisterType<InstitutionDal>().As<IInstitutionDal>().SingleInstance();

            //Platform
            builder.RegisterType<PlatformManager>().As<IPlatformService>().SingleInstance();
            builder.RegisterType<PlatformDal>().As<IPlatformDal>().SingleInstance();

            //User
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();

            var assembly=System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
               .EnableInterfaceInterceptors(new ProxyGenerationOptions()
               {
                   Selector = new AspectInterceptorSelector()
               }).SingleInstance();
        }
    }
}
