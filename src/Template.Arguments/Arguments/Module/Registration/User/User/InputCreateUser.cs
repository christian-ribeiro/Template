﻿using System.Text.Json.Serialization;
using Template.Arguments.Arguments.Module.Base;

namespace Template.Arguments.Arguments.Module.Registration;

[method: JsonConstructor]
public class InputCreateUser(string code, string name, string password, string email) : BaseInputCreate<InputCreateUser>
{
    public string Code { get; private set; } = code;
    public string Name { get; private set; } = name;
    public string Password { get; private set; } = password;
    public string Email { get; private set; } = email;
}