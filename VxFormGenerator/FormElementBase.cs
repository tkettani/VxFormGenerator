using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using VxFormGenerator.Validation;

namespace VxFormGenerator
{
    public class FormElementBase<TFormElement> : OwningComponentBase
    {
        private string _Label;
        private FormGeneratorComponentsRepository _repo;
        private TFormElement fieldValue;

        /// <summary>
        /// Bindable property to set the class
        /// </summary>
        public string CssClass { get => string.Join(" ", CssClasses.ToArray()); }
        /// <summary>
        /// Setter for the classes of the form container
        /// </summary>
        [Parameter] public List<string> CssClasses { get; set; }

        
        /// <summary>
        /// The identifier for the <see cref="FormElement"/>"/> used by the label element
        /// </summary>
        [Parameter] public string Id { get; set; }

        /// <summary>
        /// The label for the <see cref="FormElement"/>, if not set, it will check for a <see cref="DisplayAttribute"/> on the <see cref="CascadedEditContext.Model"/>
        /// </summary>
        [Parameter]
        public string Label
        {
            get
            {
                var dd = CascadedEditContext.Model
                     .GetType()
                     .GetProperty(FieldIdentifier.Name)
                     .GetCustomAttributes(typeof(DisplayAttribute), false)
                     .FirstOrDefault() as DisplayAttribute;

                return _Label ?? dd?.Name;
            }
            set { _Label = value; }
        }

        /// <summary>
        /// The property that should generate a formcontrol
        /// </summary>
        [Parameter] public PropertyInfo FieldIdentifier { get; set; }

        /// <summary>
        /// Get the <see cref="EditForm.EditContext"/> instance. This instance will be used to fill out the values inputted by the user
        /// </summary>
        [CascadingParameter] EditContext CascadedEditContext { get; set; }

        protected override void OnInitialized()
        {
            // setup the repo containing the mappings
            _repo = ScopedServices.GetService(typeof(FormGeneratorComponentsRepository)) as FormGeneratorComponentsRepository;
        }

        public Expression<Func<TFormElement>> FieldExpression { get; set; }

        public TFormElement FieldValue
        {
            get
            {
                if (fieldValue == null)
                { 
                    fieldValue = (TFormElement)FieldIdentifier.GetValue(CascadedEditContext.Model);
                }
                return fieldValue;
            }
            set => fieldValue = value;
        }




    }
}