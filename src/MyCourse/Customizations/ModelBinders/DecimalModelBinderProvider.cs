using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace MyCourse.Customizations.ModelBinders
{
    public class DecimalModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            if ( context.Metadata.ModelType == typeof(decimal) ) 
            { 
                return new DecimalModelBinder();
            }

            return null;
        }
    }
}

