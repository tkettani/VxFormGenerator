using System.Collections.Generic;


namespace VxBootstrapFormComponents.Components
{
    public class BootstrapInputCheckbox : VxFormGenerator.Components.Plain.VxInputCheckbox
    {
        public BootstrapInputCheckbox()
        {
            ContainerCss = "custom-control custom-checkbox line-height-checkbox";
            AdditionalAttributes = new Dictionary<string, object>() { { "class", "custom-control-input" } };
            LabelCss = "custom-control-label";
        }
    }

}
