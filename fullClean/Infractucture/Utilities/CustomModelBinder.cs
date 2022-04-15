using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;

namespace fullClean.Infractucture.Utilities
{
    public class CustomModelBinder<T> : IModelBinder
    {
   //revisar
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var propertiesName = bindingContext.ModelName;
            var providerValue = bindingContext.ValueProvider.GetValue(propertiesName);
            if(providerValue == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            try
            {
                var deserialized = JsonConvert.DeserializeObject<T>(providerValue.FirstValue);
                bindingContext.Result = ModelBindingResult.Success(deserialized);
            }
            catch
            {
                bindingContext.ModelState.TryAddModelError(propertiesName, "valor invalido para list<int>");
            }
            return Task.CompletedTask;

        }
    }
}
