﻿using System.Text.Json.Serialization;
using Proto.Arguments.Arguments.Module.Base;

namespace Proto.Arguments.Arguments.Module.Registration;

[method: JsonConstructor]
public class InputCreateUserMenu(long menuId, int position, bool favorite, bool visible) : BaseInputCreate<InputCreateUserMenu>
{
    public long MenuId { get; private set; } = menuId;
    public int Position { get; private set; } = position;
    public bool Favorite { get; private set; } = favorite;
    public bool Visible { get; private set; } = visible;
}