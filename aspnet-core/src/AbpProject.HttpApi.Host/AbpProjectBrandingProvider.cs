using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpProject;

[Dependency(ReplaceServices = true)]
public class AbpProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpProject";
}
