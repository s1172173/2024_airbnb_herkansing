using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace _2024_airbnb_herkansing.Options
{
    /// <summary>
    /// Automatically adds the v1 groupname to any controller where no explicit version is mentioned.
    /// </summary>
    public class ApiVersionBasedGroupingConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            if (controller.ApiExplorer.GroupName == null)
            {
                controller.ApiExplorer.GroupName = "v1";
                controller.ApiExplorer.IsVisible = true;
            }
        }
    }
}
