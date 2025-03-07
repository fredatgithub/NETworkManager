﻿using NETworkManager.Profiles;
using System.Globalization;
using System.Windows.Controls;
using System.Linq;

namespace NETworkManager.Validators;

public class ProfileFileUniqueValidator : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        return ProfileManager.ProfileFiles.Any(x => x.Name == value as string) ? new ValidationResult(false, Localization.Resources.Strings.ProfileNameAlreadyExists) : ValidationResult.ValidResult;
    }
}
