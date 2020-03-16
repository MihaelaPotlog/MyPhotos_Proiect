using System;
using AutoMapper;
using MyPhotosApi.Api.MappingDomainToDto;


namespace MyPhotosApi
{
    static class AutomapperConfigure
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<PropertyTypeToPropertyDtoProfile>();
                cfg.AddProfile<PropertyTypeValuesProfile>();
                cfg.AddProfile<FileProfile>();
                cfg.AddProfile<PropertyDtoProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
    }
}
