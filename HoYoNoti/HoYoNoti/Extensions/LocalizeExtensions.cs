using HoYoNoti.Helpers;
using HoYoNoti.Resources.Strings;

using Microsoft.Extensions.Localization;

namespace HoYoNoti.Extensions;

[ContentProperty(nameof(Key))]
public class LocalizeExtensions : IMarkupExtension
{
    IStringLocalizer<AppStrings> _localizer;

    public string Key { get; set; } = string.Empty;

    public LocalizeExtensions()
    {
        _localizer = ServiceHelper.GetService<IStringLocalizer<AppStrings>>();
    }

    public object ProvideValue(IServiceProvider serviceProvider) => _localizer[Key];

    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => 
        ProvideValue(serviceProvider);
}
