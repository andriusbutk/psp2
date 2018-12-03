using E_Shop.Contract.Interfaces;
using E_Shop.Repository.Repositories;
using E_Shop.Service.Services;
using System;
using E_Shop.Contract.Interfaces.FacadeService;
using E_Shop.Contract.Services;
using E_Shop.Entity.FacadeCreation;
using E_Shop.Entity.InterfacesM;
using E_Shop.FacadeService.FacadeService;
using E_Shop.FacadeService.Interfaces;
using E_Shop.Integration.Integrations;
using E_Shop.Service.Interfaces;
using E_Shop.Service.Services.Computation;
using E_Shop.Service.Services.ComputerDefinition;
using E_Shop.Service.Services.Pricing;
using E_Shop.Service.Services.ProductCreationTime;
using E_Shop.Service.Services.ReviewServices;
using Unity;
using IImageFacadeService = E_Shop.FacadeService.Interfaces.IImageFacadeService;
using E_Shop.Service.Services.DateServices;
using E_Shop.Service.Services.DescriptionConcat;
using E_Shop.Service.Services.ImageCalculation;
using E_Shop.Service.Services.ProductDate;
using E_Shop.Service.Services.ProductPricing;
using E_Shop.Integration.Interfaces;

namespace E_Shop
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
           

            //repositories
            container.RegisterType<IImageRepository, ImageRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IManufacturerRepository,ManufacturerRepository>();

            //facade services
            container.RegisterType<IManufacturerFacadeService, OldDescriptionManufacturerFacadeService>();
            container.RegisterType<IImageFacadeService, ComplexImageFacadeService>();
            container.RegisterType<IProductFacadeService, LowProductFacadeService>();

            //services
            container.RegisterType<IComputationService, ComputationService>();
            container.RegisterType<IComputerDefinitionService, ComputerDefinitionService>();
            container.RegisterType<IPricingService, PricingWithDiscountService>();
            container.RegisterType<IProductCreationTimeService, ComplexProductCreationTimeService>();
            container.RegisterType<IReviewService, ProfesionalUserReviewService>();
            container.RegisterType<IDateService, DateUtcService>();
            container.RegisterType<IDescriptionConcatService, DescriptionConcatService>();
            container.RegisterType<IImageCalculationService, ImageCalculationService>();
            container.RegisterType<IProductDateCompatitionValue, ProductDateCompatitionValue>();
            container.RegisterType<IProductPricingService, ProductPricingService>();

            //facade service creation
            container.RegisterType<IImageFactoryCreation, ImageFactoryCreation>();
            container.RegisterType<IManufacturerFactoryCreation, ManufacturerFactoryCreation>();
            container.RegisterType<IProductFactoryCreation, ProductFactoryCreation>();

            //integrations
            container.RegisterType<IEmailSenderService, SMTPSenderService>();
        }
    }
}