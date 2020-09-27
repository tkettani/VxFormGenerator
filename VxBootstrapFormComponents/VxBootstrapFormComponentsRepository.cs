using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using VxBootstrapFormComponents.Components;
using VxFormGenerator;

namespace VxBootstrapFormComponents
{
    public class VxBootstrapFormComponentsRepository : FormGeneratorComponentsRepository
    {
        public VxBootstrapFormComponentsRepository()
        {

            _ComponentDict = new Dictionary<string, Type>()
                  {
                        {typeof(string).ToString(), typeof(BootstrapInputText) },
                        {typeof(DateTime).ToString(), typeof(InputDate<>) },
                        {typeof(bool).ToString(), typeof(BootstrapInputCheckbox) },
                        {typeof(Enum).ToString(), typeof(BootstrapInputSelectWithOptions<>) },
                        {typeof(ValueReferences<Enum>).ToString(), typeof(BootstrapInputCheckboxMultiple<>) },
                        {typeof(decimal).ToString(), typeof(BootstrapInputNumber<>) }
                       // {typeof(Color).ToString(), typeof(InputColor) }
                  };
            _DefaultComponent = null;
            FormElementComponent = typeof(BootstrapFormElement<>);
            
        }
     
    }
}
