﻿using Proto.Arguments.Arguments.Module.Base;

namespace Proto.Domain.DTO.Module.Base;

public class BaseExternalPropertiesDTO<TExternalPropertiesDTO> : BaseSetProperty<TExternalPropertiesDTO>
    where TExternalPropertiesDTO : BaseExternalPropertiesDTO<TExternalPropertiesDTO>, new()
{ }

public class BaseExternalPropertiesDTO_0 : BaseExternalPropertiesDTO<BaseExternalPropertiesDTO_0> { }