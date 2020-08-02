using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VxFormGenerator;
using VxFormGenerator.Components;

namespace VxFormGeneratorTests
{
    [TestClass]
    public class PocoConverterTest
    {

        public PocoConverterTest()
        {
            var services = new ServiceCollection();

            services.AddSingleton(new FormGeneratorComponentsRepository(
                 new Dictionary<string, Type>()
                 {
                        {typeof(string).ToString(), typeof(InputText) },
                        {typeof(DateTime).ToString(), typeof(InputDate<>) },
                        {typeof(bool).ToString(), typeof(BootstrapInputCheckbox) },
                        {typeof(FoodKind).ToString(), typeof(BootstrapInputSelectWithOptions<>) },
                        {typeof(ValueReferences<FoodKind>).ToString(), typeof(BootstrapInputCheckboxMultiple<>) },
                        {typeof(decimal).ToString(), typeof(InputNumber<>) }
                 }, null, typeof(FormElement<>)));
        }
    }

        [TestMethod]
        public void CreateValueReferences()
        {

        }
    }
}
