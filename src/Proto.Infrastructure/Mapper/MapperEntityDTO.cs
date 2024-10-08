﻿using AutoMapper;
using Proto.Domain.DTO.Module.General;
using Proto.Domain.DTO.Module.Registration;
using Proto.Infrastructure.Persistence.Entity.Module.General;
using Proto.Infrastructure.Persistence.Entity.Module.Registration;

namespace Proto.Infrastructure.Mapper;

public class MapperEntityDTO : Profile
{
    public MapperEntityDTO()
    {
        #region User
        CreateMap<User, UserDTO>()
            .ForMember(dest => dest.InternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.ExternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.AuxiliaryPropertiesDTO, opt => opt.MapFrom(src => src))
            .ReverseMap();

        CreateMap<User, InternalPropertiesUserDTO>().ReverseMap();
        CreateMap<User, ExternalPropertiesUserDTO>().ReverseMap();
        CreateMap<User, AuxiliaryPropertiesUserDTO>().ReverseMap();
        #endregion

        #region Menu
        CreateMap<Menu, MenuDTO>()
            .ForMember(dest => dest.InternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.AuxiliaryPropertiesDTO, opt => opt.MapFrom(src => src))
            .ReverseMap();

        CreateMap<Menu, InternalPropertiesMenuDTO>().ReverseMap();
        CreateMap<Menu, AuxiliaryPropertiesMenuDTO>().ReverseMap();
        #endregion

        #region UserMenu
        CreateMap<UserMenu, UserMenuDTO>()
            .ForMember(dest => dest.InternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.ExternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.AuxiliaryPropertiesDTO, opt => opt.MapFrom(src => src))
            .ReverseMap();

        CreateMap<UserMenu, InternalPropertiesUserMenuDTO>().ReverseMap();
        CreateMap<UserMenu, ExternalPropertiesUserMenuDTO>().ReverseMap();
        CreateMap<UserMenu, AuxiliaryPropertiesUserMenuDTO>().ReverseMap();
        #endregion

        #region EmailConfiguration
        CreateMap<EmailConfiguration, EmailConfigurationDTO>()
            .ForMember(dest => dest.InternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.ExternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.AuxiliaryPropertiesDTO, opt => opt.MapFrom(src => src))
            .ReverseMap();

        CreateMap<EmailConfiguration, InternalPropertiesEmailConfigurationDTO>().ReverseMap();
        CreateMap<EmailConfiguration, ExternalPropertiesEmailConfigurationDTO>().ReverseMap();
        CreateMap<EmailConfiguration, AuxiliaryPropertiesEmailConfigurationDTO>().ReverseMap();
        #endregion

        #region Brand
        CreateMap<Brand, BrandDTO>()
            .ForMember(dest => dest.InternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.ExternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.AuxiliaryPropertiesDTO, opt => opt.MapFrom(src => src))
            .ReverseMap();

        CreateMap<Brand, InternalPropertiesBrandDTO>().ReverseMap();
        CreateMap<Brand, ExternalPropertiesBrandDTO>().ReverseMap();
        CreateMap<Brand, AuxiliaryPropertiesBrandDTO>().ReverseMap();
        #endregion

        #region Product
        CreateMap<Product, ProductDTO>()
            .ForMember(dest => dest.InternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.ExternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.AuxiliaryPropertiesDTO, opt => opt.MapFrom(src => src))
            .ReverseMap();

        CreateMap<Product, InternalPropertiesProductDTO>().ReverseMap();
        CreateMap<Product, ExternalPropertiesProductDTO>().ReverseMap();
        CreateMap<Product, AuxiliaryPropertiesProductDTO>().ReverseMap();
        #endregion

        #region ProductCategory
        CreateMap<ProductCategory, ProductCategoryDTO>()
            .ForMember(dest => dest.InternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.ExternalPropertiesDTO, opt => opt.MapFrom(src => src))
            .ForMember(dest => dest.AuxiliaryPropertiesDTO, opt => opt.MapFrom(src => src))
            .ReverseMap();

        CreateMap<ProductCategory, InternalPropertiesProductCategoryDTO>().ReverseMap();
        CreateMap<ProductCategory, ExternalPropertiesProductCategoryDTO>().ReverseMap();
        CreateMap<ProductCategory, AuxiliaryPropertiesProductCategoryDTO>().ReverseMap();
        #endregion
    }
}