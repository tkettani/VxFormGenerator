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
    public class FormElementComponent<TFormElement> : FormElementBase<TFormElement>
    {
    }
}