using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using VxBootstrapFormComponents.Components;
using VxFormGenerator;
using VxFormGenerator.Repository;

namespace VxBootstrapFormComponents
{
    public class VxBootstrapFormComponentsRepository : FormGeneratorComponentModelBasedRepository
    {
        public VxBootstrapFormComponentsRepository()
        {

            _ComponentDict = new Dictionary<Type, Type>()
                  {
                        {typeof(string), typeof(BootstrapInputText) },
                        {typeof(DateTime), typeof(InputDate<>) },
                        {typeof(bool), typeof(BootstrapInputCheckbox) },
                        {typeof(Enum), typeof(BootstrapInputSelectWithOptions<>) },
                        {typeof(ValueReferences<Enum>), typeof(BootstrapInputCheckboxMultiple<>) },
                        {typeof(decimal), typeof(BootstrapInputNumber<>) }
                       // {typeof(Color).ToString(), typeof(InputColor) }
                  };
            DefaultComponent = null;
            FormElementComponent = typeof(BootstrapFormElement<>);
            
        }
     
    }
}
